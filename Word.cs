using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace OpenXML
{
    class Word
    {

        using (WordprocessingDocument wordDocument =
        WordprocessingDocument.Create(filepath, WordprocessingDocumentType.Document))
    {
        // Insert other code here. 
        mainPart.Document = new Document(
       new Body(
          new Paragraph(
             new Run(
                new Text("Create text in body - CreateWordprocessingDocument")))));
        CreateWordprocessingDocument(@"E:\BDAT\Information Encoding Standards");
}
    }
}
