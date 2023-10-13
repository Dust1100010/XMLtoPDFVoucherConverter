using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtoPDFVoucherConverter
{
    public class VoucherItem
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public double Quality { get; set; }
        public decimal UnitAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
