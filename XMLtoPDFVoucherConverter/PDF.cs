using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtoPDFVoucherConverter
{
    public class PDF
    {
        public Color SelectedColorPDF()
        {
            Color selectedColor = Color.Empty;
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog.Color;
            }
            return selectedColor;
        }
    }
}
