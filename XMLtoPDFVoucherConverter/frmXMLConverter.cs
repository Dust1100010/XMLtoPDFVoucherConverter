using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLtoPDFVoucherConverter
{
    public partial class frmXMLConverter : Form
    {
        List<string> _xmlNames = new List<string>();
        List<string> _xmlPaths = new List<string>();

        public frmXMLConverter()
        {
            InitializeComponent();
        }
        private void frmXMLConverter_Load(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(Program.globalVariables.DirectoryPath);
            if (!directory.Exists) directory.Create();
            else
            {
                Company company = new Company();
                PictureBox pictureBox = new PictureBox();
                company.ShowLogo(pictureBox);

                if (!File.Exists($"{Program.globalVariables.DirectoryPath}/Company.json"))
                {                   
                    company.CreateCompanyJson();
                }              
            }
        }
        
        /***XML***/
        private void ibtnUploadXml_Click(object sender, EventArgs e)
        {
            XML xml = new XML();
            _xmlPaths = xml.AddXmlPathsToList(_xmlPaths);
            _xmlNames = xml.AddXmlNamesToList(_xmlPaths);
            lstXlms.DataSource = null;
            lstXlms.DataSource = _xmlNames;
        }

        private async void ibtnPDF_Click(object sender, EventArgs e)
        {
            Company company = new Company();
            Voucher voucher = new Voucher();
            voucher.Company = company.CompanyDetails();
            voucher.Customer = new Customer
            {
                Name = "Antonio Cruz",
                Id = "71494772",
                IdType = "Ruc",
                Address = "Calle Cesar Vallejo 411",
                Email = "antonioscrl@hotmail.com",
                Phone = "987654321"
            };

            voucher.Type = "Factura";
            voucher.Date = DateTime.Now;
            voucher.Id = "FE01-234";
            voucher.Tax = 42;
            voucher.Amount = 2445;

            voucher.Items = new List<VoucherItem>
            {
                new VoucherItem
                {
                    Code = "COD001",
                    Description = "iPhone 15 128GB 6GB Negro",
                    Quality = 1,
                    Unit = "UNIDAD",
                    UnitAmount = 1000,
                    TotalAmount = 1180
                },
                new VoucherItem
                {
                    Code = "COD002",
                    Description = "iPhone 14 128GB 6GB Negro",
                    Quality = 1,
                    Unit = "UNIDAD",
                    UnitAmount = 1000,
                    TotalAmount = 1180
                },
                new VoucherItem
                {
                    Code = "COD003",
                    Description = "iPhone 13 128GB 6GB Negro",
                    Quality = 1,
                    Unit = "UNIDAD",
                    UnitAmount = 1000,
                    TotalAmount = 1180
                }
            };

            PDF pdf = new PDF();

            string html = pdf.GenerateHtmlTemplate(voucher, Properties.Resources.VoucherTemplate1.ToString());

            await pdf.GeneratePDF("facturadeprueba.xml", html, Program.globalVariables.DirectoryPath,iText.Kernel.Geom.PageSize.A4);
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            frmCompany.ShowDialog();
        }

    }
}