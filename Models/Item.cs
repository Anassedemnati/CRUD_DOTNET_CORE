﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
    }
}