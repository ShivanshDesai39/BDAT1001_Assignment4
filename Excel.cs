using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace OpenXML
{
    class Excel
    {
        SpreadsheetDocument spreadsheetDocument =
        SpreadsheetDocument.Create(filepath, SpreadsheetDocumentType.Workbook);
        Sheet sheet = new Sheet()
        {
            Id = spreadsheetDocument.WorkbookPart.
            GetIdOfPart(worksheetPart),
            SheetId = 1,
            Name = "mySheet"
        };
        sheets.Append(sheet);
        CreateSpreadsheetWorkbook(@"E:\BDAT\Information Encoding Standards")
    }
}
