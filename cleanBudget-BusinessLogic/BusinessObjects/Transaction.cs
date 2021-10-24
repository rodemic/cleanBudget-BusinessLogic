using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class Transaction
    {
        public int ID { get; set; }
        public double Amount { get; set; }
        public Category Category { get; set; }
        public string AccountID { get; set; }
    }
}
