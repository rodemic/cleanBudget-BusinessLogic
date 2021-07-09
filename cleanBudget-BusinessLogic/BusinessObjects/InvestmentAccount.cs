using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class InvestmentAccount
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime SetDate { get; set; }
        public virtual ICollection<Investment> Investments { get; set; }
        public string AccountID { get; set; }
    }
}
