namespace ChildrenCanteenSystem
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Common.MessagesAndTitles;

    public partial class RequestsReports : BaseForm
    {
        public RequestsReports()
        {
            InitializeComponent();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            var fromDateSelected = fromDate.Value.Date;
            var toDateSelected = toDate.Value.Date;

            if (fromDateSelected < toDateSelected)
            {
                var productsFromPreliminaryCalculations =
                    this.data.Requests
                        .All()
                        .Where(p => p.Menu.Date >= fromDateSelected && p.Menu.Date <= toDateSelected)
                        .GroupBy(p => new
                        {
                            p.Availability.ProductId,
                            ProductName = p.Availability.Product.Name,
                            MeasurementUnit = p.Availability.Product.MeasurementUnit.Name,
                            Batch = p.Availability.Batch
                        })
                        .Select(group => new
                        {
                            ProductId = group.Key.ProductId,
                            ProductName = group.Key.ProductName,
                            MeasurementUnit = group.Key.MeasurementUnit,
                            Batch = group.Key.Batch,
                            QuantityForThePeriod = group.Sum(p => p.Quantity)
                        });

                foreach (var product in productsFromPreliminaryCalculations)
                {
                    products.Rows.Add(
                        product.ProductId,
                        product.ProductName,
                        product.MeasurementUnit,
                        product.Batch,
                        product.QuantityForThePeriod);
                }
            }
            else
            {
                MessageBox.Show(
                    ErrorMessages.NotAValidDateInterval,
                    MessageBoxesTitles.AttentionTitle);
            }
        }
    }
}
