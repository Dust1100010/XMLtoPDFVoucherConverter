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
            this.ibtnPrint = new FontAwesome.Sharp.IconButton();
            this.ibtnPDF = new FontAwesome.Sharp.IconButton();
            this.lstXlms = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ibtnUploadXml = new FontAwesome.Sharp.IconButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mnuHeader = new System.Windows.Forms.MenuStrip();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibtnPrint
            // 
            this.ibtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.ibtnPrint.IconColor = System.Drawing.Color.Black;
            this.ibtnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPrint.Location = new System.Drawing.Point(474, 334);
            this.ibtnPrint.Name = "ibtnPrint";
            this.ibtnPrint.Size = new System.Drawing.Size(71, 60);
            this.ibtnPrint.TabIndex = 5;
            this.toolTip1.SetToolTip(this.ibtnPrint, "Imprimir");
            this.ibtnPrint.UseVisualStyleBackColor = true;
            // 
            // ibtnPDF
            // 
            this.ibtnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPDF.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.ibtnPDF.IconColor = System.Drawing.Color.Black;
            this.ibtnPDF.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPDF.Location = new System.Drawing.Point(397, 334);
            this.ibtnPDF.Name = "ibtnPDF";
            this.ibtnPDF.Size = new System.Drawing.Size(71, 60);
            this.ibtnPDF.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnPDF, "Generar PDF");
            this.ibtnPDF.UseVisualStyleBackColor = true;
            this.ibtnPDF.Click += new System.EventHandler(this.ibtnPDF_Click);
            // 
            // lstXlms
            // 
            this.lstXlms.FormattingEnabled = true;
            this.lstXlms.ItemHeight = 15;
            this.lstXlms.Location = new System.Drawing.Point(12, 65);
            this.lstXlms.Name = "lstXlms";
            this.lstXlms.Size = new System.Drawing.Size(376, 409);
            this.lstXlms.TabIndex = 13;
            // 
            // ibtnUploadXml
            // 
            this.ibtnUploadXml.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnUploadXml.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnUploadXml.IconColor = System.Drawing.Color.Black;
            this.ibtnUploadXml.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnUploadXml.Location = new System.Drawing.Point(12, 36);
            this.ibtnUploadXml.Name = "ibtnUploadXml";
            this.ibtnUploadXml.Size = new System.Drawing.Size(376, 23);
            this.ibtnUploadXml.TabIndex = 15;
            this.ibtnUploadXml.Text = "Selecciona los XML";
            this.ibtnUploadXml.UseVisualStyleBackColor = true;
            this.ibtnUploadXml.Click += new System.EventHandler(this.ibtnUploadXml_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(397, 451);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 23);
            this.progressBar1.TabIndex = 17;
            // 
            // mnuHeader
            // 
            this.mnuHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mnuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresaToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuHeader.Location = new System.Drawing.Point(0, 0);
            this.mnuHeader.Name = "mnuHeader";
            this.mnuHeader.Size = new System.Drawing.Size(751, 24);
            this.mnuHeader.TabIndex = 19;
            this.mnuHeader.Text = "menuStrip1";
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.formatoToolStripMenuItem.Text = "Plantilla";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // frmXMLConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(751, 487);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ibtnUploadXml);
            this.Controls.Add(this.lstXlms);
            this.Controls.Add(this.ibtnPDF);
            this.Controls.Add(this.ibtnPrint);
            this.Controls.Add(this.mnuHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mnuHeader;
            this.Name = "frmXMLConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XML To PDF Converter";
            this.Load += new System.EventHandler(this.frmXMLConverter_Load);
            this.mnuHeader.ResumeLayout(false);
            this.mnuHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnPrint;
        private FontAwesome.Sharp.IconButton ibtnPDF;
        private ListBox lstXlms;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton ibtnUploadXml;
        private ProgressBar progressBar1;
        private MenuStrip mnuHeader;
        private ToolStripMenuItem empresaToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
    }
}