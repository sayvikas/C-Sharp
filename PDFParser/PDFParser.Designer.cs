namespace PDFParser
{
    partial class IPdfParser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxParsedText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExtract = new System.Windows.Forms.Button();
            this.cmbPDFReaderVendor = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF Path:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(189, 38);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(444, 22);
            this.textBoxPath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Browse_Click);
            // 
            // textBoxParsedText
            // 
            this.textBoxParsedText.Location = new System.Drawing.Point(189, 172);
            this.textBoxParsedText.Multiline = true;
            this.textBoxParsedText.Name = "textBoxParsedText";
            this.textBoxParsedText.Size = new System.Drawing.Size(444, 230);
            this.textBoxParsedText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Extracted Text:";
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(190, 121);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(178, 32);
            this.btnExtract.TabIndex = 5;
            this.btnExtract.Text = "Extract PDF to Text";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // cmbPDFReaderVendor
            // 
            this.cmbPDFReaderVendor.FormattingEnabled = true;
            this.cmbPDFReaderVendor.Location = new System.Drawing.Point(189, 77);
            this.cmbPDFReaderVendor.Name = "cmbPDFReaderVendor";
            this.cmbPDFReaderVendor.Size = new System.Drawing.Size(121, 24);
            this.cmbPDFReaderVendor.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Supported Vendor";
            // 
            // IPdfParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 439);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbPDFReaderVendor);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxParsedText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.Name = "IPdfParser";
            this.Text = "PDF Viewer and Text Extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxParsedText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.ComboBox cmbPDFReaderVendor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
    }
}

