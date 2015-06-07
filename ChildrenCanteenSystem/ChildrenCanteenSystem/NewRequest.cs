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

        public NewRequest(User userProfile) : base(userProfile)
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

        private void date_ValueChanged(object sender, EventArgs e)
        {
            date.Format = DateTimePickerFormat.Long;
            var dateSelected = date.Value.Date;
            var preliminaryCalculationExists = this.data.PreliminaryCalculations
                .All()
                .FirstOrDefault(p => p.Menu.Date == dateSelected);

            if (preliminaryCalculationExists != null)
            {
                var preliminaruCalculationData = this.data.PreliminaryCalculations
                    .All()
                    .Where(p => p.Menu.Date == date.Value.Date)
                    .Select(
                        p => new PreliminaryCalculationDto
                        {
                            ProductId = p.ProductId,
                            ProductName = p.Product.Name,
                            Quantity = p.Quantity
                        }
                    );

                foreach (var product in preliminaruCalculationData)
                {
                    this.products.Rows.Add(product.ProductId, product.ProductName, product.Quantity, 0f);
                }

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
                    var menu = this.data.Menus
                        .All()
                        .FirstOrDefault(m => m.Date == dateSelected);
                    if (menu == null)
                    {
                        result = MessageBox.Show(
                            string.Format(
                                ConfirmMessages.NonExistingMenuConfirmCreateNewMessage,
                                dateSelected.ToLongDateString()),
                            MessageBoxesTitles.AttentionTitle,
                            MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            var newMenuForm = new NewMenu(this.UserProfile, dateSelected);
                            newMenuForm.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        var newPreliminaryCalculationForm =
                            new NewPreliminaryCalculation(this.UserProfile, dateSelected);
                        newPreliminaryCalculationForm.Show();
                        this.Close();
                    }
                }
            }
        }

        private void products_SelectionChanged(object sender, EventArgs e)
        {
            if (products.SelectedRows.Count > 0)
            {
                productEditingRowIndex  = products.SelectedRows[0].Index;
                productEditingId = (int)products.Rows[productEditingRowIndex].Cells[0].Value;
                var productAvailabilities = this.data.Availabilities
                    .All()
                    .Where(a => a.ProductId == productEditingId)
                    .Select(a => new AvailabilityDto
                    {
                        AvailabilityId = a.Id,
                        ProductId = a.ProductId,
                        Batch = a.Batch,
                        Quantity = a.Quantity
                    });

                availabilities.Rows.Clear();

                foreach (var productAvailability in productAvailabilities)
                {
                    this.availabilities.Rows.Add(
                        productAvailability.AvailabilityId,
                        productAvailability.ProductId,
                        productAvailability.Batch,
                        productAvailability.Quantity);
                }

                if (this.requestData.ContainsKey(productEditingId))
                {
                    if (this.requestData[productEditingId].Any())
                    {
                        var availabilitiesRows = availabilities.Rows
                                .Cast<DataGridViewRow>()
                                .Take(2);
                        foreach (var availability in this.requestData[productEditingId].ToList())
                        {
                            availabilitiesRows
                                .First(r => r.Cells[0].Value.ToString().Equals(availability.Key.ToString()))
                                .Cells[4].Value = availability.Value;
                        }
                    }
                }

            }
        }

        private void availabilities_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (hasSelectedAvailability)
            {
                var cellInputValue = availabilities.Rows[availabilityEditingRowIndex].Cells[4].Value;
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
                            products.Rows[productEditingRowIndex].Cells[3].Value =
                                this.requestData[productEditingId].Sum(p => p.Value);

                            if (((float)products.Rows[productEditingRowIndex].Cells[3].Value).Equals(
                                (float)products.Rows[productEditingRowIndex].Cells[2].Value))
                            {
                                products.Rows[productEditingRowIndex].Cells[3].Style.ForeColor = Color.Green;
                            }
                            else
                            {
                                products.Rows[productEditingRowIndex].Cells[3].Style.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        availabilities.Rows[availabilityEditingRowIndex].Cells[4].Value = string.Empty;
                    }
                } 
            }
        }

        private void availabilities_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            hasSelectedAvailability = true;
            availabilityEditingRowIndex = availabilities.SelectedRows[0].Index;
            availabilityEditingId = (int)availabilities.SelectedRows[0].Cells[0].Value;
        }
    }
}