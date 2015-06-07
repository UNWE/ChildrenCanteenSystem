namespace ChildrenCanteenSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using Common.DataTransferObjects;
    using Common.MessagesAndTitles;
    using Models;
    using PdfExporter;

    public partial class PreviewPreliminaryCalculation : BaseForm
    {
        private const int PortionsPerRecipe = 100;

        private DateTime menuDate;
        private int foodCards;
        private Dictionary<string, ProductDto> calculationData;
        private bool initialLoadingCompleted;
        private int currentRowEdited;

        public PreviewPreliminaryCalculation(User userProfile, DateTime date, int foodCards)
            : base(userProfile)
        {
            InitializeComponent();

            this.dateLabel.Text = date.ToLongDateString();
            this.foodCardsLabel.Text = string.Format("Продадени купони: {0}", foodCards);
            this.menuDate = date;
            this.foodCards = foodCards;
            this.initialLoadingCompleted = false;

            this.Text = FormsTitles.PreviewPreliminaryCalculationTitle;
        }

        private void exportToPdfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePdfFileDialog = new SaveFileDialog();
            var result = savePdfFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = savePdfFileDialog.FileName;
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                var exportData = new PreliminaryCalculationExportData
                {
                    Date = this.menuDate,
                    FoodCards = this.foodCards,
                    MenuMeals = base.data.Menus
                        .All()
                        .Where(m => m.Date == this.menuDate)
                        .Select(m => m.Meals.Select(meal => meal.Name))
                        .First(),
                    ProductsData = this.calculationData
                };

                var pdfExporter = new PdfPreliminaryCalculationExporter(exportData);
                pdfExporter.Export(directory, fileName);
            }
        }

        private void ReviewPreliminaryCalculation_Load(object sender, EventArgs e)
        {
            var mealsIds = base.data.Menus
                .All()
                .Where(m => m.Date == this.menuDate)
                .Select(m => m.Meals.Select(meal => meal.Id))
                .ToList()[0];

            var productsInMenu = data.Recipes
                .All()
                .Where(r => mealsIds.Contains(r.MealId))
                .Select(r => new
                {
                    r.ProductId,
                    r.Product.Name,
                    MeasurementUnit = r.Product.MeasurementUnit.Name,
                    Quantity = (float)Math.Round(((r.Quantity / PortionsPerRecipe) * this.foodCards), 4)
                });

            this.calculationData = new Dictionary<string, ProductDto>();
            foreach (var product in productsInMenu)
            {
                if (calculationData.ContainsKey(product.Name))
                {
                    calculationData[product.Name].Quantity += product.Quantity;
                }
                else
                {
                    calculationData[product.Name] = new ProductDto
                    {
                        ProductId = product.ProductId,
                        MeasurementUnit = product.MeasurementUnit,
                        Quantity = product.Quantity
                    };
                }
            }

            foreach (var product in calculationData)
            {
                this.productsDatagrid.Rows.Add(product.Key, product.Value.MeasurementUnit, product.Value.Quantity);
            }

            this.initialLoadingCompleted = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                ConfirmMessages.ConfirmSavePreliminaryCalculationMessage,
                MessageBoxesTitles.ConfirmTitle,
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var menuId = base.data.Menus.All().First(m => m.Date == this.menuDate).Id;

                foreach (var row in this.calculationData.Values)
                {
                    this.data.PreliminaryCalculations.Add(new PreliminaryCalculation
                    {
                        MenuId = menuId,
                        ProductId = row.ProductId,
                        Quantity = row.Quantity
                    });
                }

                this.data.Menus.All().First(m => m.Date == this.menuDate).FoodCards = this.foodCards;

                var saveResult = base.data.SaveChanges();
                if (saveResult > 0)
                {
                    MessageBox.Show(
                        SuccessMessages.PreliminaryCalculationSavedSuccessfullyMessage,
                        MessageBoxesTitles.SuccessTitle);
                    this.DialogResult = DialogResult.Ignore;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        ErrorMessages.PreliminaryCalculationNotSavedMessage,
                        MessageBoxesTitles.AttentionTitle);
                }
            }
        }

        private void productsDatagrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.initialLoadingCompleted)
            {
                var product = productsDatagrid.Rows[this.currentRowEdited].Cells[0].Value.ToString();
                var quantity =
                    productsDatagrid.Rows[this.currentRowEdited].Cells[2].Value != null ?
                        productsDatagrid.Rows[this.currentRowEdited].Cells[2].Value.ToString() : "";
                float quantityAsFloat;
                if (float.TryParse(quantity, out quantityAsFloat))
                {
                    if (quantityAsFloat <= 0)
                    {
                        saveButton.Enabled = false;
                        exportToPdfButton.Enabled = false;
                    }
                    else
                    {
                        this.calculationData[product].Quantity = quantityAsFloat;
                        saveButton.Enabled = true;
                        exportToPdfButton.Enabled = true;
                    }
                }
                else
                {
                    saveButton.Enabled = false;
                    exportToPdfButton.Enabled = false;
                }
            }
        }

        private void productsDatagrid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.currentRowEdited = productsDatagrid.CurrentCell.RowIndex;
        }
    }
}
