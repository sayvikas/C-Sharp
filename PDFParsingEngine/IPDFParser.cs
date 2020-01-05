using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFParsingEngine
{
    public interface IPdfParserEngine
    {
        string PDFToText(string pdfPath);
    }
}
