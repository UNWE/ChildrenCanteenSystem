namespace PdfExporter
{
    using System;
    using System.Collections.Generic;
    using Common.DataTransferObjects;

    public class RequestExportData
    {
        public IEnumerable<string> MenuMeals { get; set; }

        public int FoodCards { get; set; }

        public DateTime Date { get; set; }

        public RequestData ProductsData { get; set; }
    }
}
