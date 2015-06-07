namespace Common.DataTransferObjects
{
    using System;
    using System.Linq.Expressions;
    using Models;

    public class AvailabilityDto
    {
        public int AvailabilityId { get; set; }

        public int ProductId { get; set; }

        public string Batch { get; set; }

        public float Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public static Expression<Func<Availability, AvailabilityDto>> DtoModel
        {
            get
            {
                return a => new AvailabilityDto
                {
                    AvailabilityId = a.Id,
                    ProductId = a.ProductId,
                    Batch = a.Batch,
                    UnitPrice = a.UnitPrice,
                    Quantity = a.Quantity
                };
            }
        }
    }
}
