namespace ChildrenCanteenSystem
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    using Common.DataTransferObjects;
    using Common.MessagesAndTitles;
    using Models;

    public partial class NewRequest : BaseForm
    {
        private Dictionary<int, Dictionary<int, float>> requestData;
        private int availabilityEditingRowIndex;
        private int availabilityEditingId;
        private int productEditingRowIndex;
        private int productEditingId;
        private bool hasSelectedAvailability;
        private DateTime requestDate;
        private bool dateHasBeenInitialized = false;

        private const int ProductsDatagridProductIdCellIndex = 0;
        private const int ProductsDatagridPreliminaryCalculatedCellIndex = 3;
        private const int ProductsDatagridRequestedQuantityCellIndex = 4;

        private const int AvailabilitiesDatagridAvailabilityIdCellIndex = 0;
        private const int AvailabilitiesDatagridRequestedQuantityCellIndex = 5;

        public NewRequest(User userProfile)
            : base(userProfile)
        {
            InitializeComponent();

            this.requestData = new Dictionary<int, Dictionary<int, float>>();
            hasSelectedAvailability = false;

            #region Form settings

            this.Text = FormsTitles.NewRequestTitle;
            this.StartPosition = FormStartPosition.CenterScreen;
            date.Format = DateTimePickerFormat.Custom;
            date.CustomFormat = " ";
            products.Enabled = false;
            availabilities.Enabled = false;

            #endregion
        }

        public NewRequest(User userProfile, DateTime date)
            : base(userProfile)
        {
            InitializeComponent();

            this.requestData = new Dictionary<int, Dictionary<int, float>>();
            hasSelectedAvailability = false;

            this.requestDate = date;
            this.dateHasBeenInitialized = true;

            #region Form settings

            this.Text = FormsTitles.NewRequestTitle;
            this.StartPosition = FormStartPosition.CenterScreen;
            products.Enabled = false;
            availabilities.Enabled = false;

            #endregion
        }

        private void NewRequest_Load(object sender, EventArgs e)
        {
            if (this.dateHasBeenInitialized)
            {
                this.date.Value = this.requestDate;
            }
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            date.Format = DateTimePickerFormat.Long;
            var dateSelected = date.Value.Date;
            var requestExixts = this.data.Requests.All().Any(r => r.Menu.Date == dateSelected);
            if (!requestExixts)
            {
                var preliminaryCalculationExists = this.data.PreliminaryCalculations
                .All()
                .FirstOrDefault(p => p.Menu.Date == dateSelected);

                if (preliminaryCalculationExists != null)
                {
                    var preliminaruCalculationData = this.data.PreliminaryCalculations
                        .All()
                        .Where(p => p.Menu.Date == date.Value.Date)
                        .Select(PreliminaryCalculationDto.DtoModel);
                    products.ScrollBars = ScrollBars.None;

                    foreach (var product in preliminaruCalculationData)
                    {
                        this.products.Rows.Add(product.ProductId, product.ProductName, product.MesurementUnit, product.Quantity, 0f);
                    }

                    products.ScrollBars = ScrollBars.Both;
                    products.Enabled = true;
                    availabilities.Enabled = true;
                }
                else
                {
                    var result = MessageBox.Show(
                        string.Format(
                            ConfirmMessages.NonExistingPreliminaryCalculationConfirmCreateNewMessage,
                            dateSelected.ToLongDateString()),
                        MessageBoxesTitles.AttentionTitle,
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        var newPreliminaryCalculationForm =
                            new NewPreliminaryCalculation(this.UserProfile, dateSelected);
                        newPreliminaryCalculationForm.Show();
                        this.Close();
                    }
                    else
                    {
                        date.Format = DateTimePickerFormat.Custom;
                        date.CustomFormat = " ";
                    }
                }
            }
            else
            {
                var result = MessageBox.Show(
                    string.Format(
                        ConfirmMessages.ExistingRequestConfirmPreviewMessage,
                        dateSelected.ToLongDateString()),
                    MessageBoxesTitles.AttentionTitle,
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    var reviewRequestForm = new ReviewRequest(dateSelected);
                    reviewRequestForm.Show();
                }
            } 
        }

        private void products_SelectionChanged(object sender, EventArgs e)
        {
            int lastRowIndex = products.RowCount - 1;
            productEditingRowIndex = products.SelectedRows[0].Index;
            bool rowCanBeSelected = productEditingRowIndex < lastRowIndex;
            if (rowCanBeSelected)
            {
                productEditingId = (int)products.Rows[productEditingRowIndex].Cells[ProductsDatagridProductIdCellIndex].Value;
                var productAvailabilities = this.data.Availabilities
                    .All()
                    .Where(a => a.ProductId == productEditingId)
                    .Select(AvailabilityDto.DtoModel);

                availabilities.Rows.Clear();

                foreach (var productAvailability in productAvailabilities)
                {
                    this.availabilities.Rows.Add(
                        productAvailability.AvailabilityId,
                        productAvailability.ProductId,
                        productAvailability.Batch,
                        productAvailability.UnitPrice,
                        productAvailability.Quantity);
                }

                if (this.requestData.ContainsKey(productEditingId))
                {
                    if (this.requestData[productEditingId].Any())
                    {
                        foreach (var availability in this.requestData[productEditingId].ToList())
                        {
                            var row = availabilities.Rows
                                .Cast<DataGridViewRow>()
                                .Take(2)
                                .FirstOrDefault(r => r.Cells[AvailabilitiesDatagridAvailabilityIdCellIndex].Value.ToString().Equals(availability.Key.ToString()));
                            if (row != null)
                            {
                                row.Cells[AvailabilitiesDatagridRequestedQuantityCellIndex].Value = availability.Value;
                            }
                        }
                    }
                }
            }
        }

        private void availabilities_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (hasSelectedAvailability)
            {
                var cellInputValue = availabilities.Rows[availabilityEditingRowIndex].Cells[AvailabilitiesDatagridRequestedQuantityCellIndex].Value;
                if (cellInputValue != null)
                {
                    float cellValue;
                    bool isFloat = float.TryParse(cellInputValue.ToString(), out cellValue);
                    if (isFloat)
                    {
                        if (cellValue > 0)
                        {
                            if (!this.requestData.ContainsKey(productEditingId))
                            {
                                this.requestData.Add(productEditingId,
                                    new Dictionary<int, float>());
                            }

                            if (!this.requestData[productEditingId].ContainsKey(availabilityEditingId))
                            {
                                this.requestData[productEditingId].Add(availabilityEditingId, 0f);
                            }

                            this.requestData[productEditingId][availabilityEditingId] = cellValue;
                            products.Rows[productEditingRowIndex].Cells[ProductsDatagridRequestedQuantityCellIndex].Value =
                                this.requestData[productEditingId].Sum(p => p.Value);

                            if (((float)products.Rows[productEditingRowIndex].Cells[ProductsDatagridRequestedQuantityCellIndex].Value).Equals(
                                (float)products.Rows[productEditingRowIndex].Cells[ProductsDatagridPreliminaryCalculatedCellIndex].Value))
                            {
                                products.Rows[productEditingRowIndex].Cells[ProductsDatagridRequestedQuantityCellIndex].Style.ForeColor = Color.Green;
                            }
                            else
                            {
                                products.Rows[productEditingRowIndex].Cells[ProductsDatagridRequestedQuantityCellIndex].Style.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        availabilities.Rows[availabilityEditingRowIndex].Cells[AvailabilitiesDatagridRequestedQuantityCellIndex].Value = string.Empty;
                    }
                }

                hasSelectedAvailability = false;
            }
        }

        private void availabilities_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            hasSelectedAvailability = true;
            availabilityEditingRowIndex = availabilities.SelectedRows[0].Index;
            availabilityEditingId = (int)availabilities.SelectedRows[0].Cells[AvailabilitiesDatagridAvailabilityIdCellIndex].Value;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            var previewRequestData = new RequestData();
            previewRequestData.Products = this.data.PreliminaryCalculations
                    .All()
                    .Where(p => p.Menu.Date == date.Value.Date)
                    .Select(PreliminaryCalculationDto.DtoModel)
                    .ToList();
            foreach (var product in previewRequestData.Products)
            {
                if (this.requestData.ContainsKey(product.ProductId))
                {
                    var availabilitiesRequested = this.requestData[product.ProductId].Keys.ToList();
                    previewRequestData.Availabilities
                        .Add(
                            product.ProductId,
                            this.data.Availabilities
                                .All()
                                .Where(a => availabilitiesRequested.Contains(a.Id))
                                .Select(a => new AvailabilityDto
                                {
                                    AvailabilityId = a.Id,
                                    ProductId = a.ProductId,
                                    Batch = a.Batch,
                                    UnitPrice = a.UnitPrice
                                })
                                .ToList());

                    foreach (var availability in previewRequestData.Availabilities[product.ProductId])
                    {
                        availability.Quantity = this.requestData[product.ProductId][availability.AvailabilityId];
                    }
                }
                else
                {
                    MessageBox.Show(
                        ErrorMessages.NotFinishedRequestMessage,
                        MessageBoxesTitles.AttentionTitle);
                    return;
                }
            }

            var previewRequestForm = new PreviewRequest(this.UserProfile, date.Value.Date, previewRequestData);
            previewRequestForm.Show();
        }
    }
}