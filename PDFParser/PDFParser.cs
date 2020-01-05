using System;
using System.IO;
using System.Windows.Forms;
using PDFParsingEngine;

namespace PDFParser
{
    public partial class IPdfParser : Form
    {
        enum SupportedPDFVendor
        {
            ITextSharpe,
            Adobe,
            IronPDF
        }
        public IPdfParser()
        {
            InitializeComponent();
            cmbPDFReaderVendor.DataSource = Enum.GetValues(typeof(SupportedPDFVendor));
        }

        private void Browse_Click(object sender, EventArgs e)
        {

            var fd = new OpenFileDialog();
            fd.Filter = "pdf files (*.pdf)|*.PDF";
            fd.ShowDialog();
            textBoxPath.Text = fd.FileName;
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPath.Text))
            {
                MessageBox.Show("Please provide a pdf path for parsing", "PDF Parsing error");
                return;
            }
            SupportedPDFVendor selectedItem = (SupportedPDFVendor) cmbPDFReaderVendor.SelectedItem;

            IPdfParserEngine pdfParser = null;

            switch (selectedItem)
            {
                case SupportedPDFVendor.ITextSharpe:
                    pdfParser = new ITextSharpeParser();
                    break;
                case SupportedPDFVendor.Adobe:
                    pdfParser = new AdobeParser();
                    break;
                case SupportedPDFVendor.IronPDF:
                    pdfParser = new AdobeParser();
                    break;
            }

            if (pdfParser != null)
            {
                try
                {
                    if (File.Exists(textBoxPath.Text))
                    {
                        textBoxParsedText.Text = pdfParser.PDFToText(textBoxPath.Text);
                    }
                    else
                    {
                        textBoxParsedText.Text = "File path has been modified, please provide a valid one";
                    }
                }
                catch (NotImplementedException ex)
                {
                    textBoxParsedText.Text = "Sorry, This application do not support selected technology for parsing";
                    // some logger;

                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxParsedText.Text = "";
        }
    }
}
