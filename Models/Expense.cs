using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [DisplayName("Expense Name")]
        public string ExpenseName { get; set; }
        public double amount { get; set; }
    }
}
