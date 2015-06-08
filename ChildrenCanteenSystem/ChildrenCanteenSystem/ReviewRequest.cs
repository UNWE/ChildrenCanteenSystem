namespace ChildrenCanteenSystem
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    using Common.DataTransferObjects;
    using Common.MessagesAndTitles;
    using PdfExporter;

    public partial class ReviewRequest : BaseForm
    {
        private RequestData requestData;
        private DateTime requestDate;

        public ReviewRequest()
        {
            InitializeComponent();

            this.requestData = new RequestData();

            #region Form settings

            this.requestDataLabel.Visible = false;
            this.date.Visible = true;
            this.dateLabel.Visible = true;
            this.pdfExportButton.Enabled = false;
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = " ";

            #endregion
        }

        public ReviewRequest(DateTime date)
        {
            InitializeComponent();

            this.requestData = new RequestData();
            this.requestDate = date;

            #region Form settings
            this.requestDataLabel.Visible = true;
            this.requestDataLabel.Text =
                string.Format("Искане за дата {0}", this.requestDate.ToLongDateString());
            this.date.Visible = false;
            this.dateLabel.Visible = false;
            #endregion

            this.LoadRequestData(this.requestDate);
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            this.date.Format = DateTimePickerFormat.Long;
            this.requestDate = this.date.Value.Date;
            var hasRequestForDate = this.LoadRequestData(this.requestDate);
            if (!hasRequestForDate)
            {
                var result = MessageBox.Show(
                    string.Format(
                        "За дата {0} няма съставено искане. Желаете ли да съставите сега",
                        this.requestDate.ToLongDateString()),
                    MessageBoxesTitles.AttentionTitle, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var newRequestForm = new NewRequest(this.UserProfile, this.requestDate);
                    newRequestForm.Show();
                    this.Close();
                }
            }
        }

        private void products_SelectionChanged(object sender, EventArgs e)
        {
            availabilities.Rows.Clear();
            var productSelectedRowIndex = products.SelectedRows[0].Index;
            var productSelectedId = (int)products.Rows[productSelectedRowIndex].Cells[0].Value;
            foreach (var productAvailability in requestData.Availabilities[productSelectedId])
            {
                this.availabilities.Rows.Add(
                    productAvailability.AvailabilityId,
                    productAvailability.ProductId,
                    productAvailability.Batch,
                    productAvailability.UnitPrice,
                    productAvailability.Quantity);
            }
        }

        private bool LoadRequestData(DateTime date)
        {
            var hasRequestForDate = false;
            if (this.data.Requests.All().Any(r => r.Menu.Date == date))
            {
                hasRequestForDate = true;
                requestData.Products = this.data.Requests
                    .All()
                    .Where(r => r.Menu.Date == date)
                    .GroupBy(r => new { ProductId = r.Availability.ProductId, ProductName = r.Availability.Product.Name, MeasurementUnit = r.Availability.Product.MeasurementUnit.Name })
                    .Select(r => new PreliminaryCalculationDto
                    {
                        ProductId = r.Key.ProductId,
                        ProductName = r.Key.ProductName,
                        MesurementUnit = r.Key.MeasurementUnit,
                        Quantity = r.Sum(p => p.Quantity)
                    })
                    .ToList();

                foreach (var product in requestData.Products)
                {
                    requestData.Availabilities
                        .Add(
                            product.ProductId,
                            this.data.Requests
                                .All()
                                .Where(a => a.Availability.ProductId == product.ProductId)
                                .Select(a => new AvailabilityDto
                                {
                                    AvailabilityId = a.AvailabilityId,
                                    ProductId = a.Availability.ProductId,
                                    Batch = a.Availability.Batch,
                                    UnitPrice = a.Availability.UnitPrice,
                                    Quantity = a.Quantity
                                })
                                .ToList());
                }

                foreach (var product in requestData.Products)
                {
                    this.products.Rows.Add(product.ProductId, product.ProductName, product.MesurementUnit, product.Quantity);
                }
            }

            return hasRequestForDate;

        }

        private void pdfExportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savePdfFileDialog = new SaveFileDialog();
            var result = savePdfFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = savePdfFileDialog.FileName;
                string directory = Path.GetDirectoryName(filePath);
                string fileName = Path.GetFileName(filePath);
                var exportData = new RequestExportData
                {
                    Date = this.requestDate,
                    FoodCards = base.data.Menus.All().First(m => m.Date == this.requestDate).FoodCards.Value,
                    MenuMeals = base.data.Menus
                        .All()
                        .Where(m => m.Date == this.requestDate)
                        .Select(m => m.Meals.Select(meal => meal.Name))
                        .First(),
                    ProductsData = this.requestData
                };

                var pdfExporter = new PdfRequestExporter(exportData);
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
    }
}
