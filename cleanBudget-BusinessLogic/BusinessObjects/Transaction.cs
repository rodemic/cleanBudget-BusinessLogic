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
        public int CategoryId { get; set; }
        public int AccountId { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
