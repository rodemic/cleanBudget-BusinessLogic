using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class FinancialAccount
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double StartingAmount { get; set; }
        public DateTime SetDate { get; set; }
        public string AccountID { get; set; }
    }
}
