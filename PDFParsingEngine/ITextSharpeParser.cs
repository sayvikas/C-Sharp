using System;
using System.Text;
using iTextSharp.text.exceptions;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFParsingEngine
{
    public class ITextSharpeParser : IPdfParserEngine
    {
        public string PDFToText(string pdfPath)
        {
            string finalString = string.Empty;
            ITextExtractionStrategy strategy = new LocationTextExtractionStrategy();
            try
            {
                using (PdfReader reader = new PdfReader(pdfPath))
                {
                    StringBuilder text = new StringBuilder();

                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i, strategy));
                    }

                    finalString = text.ToString();
                }
            }
            catch (BadPasswordException ex)
            {
                finalString = "The pdf is password protected and this functionality is not implemented yet";
            }
            catch (BadPdfFormatException ex)
            {
                finalString = "Supplied pdf is not well formatted, parser engine could not parse it";
            }
            catch (Exception ex)
            {
                finalString = "Something terribly went wrong, please contact support/developer to understand more";
            }

            return finalString;
        }
    }
}
