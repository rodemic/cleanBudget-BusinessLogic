using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public Category Category { get; set; }
        public int AccountID { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
