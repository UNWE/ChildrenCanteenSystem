namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Common.DataTransferObjects;
    using Models;

    public partial class PreviewRequest : BaseForm
    {
        private RequestData requestData;
        private DateTime date;

        public PreviewRequest(User userProfile, DateTime date, RequestData requestData)
            :base(userProfile)
        {
            InitializeComponent();
            this.requestData = requestData;
            this.date = date;

            #region Form settings

            this.dateLabel.Text = string.Format("Искане за дата {0}", date.ToLongDateString());

            #endregion
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreviewRequest_Load(object sender, EventArgs e)
        {
            foreach (var product in requestData.Products)
            {
                this.products.Rows.Add(product.ProductId, product.ProductName, product.MesurementUnit, product.Quantity);
            }
        }

        private void products_SelectionChanged(object sender, EventArgs e)
        {
            availabilities.Rows.Clear();
            var productSelectedRowIndex  = products.SelectedRows[0].Index;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var menuId = this.data.Menus.All().First(m => m.Date == this.date).Id;

                foreach (var availability in this.requestData.Availabilities)
                {
                    foreach (var requestedAvailability in availability.Value)
                    {
                        this.data.Requests.Add(new Request
                        {
                            MenuId = menuId,
                            AvailabilityId = requestedAvailability.AvailabilityId,
                            Quantity = requestedAvailability.Quantity
                        });

                        var availabilityEntity = this.data.Availabilities
                            .Find(requestedAvailability.AvailabilityId);
                        availabilityEntity.Quantity -= requestedAvailability.Quantity;
                        this.data.Availabilities.Update(availabilityEntity);
                    } 
                }

                var saveResult = this.data.SaveChanges();
                if (saveResult > 0)
                {
                    MessageBox.Show("Success", "");
                }
                else
                {
                    MessageBox.Show("Failed", "");
                }
            }
        }
    }
}
