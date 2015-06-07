namespace PdfExporter
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using iTextSharp.text;
    using iTextSharp.text.pdf;

    public class PdfRequestExporter
    {
        // File Parameters
        private readonly string[] defaultCellsHeadings =
            new[] { "Код", "Продукт", "Мярка", "Общо количество", "Наличности" };
        private readonly string[] defaultAvailabilitiesSubHeadings =
            new[] { "Партида", "Ед. цена", "Количество" };

        // Text
        private readonly string Title = "Детска кухня";
        private readonly string Subtitle = "Предварителна калкулация" + Environment.NewLine + "за дата {0}";
        private readonly string FoodCardsTotal = "Брой закупени купони: {0}";
        private readonly string Menu = "Меню" + Environment.NewLine +
            "1. {0}" + Environment.NewLine + "2. {1}" + Environment.NewLine + "3. {2}";

        // Table settings
        private readonly int DefaultColumnsNumber = 5;
        private readonly string DefaultDateFormat = "dd-MMM-yyyy";
        private readonly float[] tableDefaultColumnWidths = new[] { 1f, 2f, 1f, 2f, 4f };

        // Fonts
        private static string untfFontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
        private static BaseFont utfFont = BaseFont.CreateFont(untfFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        private readonly Font defaultHeadingFont = new Font(utfFont, 11);
        private readonly Font defaultCellFont = new Font(utfFont, 10);

        private RequestExportData data;

        public PdfRequestExporter(RequestExportData data)
        {
            this.Data = data;
        }

        public RequestExportData Data
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
            catch (Exception ex)
            {
                var exp = ex.Message;
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

            var cellsHeadings = this.CreateTableHeadings();
            dataTable.Rows.Add(cellsHeadings);
        }

        private PdfPRow CreateTableHeadings()
        {
            var headingRowCells = new List<PdfPCell>();
            for (int heading = 0; heading < this.defaultCellsHeadings.Length - 1; heading++)
            {
                var headingRowCell =
                    this.CreateCell(this.defaultCellFont, 1, 1, this.defaultCellsHeadings[heading]);
                headingRowCells.Add(headingRowCell);
            }

            // Create availability heading cell as a table with two rows
            var availabilityHeadingCellAsTable = new PdfPTable(new[] { 1f, 1f, 1f });
            var firstRow = this.CreateCell(this.defaultCellFont, 3, 1, this.defaultCellsHeadings.Last());
            availabilityHeadingCellAsTable.AddCell(firstRow);
            var availabilityCellSubCells = new List<PdfPCell>();
            foreach (var subHeading in this.defaultAvailabilitiesSubHeadings)
            {
                var subSell = this.CreateCell(this.defaultCellFont, 1, 1, subHeading);
                availabilityCellSubCells.Add(subSell);
            }

            var secondRow = this.CreateTableRow(availabilityCellSubCells.ToArray());
            availabilityHeadingCellAsTable.Rows.Add(secondRow);

            var availabilityHeadingCell = new PdfPCell(availabilityHeadingCellAsTable);
            headingRowCells.Add(availabilityHeadingCell);

            return this.CreateTableRow(headingRowCells.ToArray());
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
            foreach (var product in this.Data.ProductsData.Products)
            {
                var rowCells = new List<PdfPCell>();
                rowCells.Add(this.CreateCell(this.defaultCellFont, 1, 1, product.ProductId.ToString()));
                rowCells.Add(this.CreateCell(this.defaultCellFont, 1, 1, product.ProductName));
                rowCells.Add(this.CreateCell(this.defaultCellFont, 1, 1, product.MesurementUnit));
                rowCells.Add(this.CreateCell(this.defaultCellFont, 1, 1, product.Quantity.ToString()));

                // Create availabilities requested for a product
                var availabilitiesCellAsTable = new PdfPTable(new[] { 1f, 1f, 1f });
                foreach (var availability in this.Data.ProductsData.Availabilities[product.ProductId])
                {
                    var cells = new List<PdfPCell>();
                    cells.Add(this.CreateCell(this.defaultCellFont, 1, 1, availability.Batch));
                    cells.Add(this.CreateCell(this.defaultCellFont, 1, 1, availability.UnitPrice.ToString()));
                    cells.Add(this.CreateCell(this.defaultCellFont, 1, 1, availability.Quantity.ToString()));
                    var row = this.CreateTableRow(cells.ToArray());
                    availabilitiesCellAsTable.Rows.Add(row);
                }

                var availabilitiesCell = new PdfPCell(availabilitiesCellAsTable);
                rowCells.Add(availabilitiesCell);
                var currentrow = this.CreateTableRow(rowCells.ToArray());
                dataTable.Rows.Add(currentrow);
            }
        }

        private PdfPRow CreateTableRow(PdfPCell[] cells)
        {
            var row = new PdfPRow(cells);
            return row;
        }
    }
}
