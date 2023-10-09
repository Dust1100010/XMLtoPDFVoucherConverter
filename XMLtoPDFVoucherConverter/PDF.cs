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

namespace XMLtoPDFVoucherConverter
{
    public class PDF
    {
        public event Action<int> ProgresoActualizado;

        public System.Drawing.Color SelectedColorPDF()
        {
            System.Drawing.Color selectedColor = System.Drawing.Color.Empty;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
            return selectedColor;
        }

        private string validatePDFVoucherName(string path)
        {
            int version = 1;
            string name = Path.GetFileNameWithoutExtension(path) + Path.GetExtension(path);

            while (File.Exists(path))
            {
                name = Path.GetFileNameWithoutExtension(path) + " (" + version.ToString() + ")" + Path.GetExtension(path);
                path = Path.GetDirectoryName(path)+"/"+ name;
                version++;
            }
            return name;
        }

        public async Task GeneraPDF(Dictionary<string, string> voucherHtml, iText.Kernel.Geom.PageSize tipoHoja)
        {
            int totalSteps = voucherHtml.Count;
            int currentStep = 0;

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                
                foreach (var voucher in voucherHtml)
                {
                    string pathFile = $"{folderBrowser.SelectedPath}/{Path.GetFileNameWithoutExtension(voucher.Key)}.pdf";
                    string fileName = $"{folderBrowser.SelectedPath}/{validatePDFVoucherName(pathFile)}";
                    using (FileStream temp = new FileStream(fileName, FileMode.Create))
                    {
                        PdfWriter writer = new PdfWriter(temp);
                        PdfDocument pdf = new PdfDocument(writer);
                        Document doc = new Document(pdf, tipoHoja);
                        ConverterProperties converterProperties = new ConverterProperties();
                        using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(voucher.Value)))
                        {
                            await Task.Run(() => HtmlConverter.ConvertToPdf(stream, pdf, converterProperties));
                        }
                        doc.Close();
                    }
                    currentStep++;
                    int progreso = (int)((double)currentStep / totalSteps * 100);
                    ProgresoActualizado?.Invoke(progreso);
                }
               
                MessageBox.Show("PDF generado", "PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }          
        }
    }
}
