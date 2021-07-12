using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Models
{
    public class ExpensesCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Expenses Category")]
        public string CatName { get; set; }


    }
}
