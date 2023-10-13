using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace XMLtoPDFVoucherConverter
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        private void fmrCompany_Load(object sender, EventArgs e)
        {
            Company company = new Company();
            company = company.CompanyDetails();
            txtName.Text = company.Name;
            txtID.Text = company.Id;
            txtPhone.Text = company.Phone;
            txtEmail.Text = company.Email;
            txtAddress.Text = company.Address;
            ibtnPrimaryColor.IconColor = Color.FromArgb(company.PrimaryColor.Red, company.PrimaryColor.Green, company.PrimaryColor.Blue);
            ibtnSecondaryColor.IconColor = Color.FromArgb(company.SecondaryColor.Red, company.SecondaryColor.Green, company.SecondaryColor.Blue);

            company.ShowLogo(picLogo);
        }

        private void picLogo_DoubleClick(object sender, EventArgs e)
        {
            Company company = new Company();
            company.UpdateLogo((PictureBox)sender);
        }

        private void ibtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls) 
                {
                    if (control is TextBox textBox && textBox.Tag != null && textBox.Tag.ToString() == "CompanyDetails")
                    {
                        if(string.IsNullOrEmpty(textBox.Text))
                        {
                            textBox.Focus();
                            throw new Exception("Ingresa datos");
                        }                            
                    }
                }

                Company company = new Company();
                company.Name = txtName.Text.Trim();
                company.Id = txtID.Text.Trim();
                company.Phone = txtPhone.Text.Trim();
                company.Email = txtEmail.Text.Trim();
                company.Address = txtAddress.Text.Trim();
                if (!company.UpdateCompanyJson(company))
                    throw new Exception("No se pudo guardar los datos");
                MessageBox.Show("Datos guardados",this.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,this.Text, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void ibtnPrimaryColor_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            PDF color = company.SelectedColor();
            if (color != null)
            {
                ibtnPrimaryColor.IconColor = Color.FromArgb(color.Red, color.Green, color.Blue);
                Company comColor = new Company
                {
                    PrimaryColor = new PDF
                    {
                        Red = color.Red,
                        Green = color.Green,
                        Blue = color.Blue
                    }
                };
                
                if (company.UpdateCompanyJson(comColor)) MessageBox.Show("Color guardado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("No se pudo guardar el color", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private void ibtnSecondaryColor_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            PDF color = company.SelectedColor();
            if (color != null)
            {
                ibtnSecondaryColor.IconColor = Color.FromArgb(color.Red, color.Green, color.Blue);
                Company comColor = new Company
                {
                    SecondaryColor = new PDF
                    {
                        Red = color.Red,
                        Green = color.Green,
                        Blue = color.Blue
                    }
                };

                if (company.UpdateCompanyJson(comColor)) MessageBox.Show("Color guardado", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("No se pudo guardar el color", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
