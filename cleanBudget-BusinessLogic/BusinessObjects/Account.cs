using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double StartingAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserAccountId { get; set; }
    }
}
