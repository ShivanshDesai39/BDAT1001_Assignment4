using Http.Utilities;
using HttpApp.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StudentTrackerApp.Models.Data;
using System;
using System.Threading.Tasks;

namespace OpenXML
{
    class Program
    {
       static void Main(string[]args)
        async static Task Main(string[] args)
        {
            Console.WriteLine("Sending...");

            string result = await HTTP.Get(Constants.Urls.BaseUrlApi + Constants.Urls.GetStudentsUnsecure, "");

            Console.WriteLine("Received...");

            Console.WriteLine(result);
            //Post a new object to an Unsecure site
            Console.WriteLine("Post a new object to an Unsecure site");

            //Build a student object
            var anonymousStudent = new
            {
                StudentCode = "200464960",
                FirstName = "Shivansh",
                LastName = "Desai",
                DateOfBirth = "1994-03-10"
            };

            Console.WriteLine("Sending...");
            string apiPostResult = await HTTP.Post(Constants.Urls.BaseUrlApi + Constants.Urls.GetStudentsUnsecure, "", anonymousStudent);
            Console.WriteLine("Received...");
            Console.WriteLine(apiPostResult); 

           

            Console.WriteLine("Sending...");
            string apiPutResult = await HTTP.Put(Constants.Urls.BaseUrlApi + Constants.Urls.GetStudentsUnsecure +
                                    "/" + student.StudentId, "", student);
            Console.WriteLine("Received...");
            Console.WriteLine(apiPutResult);

            Console.WriteLine("Outputing Pretty Json...");
            string prettyJson = JsonConvert.SerializeObject(JToken.Parse(apiPutResult), Formatting.Indented);
            Console.WriteLine(prettyJson);

            Console.WriteLine("Converting ApiResult...");
            ApiResult<Student> apiResult = JsonConvert.DeserializeObject<ApiResult<Student>>(apiPutResult);
            Console.WriteLine("Outputing new Student...");
            Console.WriteLine(apiResult.Data);

        }
        public static void CreateSpreadsheetWorkbook(string filepath)
        {
            // Create a spreadsheet document by supplying the filepath.
            // By default, AutoSave = true, Editable = true, and Type = xlsx.
            SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
                Create(filepath, SpreadsheetDocumentType.Workbook);

            // Add a WorkbookPart to the document.
            WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
            workbookpart.Workbook = new Workbook();

            // Add a WorksheetPart to the WorkbookPart.
            WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
            worksheetPart.Worksheet = new Worksheet(new SheetData());

            // Add Sheets to the Workbook.
            Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
                AppendChild<Sheets>(new Sheets());

            // Append a new worksheet and associate it with the workbook.
            Sheet sheet = new Sheet()
            {
                Id = spreadsheetDocument.WorkbookPart.
                GetIdOfPart(worksheetPart),
                SheetId = 1,
                Name = "mySheet"
            };
            sheets.Append(sheet);

            workbookpart.Workbook.Save();

            // Close the document.
            spreadsheetDocument.Close();
        }
        public static void CreateWordprocessingDocument(string filepath)
        {
            // Create a document by supplying the filepath. 
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(E:\BDAT, WordprocessingDocumentType.Document))
            {
                // Add a main document part. 
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

                // Create the document structure and add some text.
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());
                Paragraph para = body.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text("Create text in body - CreateWordprocessingDocument"));
            }
        }
        public static void CreatePresentation(string filepath)
        {
            // Create a presentation at a specified file path. The presentation document type is pptx, by default.
            PresentationDocument presentationDoc = PresentationDocument.Create(filepath, PresentationDocumentType.Presentation);
            PresentationPart presentationPart = presentationDoc.AddPresentationPart();
            presentationPart.Presentation = new Presentation();

            CreatePresentationParts(presentationPart);

            // Close the presentation handle
            presentationDoc.Close();
        }
    }