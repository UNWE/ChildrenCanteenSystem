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

    public partial class ReviewPreliminaryCalculation : BaseForm
    {
        private DateTime date;
        private Dictionary<string, ProductDto> calculationData;

        public ReviewPreliminaryCalculation(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();
            
            #region Form settings

            this.Text = FormsTitles.PreviewPreliminaryCalculationTitle;
            this.StartPosition = FormStartPosition.CenterParent;
            this.dateLabel.Visible = false;
            this.editButton.Visible = false;
            this.saveButton.Visible = false;
            this.deleteButton.Visible = false;
            this.datePicker.Visible = true;
            this.reviewButton.Visible = true;
            this.date = DateTime.MinValue;

            #endregion
        }

        public ReviewPreliminaryCalculation(User userProfile, DateTime date)
            : base(userProfile)
        {
            InitializeComponent();

            this.date = date;
            this.LoadPreliminaryCalculationData(this.date);

            #region Form settings

            this.Text = FormsTitles.PreviewPreliminaryCalculationTitle;
            this.StartPosition = FormStartPosition.CenterParent;
            this.dateLabel.Text = string.Format(
               "Предварителна калкулация за дата {0}",
               date.ToLongDateString());
            this.editButton.Visible = true;
            this.saveButton.Visible = false;
            this.deleteButton.Visible = false;
            this.datePicker.Visible = false;
            this.reviewButton.Visible = false;

            #endregion
        }

        private void exportCalculationButton_Click(object sender, EventArgs e)
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
                    Date = this.date,
                    FoodCards = base.data.Menus.All().First(m => m.Date == this.date).FoodCards.Value,
                    MenuMeals = base.data.Menus
                        .All()
                        .Where(m => m.Date == this.date)
                        .Select(m => m.Meals.Select(meal => meal.Name))
                        .First(),
                    ProductsData = this.calculationData
                };

                var pdfExporter = new PdfPreliminaryCalculationExporter(exportData);
                var saveResult = pdfExporter.Export(directory, fileName);
                if (saveResult == 1)
                {
                    MessageBox.Show(SuccessMessages.PreliminaryCalculationExportedSuccessfullyMessage);
                }
                else
                {
                    MessageBox.Show(ErrorMessages.PreliminaryCalculationNotSavedMessage);
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.productsDatagrid.Columns[2].ReadOnly = false;
            this.saveButton.Visible = true;
            this.deleteButton.Visible = true;
            this.editButton.Visible = false;
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            var dateSelected = datePicker.Value.Date;
            this.date = dateSelected;
            this.LoadPreliminaryCalculationData(dateSelected);
        }

        private void LoadPreliminaryCalculationData(DateTime menuDate)
        {
            var menu = base.data.Menus
                .All()
                .Where(m => m.Date == menuDate)
                .FirstOrDefault(m => m.Date == menuDate);
            if (menu != null)
            {
                var menuId = menu.Id;
                var preliminaruCalculationData = data.PreliminaryCalculations
                    .All()
                    .Where(p => p.MenuId == menuId)
                    .Select(p => new
                    {
                        Name = p.Product.Name,
                        ProductId = p.ProductId,
                        MeasurementUnit = p.Product.MeasurementUnit.Name,
                        Quantity = p.Quantity
                    });

                if (preliminaruCalculationData.Any())
                {
                    this.calculationData = new Dictionary<string, ProductDto>();
                    foreach (var product in preliminaruCalculationData)
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

                    foreach (var product in preliminaruCalculationData)
                    {
                        this.productsDatagrid.Rows.Add(product.Name, product.MeasurementUnit, product.Quantity);
                    }

                    editButton.Visible = true;
                }
                else
                {
                    var result = MessageBox.Show(
                        string.Format(
                            ConfirmMessages.NonExistingPreliminaryCalculationConfirmCreateNewMessage,
                            menuDate),
                        MessageBoxesTitles.AttentionTitle,
                        MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        var newMenuForm = new NewPreliminaryCalculation(this.UserProfile, this.date);
                        newMenuForm.Show();
                        this.Close();
                    } 
                }
            }
            else
            {
                var result = MessageBox.Show(
                    string.Format(
                        ConfirmMessages.NotExistingMenuConfirmCreateNew,
                        menuDate),
                    MessageBoxesTitles.AttentionTitle,
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var newMenuForm = new NewMenu(this.UserProfile, this.date);
                    newMenuForm.Show();
                    this.Close();
                }
            } 
        }
    }
}
