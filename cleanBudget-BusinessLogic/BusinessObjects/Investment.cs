using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class Investment
    {
        public int ID { get; set; }
        public string Ticker { get; set; }
        public double Amount { get; set; }
        public double Cost { get; set; }
        public DateTime PurchDate { get; set; }
        public string AccountID { get; set; }
    }
}
