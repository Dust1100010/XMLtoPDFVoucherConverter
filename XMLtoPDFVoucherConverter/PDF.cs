using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Html2pdf;
using iText.Kernel.Pdf;
using iText.Layout;
using System.Text.RegularExpressions;
using iText.Kernel.Events;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using System.Globalization;

namespace XMLtoPDFVoucherConverter
{
    public class PDF
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    
        public string AmountToText(string monto)
        {
            decimal num;
            if (decimal.TryParse(monto, out num)) monto = num.ToString("0.00", CultureInfo.InvariantCulture);

            NumToLetters.Letters letras = new NumToLetters.Letters();
            string montoTexto = letras.Convertir_A_Letras(monto, true);
            montoTexto = montoTexto.Replace("M.N.", "SOLES");

            return montoTexto;
        }

        public string CorrectDecimals(string monto)
        {
            string montoCorregido = monto;
            decimal num;
            if (decimal.TryParse(monto, out num)) montoCorregido = num.ToString("0.00", CultureInfo.InvariantCulture);

            return montoCorregido;
        }

        private string validatePDFVoucherName(string path)
        {
            string originalPath = path;
            string name = Path.GetFileNameWithoutExtension(path) + Path.GetExtension(path);

            int version = 1;
            while (File.Exists(path))
            {
                name = Path.GetFileNameWithoutExtension(originalPath) + " (" + version.ToString() + ")" + Path.GetExtension(originalPath);
                path = Path.Combine(Path.GetDirectoryName(originalPath), name);
                version++;
            }
            return name;
        }

        public async Task GeneratePDF(string xmlName, string htmlVoucher,string path, iText.Kernel.Geom.PageSize tipoHoja)
        {
            string pathFile = $"{path}/{Path.GetFileNameWithoutExtension(xmlName)}.pdf";
            string fileName = $"{path}/{validatePDFVoucherName(pathFile)}";
            using (FileStream temp = new FileStream(fileName, FileMode.Create))
            {
                PdfWriter writer = new PdfWriter(temp);
                PdfDocument pdf = new PdfDocument(writer);
                Document doc = new Document(pdf, tipoHoja);
                ConverterProperties converterProperties = new ConverterProperties();
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(htmlVoucher)))
                {
                    await Task.Run(() => HtmlConverter.ConvertToPdf(stream, pdf, converterProperties));
                }
                doc.Close();
            }
            MessageBox.Show("PDF generado", "PDFVoucherConverter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string GenerateHtmlTemplate(Voucher voucher, string template)
        {
            template = template.Replace("@COLOR1", $"rgb({voucher.Company.PrimaryColor.Red},{voucher.Company.PrimaryColor.Green},{voucher.Company.PrimaryColor.Blue})");
            template = template.Replace("@COLOR2", $"rgb({voucher.Company.SecondaryColor.Red},{voucher.Company.SecondaryColor.Green},{voucher.Company.SecondaryColor.Blue})");
            template = template.Replace("@LOGO", Program.globalVariables.LogoPath);            
            template = template.Replace("@COMPANY_ID", voucher.Company.Id);
            template = template.Replace("@COMPANY_PHONE", voucher.Company.Phone);
            template = template.Replace("@COMPANY_ADDRESS", voucher.Company.Address);
            template = template.Replace("@COMPANY", voucher.Company.Name);   
            
            template = template.Replace("@CUSTOMER_ID", voucher.Customer.Id);
            template = template.Replace("@CUSTOMER_TYPE", voucher.Customer.IdType);
            template = template.Replace("@CUSTOMER_PHONE", voucher.Customer.Phone);
            template = template.Replace("@CUSTOMER_ADDRESS", voucher.Customer.Address);
            template = template.Replace("@CUSTOMER", voucher.Customer.Name);        
            
            template = template.Replace("@VOUCHER_DATE", voucher.Date.ToString("dd-MM-yyyy"));
            template = template.Replace("@VOUCHER_ID", voucher.Id);
            template = template.Replace("@VOUCHER_TOTAL_TEXT", "Son: " + AmountToText(voucher.Amount.ToString()));
            template = template.Replace("@VOUCHER_TOTAL", CorrectDecimals(voucher.Amount.ToString()));
            template = template.Replace("@VOUCHER_SUBTOTAL", CorrectDecimals((voucher.Amount-voucher.Tax).ToString()));
            template = template.Replace("@VOUCHER_TAX", CorrectDecimals(voucher.Tax.ToString()));

            string items = string.Empty;
            foreach (var item in voucher.Items)
            {
                items += @$"<tr>
                                <td>{item.Code}</td>
                                <td>{item.Description}</td>
                                <td>{item.Unit}</td>
                                <td align='right'>{item.Quality}</td>
                                <td align='right'>{CorrectDecimals(item.UnitAmount.ToString())}</td>
                                <td align='right'>{CorrectDecimals(item.TotalAmount.ToString())}</td>
                            </tr>"; 
            }
            template = template.Replace("@VOUCHER_DETAILS", items);
            template = template.Replace("@VOUCHER", voucher.Type);

            return template;
        }
    }
}
