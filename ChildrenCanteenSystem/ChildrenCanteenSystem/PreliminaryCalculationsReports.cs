namespace ChildrenCanteenSystem
{
    using Common.MessagesAndTitles;
    using System;
    using System.Linq;
    using System.Windows.Forms;

    public partial class PreliminaryCalculationsReports : BaseForm
    {
        public PreliminaryCalculationsReports()
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
                    this.data.PreliminaryCalculations
                        .All()
                        .Where(p => p.Menu.Date >= fromDateSelected && p.Menu.Date <= toDateSelected)
                        .GroupBy(p => new
                        {
                            p.ProductId,
                            ProductName = p.Product.Name,
                            MeasurementUnit = p.Product.MeasurementUnit.Name
                        })
                        .Select(group => new
                        {
                            ProductId = group.Key.ProductId,
                            ProductName = group.Key.ProductName,
                            MeasurementUnit = group.Key.MeasurementUnit,
                            QuantityForThePeriod = group.Sum(p => p.Quantity)
                        });

                foreach (var product in productsFromPreliminaryCalculations)
                {
                    products.Rows.Add(
                        product.ProductId,
                        product.ProductName,
                        product.MeasurementUnit,
                        product.QuantityForThePeriod);
                }
            }
            else
            {
                MessageBox.Show("Моля изберете валиден интервал", MessageBoxesTitles.AttentionTitle);
            }
        }
    }
}
