namespace Common.DataTransferObjects
{
    public class AvailabilityDto
    {
        public int AvailabilityId { get; set; }

        public int ProductId { get; set; }

        public string Batch { get; set; }

        public float Quantity { get; set; }
    }
}
