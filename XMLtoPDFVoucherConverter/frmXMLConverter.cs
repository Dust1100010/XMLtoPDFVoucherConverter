

namespace XMLtoPDFVoucherConverter
{
    public partial class frmXMLConverter : Form
    {
        List<string> _xmlNames;
        List<string> _xmlPaths;
        string _logoPath = string.Empty;
        string _directoryPath = "C:/XMLtoPDFConverter";
        Color _mainColor;
        Color _secondaryColor;
        PDF pdf = new PDF();

        public frmXMLConverter()
        {
            InitializeComponent();
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
                    }
                }
            }
        }
        
        /***XML***/
        private void ibtnUploadXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Elige los archivos XML";
            openFileDialog.Filter = "Archivos XML|*.xml";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddXmlToList(openFileDialog.SafeFileNames.ToList(), openFileDialog.FileNames.ToList());
            }
        }
        public void AddXmlToList(List<string> names, List<string> paths)
        {
            try
            {
                if (names == null) throw new Exception("Elige archivos XML");
                if(_xmlNames == null) _xmlNames = new List<string>();
                if (_xmlPaths == null) _xmlPaths = new List<string>();

                foreach (var name in names)
                {
                    if (!ExistXmlOnList(name))
                    {
                        _xmlNames.Add(name);
                        _xmlPaths.Add(GetXmlPath(name, paths));
                    }
                }
                lstXlms.DataSource = null;
                lstXlms.DataSource = _xmlNames;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ExistXmlOnList(string xml)
        {
            bool exist = false;
            foreach (var item in _xmlNames)
            {
                if (item == xml)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        private string GetXmlPath(string xmlName, List<string> paths)
        {
            string path = string.Empty;
            foreach (var item in paths)
            {
                if (item.Contains(xmlName))
                {
                    path = item;
                    break;
                }
            }

            return path;
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
    }
}