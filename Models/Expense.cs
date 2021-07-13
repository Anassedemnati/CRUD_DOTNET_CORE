using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [DisplayName("Expense Name")]
        [Required]
        public string ExpenseName { get; set; }
        [Required]
        [Range(1, int.MaxValue,ErrorMessage ="Amount must be greater than 0!")]
        public double amount { get; set; }
        [DisplayName("Expense type")]
        public int categoryId { get; set; }
        [ForeignKey("categoryId")]
        public virtual ExpensesCategory ExpensesCategory { get; set; }
    }
}
