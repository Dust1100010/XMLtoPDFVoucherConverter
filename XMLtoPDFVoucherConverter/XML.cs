using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtoPDFVoucherConverter
{
    public class XML
    {
        public List<string> AddXmlNamesToList(List<string> names, List<string> xmlListNames)
        {
            if(xmlListNames == null) xmlListNames = new List<string>();

            foreach (var name in names)
            {
                if (!ExistXmlOnList(name, xmlListNames)) xmlListNames.Add(name);
            }

            return xmlListNames;
        }
        
        public List<string> AddXmlPathsToList(List<string> paths, List<string> xmlListPaths)
        {
            if (xmlListPaths == null) xmlListPaths = new List<string>();

            foreach (var path in paths)
            {
                if (!ExistXmlOnList(path, xmlListPaths)) xmlListPaths.Add(path);
            }

            return xmlListPaths;
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
