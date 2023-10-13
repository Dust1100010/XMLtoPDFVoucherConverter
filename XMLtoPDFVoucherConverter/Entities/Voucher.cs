using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLtoPDFVoucherConverter
{
    public class Voucher
    {       
        public string Type { get; set; }
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public Company Company { get; set; } 
        public Customer Customer { get; set; }
        public List<VoucherItem> Items { get; set; } = new List<VoucherItem>();
        public decimal Tax { get; set; }
        public decimal Amount { get; set; }
    }
}
