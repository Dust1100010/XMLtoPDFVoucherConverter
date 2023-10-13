using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace XMLtoPDFVoucherConverter
{
    public class Company
    {
        private string CompanyJsonPath = "C:/XMLtoPDFConverter/Company.json";

        public string Name { get; set; }
        public string Id { get; set; }  
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public PDF PrimaryColor { get; set; }
        public PDF SecondaryColor { get; set; }

        public void CreateCompanyJson()
        {
            Company company = new Company
            {
                Name = "Mi Empresa",
                Id = "12345678912",
                Phone = "987654321",
                Email = "empresa@example.com",
                Address = "Calle Los Girasoles 123 - Lima",
                PrimaryColor = new PDF
                {
                    Red =9,
                    Green=122,
                    Blue=167
                },
                SecondaryColor = new PDF
                {
                    Red = 27,
                    Green = 27,
                    Blue = 27
                },
            };

            // Serializar la instancia de Company a JSON
            string json = JsonSerializer.Serialize(company);
            File.WriteAllText(CompanyJsonPath, json);
        }

        public bool UpdateCompanyJson(Company companyUpdate)
        {
            try
            {
                string json = File.ReadAllText(CompanyJsonPath);
                Company company = JsonSerializer.Deserialize<Company>(json);
                company.Name = companyUpdate.Name != null ? companyUpdate.Name : company.Name;
                company.Id = companyUpdate.Id != null ? companyUpdate.Id : company.Id;
                company.Phone = companyUpdate.Phone != null ? companyUpdate.Phone : company.Phone;
                company.Email = companyUpdate.Email != null ? companyUpdate.Email : company.Email;
                company.Address = companyUpdate.Address != null ? companyUpdate.Address : company.Address;
                company.PrimaryColor = companyUpdate.PrimaryColor != null ? companyUpdate.PrimaryColor : company.PrimaryColor;
                company.SecondaryColor = companyUpdate.SecondaryColor != null ? companyUpdate.SecondaryColor : company.SecondaryColor;
                string updatedJson = JsonSerializer.Serialize(company);
                File.WriteAllText(CompanyJsonPath, updatedJson);
                return true;
            } 
            catch 
            {
                return false;
            }
        }

        public Company CompanyDetails()
        {
            string json = File.ReadAllText($"{Program.globalVariables.DirectoryPath}/Company.json");
            Company company = JsonSerializer.Deserialize<Company>(json);          
            return company;
        }

        public void ShowLogo(PictureBox picLogo)
        {
            var logoPathInfo = new DirectoryInfo(Program.globalVariables.DirectoryPath);
            foreach (var file in logoPathInfo.GetFiles())
            {
                if(Path.GetFileNameWithoutExtension(file.Name)=="Logo")
                {
                    Program.globalVariables.LogoPath = file.FullName;
                    break;
                }
            }
            if (!string.IsNullOrEmpty(Program.globalVariables.LogoPath))
            {
                byte[] imagenBytes = File.ReadAllBytes(Program.globalVariables.LogoPath);
                MemoryStream ms = new MemoryStream(imagenBytes);
                Image imagen = Image.FromStream(ms);
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                picLogo.Image = imagen;
            }
        }

        public void UpdateLogo(PictureBox picLogo)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Elige el logo de tu empresa";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {               
                string logoPath = $"C:/XMLtoPDFConverter/Logo{Path.GetExtension(openFileDialog.FileName)}";
                File.Copy(openFileDialog.FileName, logoPath, true);               
                var directory = new DirectoryInfo(Program.globalVariables.DirectoryPath);               
                foreach (var file in directory.GetFiles())
                {
                    if (file.Name != Path.GetFileName(logoPath) && Path.GetFileNameWithoutExtension(file.Name)=="Logo")
                    {
                        File.Delete(file.FullName);
                    }
                }
                ShowLogo(picLogo);
            }
        }
        public PDF SelectedColor()
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                PDF pdf = new PDF
                {
                    Red = colorDialog.Color.R,
                    Green = colorDialog.Color.G,
                    Blue = colorDialog.Color.B
                };
                return pdf;
            }
            return null;
        }
    }
}
