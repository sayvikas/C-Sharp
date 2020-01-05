using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PDFParsingEngine.Test
{
    [TestClass]
    public class ITextSharpeTest
    {
        private IPdfParserEngine pdfParser;
        string pdfPath = String.Empty;
        [TestInitialize]
        public void InIt()
        {
            pdfParser = new ITextSharpeParser();
            pdfPath = Directory.GetCurrentDirectory() + "\\..\\..\\" + "Microsoft_Certified_Professional_Certificate_0.pdf";
        }

        [TestMethod]
        public void IsPdfFileExists()
        {

            Assert.IsTrue(File.Exists(pdfPath));
        }

        [TestMethod]
        public void ReadTextFromPDF()
        {
            string textFromPDF = pdfParser.PDFToText(pdfPath);
            Assert.IsNotNull(textFromPDF);
        }

        [TestMethod]
        public void ReadTextFromPasswordProtectedPDF()
        {
            string path = Directory.GetCurrentDirectory() + "\\..\\..\\" + "LBXXXXXXXXXXXX86.pdf";
            string textFromPDF = pdfParser.PDFToText(path);
            Assert.AreEqual("The pdf is password protected and this functionality is not implemented yet", textFromPDF);
        }
    }
}
