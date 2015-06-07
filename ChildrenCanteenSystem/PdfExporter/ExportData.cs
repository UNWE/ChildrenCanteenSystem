namespace PdfExporter
{
    using System;
    using System.Collections.Generic;
    using Common.DataTransferObjects;

    public class ExportData
    {
        public IEnumerable<string> MenuMeals { get; set; }

        public int FoodCards { get; set; }

        public DateTime Date { get; set; }

        public Dictionary<string, ProductDto> ProductsData { get; set; }
    }
}
