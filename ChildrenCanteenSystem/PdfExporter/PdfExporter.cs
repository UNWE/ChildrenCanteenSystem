namespace PdfExporter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using iTextSharp.text;
    using iTextSharp.text.pdf;

    public class PdfExporter
    {
        // File Parameters
        private readonly string[] defaultCellsHeadings = new[] { "Код", "Продукт", "Мярка", "Количество" };

        // Text
        private readonly string Title = "Детска кухня";
        private readonly string Subtitle = "Предварителна калкулация" + Environment.NewLine + "за дата {0}";
        private readonly string FoodCardsTotal = "Брой закупени купони: {0}";
        private readonly string Menu = "Меню" + Environment.NewLine +
            "1. {0}" + Environment.NewLine + "2. {1}" + Environment.NewLine + "3. {2}";

        // Table settings
        private readonly int DefaultColumnsNumber = 4;
        private readonly string DefaultDateFormat = "dd-MMM-yyyy";
        private readonly float[] tableDefaultColumnWidths = new[] { 2f, 2f, 2f, 2f };

        // Fonts
        private static string untfFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
        private static BaseFont utfFont = BaseFont.CreateFont(untfFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        private readonly Font defaultHeadingFont = new Font(utfFont, 11);
        private readonly Font defaultCellFont = new Font(utfFont, 10);

        private ExportData data { get; set; }

        public PdfExporter(ExportData data)
        {
            this.Data = data;
        }

        public ExportData Data
        {
            get { return this.data; }

            set { this.data = value; }
        }

        public int Export(string directorty, string fileName)
        {
            int result = -1;
            var filePath = directorty + Path.DirectorySeparatorChar + fileName + ".pdf";
            var pdfDocument = new Document(PageSize.A4);
            var output = new FileStream(filePath, FileMode.Create);
            var pdfWriter = PdfWriter.GetInstance(pdfDocument, output);

            try
            {
                using (pdfWriter)
                {
                    pdfDocument.Open();
                    this.PopulateDataTable(ref pdfDocument);
                    pdfDocument.Close();
                    result = 1;
                }
            }
            catch (Exception)
            {
                result = -1;
            }
            
            return result;
        }

        private void PopulateDataTable(ref Document pdfDocument)
        {
            var dataTable = new PdfPTable(this.DefaultColumnsNumber);
            dataTable.DefaultCell.Border = 0;
            dataTable.WidthPercentage = 90;
            dataTable.SetWidths(this.tableDefaultColumnWidths);

            this.AddTableHeading(ref dataTable);
            this.AddTableContent(ref dataTable);
            pdfDocument.Add(dataTable);
        }

        private void AddTableHeading(ref PdfPTable dataTable)
        {
            var organisationNameCell = this.CreateCell(this.defaultHeadingFont, DefaultColumnsNumber, 1, Title);
            dataTable.AddCell(organisationNameCell);

            var documentMainInfoCell = this.CreateCell(
                this.defaultHeadingFont,
                DefaultColumnsNumber,
                1,
                string.Format(
                Subtitle,
                this.Data.Date.ToLongDateString()));
            dataTable.AddCell(documentMainInfoCell);

            var foodCardsInfoCell = this.CreateCell(
                this.defaultHeadingFont,
                DefaultColumnsNumber,
                1,
                string.Format(FoodCardsTotal, this.Data.FoodCards));
            dataTable.AddCell(foodCardsInfoCell);

            var menuInfoCell = this.CreateCell(
                this.defaultHeadingFont,
                DefaultColumnsNumber,
                1,
                string.Format(
                    this.Menu,
                    this.Data.MenuMeals.ElementAt(0),
                    this.Data.MenuMeals.ElementAt(1),
                    this.Data.MenuMeals.ElementAt(2)));
            dataTable.AddCell(menuInfoCell);

            var cellsHeadings = this.CreateTableRow(this.defaultCellsHeadings, 1);
            dataTable.Rows.Add(cellsHeadings);
        }

        private PdfPCell CreateCell(Font font, int colspan, int alignment, string text)
        {
            var cell = new PdfPCell();
            cell.Colspan = colspan;
            var paragraph = new Paragraph(text, font);
            paragraph.Alignment = alignment;
            cell.AddElement(paragraph);
            return cell;
        }

        private void AddTableContent(ref PdfPTable dataTable)
        {
            foreach (var product in this.Data.ProductsData)
            {
                var rowData = new object[]
                {
                    product.Value.ProductId,
                    product.Key,
                    product.Value.MeasurementUnit,
                    product.Value.Quantity
                };

                var currentrow = this.CreateTableRow(rowData, 1);
                dataTable.Rows.Add(currentrow);
            }
        }

        private PdfPRow CreateTableRow(object[] rowData, int cellsAlignment)
        {
            var cells = new List<PdfPCell>();

            foreach (var cellData in rowData)
            {
                var cell = this.CreateCell(this.defaultCellFont, 1, cellsAlignment, cellData.ToString());
                cells.Add(cell);
            }

            var row = new PdfPRow(cells.ToArray());
            return row;
        }
    }
}
