using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtoPDFVoucherConverter
{
    public class XML
    {
        public List<string> AddXmlNamesToList(List<string> paths)
        {
            List<string> names = new List<string>();
            if (paths == null) paths = new List<string>();
            foreach (var path in paths)
            {
                names.Add(Path.GetFileName(path));
            }
            return names;
        }
        
        public List<string> AddXmlPathsToList(List<string> paths)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Multiselect = true;
                openFileDialog.Title = "Elige los archivos XML";
                openFileDialog.Filter = "Archivos XML|*.xml";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.SafeFileNames.ToList() == null)
                        throw new Exception("Elige archivos XML");

                    if (paths == null) paths = new List<string>();
                    foreach (var path in openFileDialog.FileNames.ToList())
                    {
                        if (!ExistXmlOnList(path, paths)) paths.Add(path);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PDFVoucherConverter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return paths;
        }

        private bool ExistXmlOnList(string name, List<string> xmlList)
        {
            bool exist = false;
            foreach (var item in xmlList)
            {
                if (item == name)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

    }
}
