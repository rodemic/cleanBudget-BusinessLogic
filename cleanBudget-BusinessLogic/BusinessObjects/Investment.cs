using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanBudget_BL.BusinessObjects
{
    public class Investment
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(4)]
        public string Ticker { get; set; }
        public double Amount { get; set; }
        public double Cost { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int AccountId { get; set; }
    }
}
