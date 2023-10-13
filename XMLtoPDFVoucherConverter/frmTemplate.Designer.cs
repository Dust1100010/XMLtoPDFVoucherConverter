namespace XMLtoPDFVoucherConverter
{
    partial class frmTemplate
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
            this.lblSecondaryColor = new System.Windows.Forms.Label();
            this.ibtnNextTemplate = new FontAwesome.Sharp.IconButton();
            this.lblMainColor = new System.Windows.Forms.Label();
            this.ibtnPreviewTemplate = new FontAwesome.Sharp.IconButton();
            this.picTemplates = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSecondaryColor
            // 
            this.lblSecondaryColor.AutoSize = true;
            this.lblSecondaryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSecondaryColor.Location = new System.Drawing.Point(285, 119);
            this.lblSecondaryColor.Name = "lblSecondaryColor";
            this.lblSecondaryColor.Size = new System.Drawing.Size(98, 15);
            this.lblSecondaryColor.TabIndex = 15;
            this.lblSecondaryColor.Text = "Color Secundario";
            // 
            // ibtnNextTemplate
            // 
            this.ibtnNextTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnNextTemplate.IconChar = FontAwesome.Sharp.IconChar.CaretRight;
            this.ibtnNextTemplate.IconColor = System.Drawing.Color.Black;
            this.ibtnNextTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNextTemplate.IconSize = 30;
            this.ibtnNextTemplate.Location = new System.Drawing.Point(323, 187);
            this.ibtnNextTemplate.Name = "ibtnNextTemplate";
            this.ibtnNextTemplate.Size = new System.Drawing.Size(29, 31);
            this.ibtnNextTemplate.TabIndex = 14;
            this.ibtnNextTemplate.UseVisualStyleBackColor = true;
            // 
            // lblMainColor
            // 
            this.lblMainColor.AutoSize = true;
            this.lblMainColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMainColor.Location = new System.Drawing.Point(284, 68);
            this.lblMainColor.Name = "lblMainColor";
            this.lblMainColor.Size = new System.Drawing.Size(85, 15);
            this.lblMainColor.TabIndex = 13;
            this.lblMainColor.Text = "Color Principal";
            // 
            // ibtnPreviewTemplate
            // 
            this.ibtnPreviewTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPreviewTemplate.IconChar = FontAwesome.Sharp.IconChar.CaretLeft;
            this.ibtnPreviewTemplate.IconColor = System.Drawing.Color.Black;
            this.ibtnPreviewTemplate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPreviewTemplate.IconSize = 30;
            this.ibtnPreviewTemplate.Location = new System.Drawing.Point(288, 187);
            this.ibtnPreviewTemplate.Name = "ibtnPreviewTemplate";
            this.ibtnPreviewTemplate.Size = new System.Drawing.Size(29, 31);
            this.ibtnPreviewTemplate.TabIndex = 12;
            this.ibtnPreviewTemplate.UseVisualStyleBackColor = true;
            // 
            // picTemplates
            // 
            this.picTemplates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTemplates.Location = new System.Drawing.Point(68, 53);
            this.picTemplates.Name = "picTemplates";
            this.picTemplates.Size = new System.Drawing.Size(210, 297);
            this.picTemplates.TabIndex = 11;
            this.picTemplates.TabStop = false;
            // 
            // frmTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecondaryColor);
            this.Controls.Add(this.ibtnNextTemplate);
            this.Controls.Add(this.lblMainColor);
            this.Controls.Add(this.ibtnPreviewTemplate);
            this.Controls.Add(this.picTemplates);
            this.Name = "frmTemplate";
            this.Text = "frmTemplate";
            ((System.ComponentModel.ISupportInitialize)(this.picTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSecondaryColor;
        private FontAwesome.Sharp.IconButton ibtnNextTemplate;
        private Label lblMainColor;
        private FontAwesome.Sharp.IconButton ibtnPreviewTemplate;
        private PictureBox picTemplates;
    }
}