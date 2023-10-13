namespace XMLtoPDFVoucherConverter
{
    partial class frmCompany
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
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.ibtnSave = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ibtnPrimaryColor = new FontAwesome.Sharp.IconButton();
            this.ibtnSecondaryColor = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 40);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 39);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "CompanyDetails";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nombre:";
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Location = new System.Drawing.Point(36, 14);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(30, 15);
            this.lblRuc.TabIndex = 3;
            this.lblRuc.Text = "Ruc:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 11);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 23);
            this.txtID.TabIndex = 0;
            this.txtID.Tag = "CompanyDetails";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(19, 88);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(47, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Celular:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(72, 85);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(249, 23);
            this.txtPhone.TabIndex = 2;
            this.txtPhone.Tag = "CompanyDetails";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 117);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 15);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(72, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(249, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "CompanyDetails";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 146);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 15);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Dirección:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(72, 143);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(249, 53);
            this.txtAddress.TabIndex = 4;
            this.txtAddress.Tag = "CompanyDetails";
            // 
            // picLogo
            // 
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Location = new System.Drawing.Point(333, 11);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(115, 115);
            this.picLogo.TabIndex = 17;
            this.picLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.picLogo, "Doble click para actualizar el logo");
            this.picLogo.DoubleClick += new System.EventHandler(this.picLogo_DoubleClick);
            // 
            // ibtnSave
            // 
            this.ibtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnSave.IconColor = System.Drawing.Color.Black;
            this.ibtnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSave.Location = new System.Drawing.Point(333, 173);
            this.ibtnSave.Name = "ibtnSave";
            this.ibtnSave.Size = new System.Drawing.Size(115, 22);
            this.ibtnSave.TabIndex = 5;
            this.ibtnSave.Text = "Guardar";
            this.toolTip1.SetToolTip(this.ibtnSave, "Guardar cambios");
            this.ibtnSave.UseVisualStyleBackColor = true;
            this.ibtnSave.Click += new System.EventHandler(this.ibtnSave_Click);
            // 
            // ibtnPrimaryColor
            // 
            this.ibtnPrimaryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnPrimaryColor.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.ibtnPrimaryColor.IconColor = System.Drawing.Color.DarkCyan;
            this.ibtnPrimaryColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnPrimaryColor.IconSize = 38;
            this.ibtnPrimaryColor.Location = new System.Drawing.Point(353, 132);
            this.ibtnPrimaryColor.Name = "ibtnPrimaryColor";
            this.ibtnPrimaryColor.Size = new System.Drawing.Size(35, 35);
            this.ibtnPrimaryColor.TabIndex = 18;
            this.toolTip1.SetToolTip(this.ibtnPrimaryColor, "Color Primario");
            this.ibtnPrimaryColor.UseVisualStyleBackColor = true;
            this.ibtnPrimaryColor.Click += new System.EventHandler(this.ibtnPrimaryColor_Click);
            // 
            // ibtnSecondaryColor
            // 
            this.ibtnSecondaryColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ibtnSecondaryColor.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.ibtnSecondaryColor.IconColor = System.Drawing.Color.DarkGray;
            this.ibtnSecondaryColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSecondaryColor.IconSize = 38;
            this.ibtnSecondaryColor.Location = new System.Drawing.Point(394, 132);
            this.ibtnSecondaryColor.Name = "ibtnSecondaryColor";
            this.ibtnSecondaryColor.Size = new System.Drawing.Size(35, 35);
            this.ibtnSecondaryColor.TabIndex = 19;
            this.toolTip1.SetToolTip(this.ibtnSecondaryColor, "Color Secundario");
            this.ibtnSecondaryColor.UseVisualStyleBackColor = true;
            this.ibtnSecondaryColor.Click += new System.EventHandler(this.ibtnSecondaryColor_Click);
            // 
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 205);
            this.Controls.Add(this.ibtnSecondaryColor);
            this.Controls.Add(this.ibtnPrimaryColor);
            this.Controls.Add(this.ibtnSave);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblRuc);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.fmrCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label lblRuc;
        private TextBox txtID;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddress;
        private TextBox txtAddress;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton ibtnSave;
        private ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton ibtnPrimaryColor;
        private FontAwesome.Sharp.IconButton ibtnSecondaryColor;
    }
}