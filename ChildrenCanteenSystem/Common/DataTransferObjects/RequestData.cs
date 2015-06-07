namespace Common.DataTransferObjects
{
    using System.Collections.Generic;

    public class RequestData
    {
        public RequestData()
        {
            this.Products = new List<PreliminaryCalculationDto>();
            this.Availabilities = new Dictionary<int, IList<AvailabilityDto>>();
        }

        public ICollection<PreliminaryCalculationDto> Products { get; set; } 

        public IDictionary<int, IList<AvailabilityDto>> Availabilities { get; set; } 
    }
}
