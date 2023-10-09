namespace XMLtoPDFVoucherConverter
{
    public partial class frmXMLConverter : Form
    {
        Dictionary<string, string> _vouchers;
        List<string> _xmlNames;
        List<string> _xmlPaths;
        string _logoPath = string.Empty;
        string _directoryPath = "C:/XMLtoPDFConverter";
        Color _mainColor;
        Color _secondaryColor;
        PDF pdf = new PDF();
        XML xml = new XML();

        public frmXMLConverter()
        {
            InitializeComponent();
            pdf.ProgresoActualizado += (progreso) =>
            {
                Invoke(new Action(() =>
                {
                    progressBar1.Value = progreso;
                }));
            };
        }
        private void frmXMLConverter_Load(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(_directoryPath);
            if (!directory.Exists) directory.Create();
            else
            {
                foreach (var item in directory.GetFiles())
                {
                    if (Path.GetFileNameWithoutExtension(item.Name) == "Logo")
                    {
                        _logoPath = item.FullName;
                        ShowLogoInPictureBox();
                        break;
                    }
                }
            }
        }
        
        /***XML***/
        private void ibtnUploadXml_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Elige los archivos XML";
                openFileDialog.Filter = "Archivos XML|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.SafeFileNames.ToList() == null) throw new Exception("Elige archivos XML");
                    List<string> listNames = xml.AddXmlNamesToList(openFileDialog.SafeFileNames.ToList(), _xmlNames);
                    List<string> listPaths = xml.AddXmlPathsToList(openFileDialog.FileNames.ToList(), _xmlPaths);
                    _xmlNames = new List<string>();
                    _xmlPaths = new List<string>();
                    _vouchers = new Dictionary<string, string>();
                    foreach (var name in listNames)
                    {
                        _xmlNames.Add(name);
                        _vouchers.Add(name, Properties.Resources.comprobanteElectronico.ToString());
                    }
                    foreach (var path in listPaths) _xmlPaths.Add(path);
                 
                    lstXlms.DataSource = null;
                    lstXlms.DataSource = _xmlNames;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        /***LOGO***/
        private void picLogo_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Elige el logo de tu empresa";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _logoPath = $"{_directoryPath}/Logo{Path.GetExtension(openFileDialog.FileName)}";
                File.Copy(openFileDialog.FileName, _logoPath, true);
                ShowLogoInPictureBox();

                var directory = new DirectoryInfo(_directoryPath);
                foreach (var file in directory.GetFiles())
                {
                    if(file.Name != Path.GetFileName(_logoPath)) File.Delete(file.FullName);
                }
            }
        }
        private void ShowLogoInPictureBox()
        {
            byte[] imagenBytes = File.ReadAllBytes(_logoPath);
            MemoryStream ms = new MemoryStream(imagenBytes);
            Image imagen = Image.FromStream(ms);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.Image = imagen;           
        }

        /***PDF VIEWER***/     
        private void lblMainColor_DoubleClick(object sender, EventArgs e)
        {
            if (pdf.SelectedColorPDF() == Color.Empty) _secondaryColor = Color.Black;
            else
            {
                _mainColor = pdf.SelectedColorPDF();
                lblMainColor.ForeColor = _mainColor;
            }           
        }
        private void lblSecondaryColor_DoubleClick(object sender, EventArgs e)
        {
            if (pdf.SelectedColorPDF() == Color.Empty) _secondaryColor = Color.Blue;
            else
            {
                _secondaryColor = pdf.SelectedColorPDF();
                lblSecondaryColor.ForeColor = _secondaryColor;
            }            
        }
        private async void ibtnPDF_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            await pdf.GeneraPDF(_vouchers, iText.Kernel.Geom.PageSize.A4);
        }
    }
}