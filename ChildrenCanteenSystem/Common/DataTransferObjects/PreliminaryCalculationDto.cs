namespace Common.DataTransferObjects
{
    using System;
    using System.Linq.Expressions;
    using Models;

    public class PreliminaryCalculationDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public float Quantity { get; set; }

        public string MesurementUnit { get; set; }

        public static Expression<Func<PreliminaryCalculation, PreliminaryCalculationDto>> DtoModel
        {
            get
            {
                return e => new PreliminaryCalculationDto
                {
                    ProductId = e.ProductId,
                    ProductName = e.Product.Name,
                    MesurementUnit = e.Product.MeasurementUnit.Name,
                    Quantity = e.Quantity
                };
            }
        }
    }
}
