namespace XMLtoPDFVoucherConverter
{
    partial class frmXMLConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picTemplates = new System.Windows.Forms.PictureBox();
            this.ibtnPreviewTemplate = new FontAwesome.Sharp.IconButton();
            this.ibtnPrint = new FontAwesome.Sharp.IconButton();
            this.lblMainColor = new System.Windows.Forms.Label();
            this.ibtnNextTemplate = new FontAwesome.Sharp.IconButton();
            this.ibtnPDF = new FontAwesome.Sharp.IconButton();
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.lstXlms = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ibtnUploadXml = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTemplates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picTemplates
            // 
            this.picTemplates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTemplates.Location = new System.Drawing.Point(394, 116);
            this.picTemplates.Name = "picTemplates";
            this.picTemplates.Size = new System.Drawing.Size(210, 297);
            this.picTemplates.TabIndex = 2;
            this.picTemplates.TabStop = false;
            // 
            // ibtnPreviewTemplate
            // 
            this.ibtnPreviewTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPreviewTemplate.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.ibtnPreviewTemplate.IconColor = System.Drawing.Color.Black;
            this.ibtnPreviewTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPreviewTemplate.IconSize = 30;
            this.ibtnPreviewTemplate.Location = new System.Drawing.Point(459, 419);
            this.ibtnPreviewTemplate.Name = "ibtnPreviewTemplate";
            this.ibtnPreviewTemplate.Size = new System.Drawing.Size(29, 31);
            this.ibtnPreviewTemplate.TabIndex = 3;
            this.toolTip1.SetToolTip(this.ibtnPreviewTemplate, "Plantilla anterior");
            this.ibtnPreviewTemplate.UseVisualStyleBackColor = true;
            // 
            // ibtnPrint
            // 
            this.ibtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnPrint.IconColor = System.Drawing.Color.Black;
            this.ibtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPrint.Location = new System.Drawing.Point(610, 353);
            this.ibtnPrint.Name = "ibtnPrint";
            this.ibtnPrint.Size = new System.Drawing.Size(71, 60);
            this.ibtnPrint.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ibtnPrint, "Imprimir");
            this.ibtnPrint.UseVisualStyleBackColor = true;
            // 
            // lblMainColor
            // 
            this.lblMainColor.AutoSize = true;
            this.lblMainColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainColor.Location = new System.Drawing.Point(394, 95);
            this.lblMainColor.Name = "lblMainColor";
            this.lblMainColor.Size = new System.Drawing.Size(85, 15);
            this.lblMainColor.TabIndex = 7;
            this.lblMainColor.Text = "Color Principal";
            this.toolTip1.SetToolTip(this.lblMainColor, "Doble Click para elegir el color");
            this.lblMainColor.DoubleClick += new System.EventHandler(this.lblMainColor_DoubleClick);
            // 
            // ibtnNextTemplate
            // 
            this.ibtnNextTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnNextTemplate.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.ibtnNextTemplate.IconColor = System.Drawing.Color.Black;
            this.ibtnNextTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNextTemplate.IconSize = 30;
            this.ibtnNextTemplate.Location = new System.Drawing.Point(494, 419);
            this.ibtnNextTemplate.Name = "ibtnNextTemplate";
            this.ibtnNextTemplate.Size = new System.Drawing.Size(29, 31);
            this.ibtnNextTemplate.TabIndex = 8;
            this.toolTip1.SetToolTip(this.ibtnNextTemplate, "Siguiente Plantilla");
            this.ibtnNextTemplate.UseVisualStyleBackColor = true;
            // 
            // ibtnPDF
            // 
            this.ibtnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDF.IconColor = System.Drawing.Color.Black;
            this.ibtnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDF.Location = new System.Drawing.Point(610, 287);
            this.ibtnPDF.Name = "ibtnPDF";
            this.ibtnPDF.Size = new System.Drawing.Size(71, 60);
            this.ibtnPDF.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnPDF, "Generar PDF");
            this.ibtnPDF.UseVisualStyleBackColor = true;
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSecondaryColor.Location = new System.Drawing.Point(506, 95);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(98, 15);
            this.lblSecondaryColor.TabIndex = 10;
            this.lblSecondaryColor.Text = "Color Secundario";
            this.toolTip1.SetToolTip(this.lblSecondaryColor, "Doble Click para elegir el color");
            this.lblSecondaryColor.DoubleClick += new System.EventHandler(this.lblSecondaryColor_DoubleClick);
            // 
            // lstXlms
            // 
            this.lstXlms.FormattingEnabled = true;
            this.lstXlms.ItemHeight = 15;
            this.lstXlms.Location = new System.Drawing.Point(12, 41);
            this.lstXlms.Name = "lstXlms";
            this.lstXlms.Size = new System.Drawing.Size(362, 409);
            this.lstXlms.TabIndex = 13;
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(459, 8);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(80, 80);
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.picLogo, "Elige el logo de tu empresa");
            this.picLogo.DoubleClick += new System.EventHandler(this.picLogo_DoubleClick);
            // 
            // ibtnUploadXml
            // 
            this.ibtnUploadXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUploadXml.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnUploadXml.IconColor = System.Drawing.Color.Black;
            this.ibtnUploadXml.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUploadXml.Location = new System.Drawing.Point(12, 12);
            this.ibtnUploadXml.Name = "ibtnUploadXml";
            this.ibtnUploadXml.Size = new System.Drawing.Size(362, 23);
            this.ibtnUploadXml.TabIndex = 15;
            this.ibtnUploadXml.Text = "Selecciona los XML";
            this.ibtnUploadXml.UseVisualStyleBackColor = true;
            this.ibtnUploadXml.Click += new System.EventHandler(this.ibtnUploadXml_Click);
            // 
            // frmXMLConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 462);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.ibtnUploadXml);
            this.Controls.Add(this.lstXlms);
            this.Controls.Add(this.lblSecondaryColor);
            this.Controls.Add(this.ibtnPDF);
            this.Controls.Add(this.ibtnNextTemplate);
            this.Controls.Add(this.lblMainColor);
            this.Controls.Add(this.ibtnPrint);
            this.Controls.Add(this.ibtnPreviewTemplate);
            this.Controls.Add(this.picTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmXMLConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XML To PDF Converter";
            this.Load += new System.EventHandler(this.frmXMLConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTemplates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox picTemplates;
        private FontAwesome.Sharp.IconButton ibtnPreviewTemplate;
        private FontAwesome.Sharp.IconButton ibtnPrint;
        private Label lblMainColor;
        private FontAwesome.Sharp.IconButton ibtnNextTemplate;
        private FontAwesome.Sharp.IconButton ibtnPDF;
        private Label lblSecondaryColor;
        private ListBox lstXlms;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton ibtnUploadXml;
        private PictureBox picLogo;
    }
}