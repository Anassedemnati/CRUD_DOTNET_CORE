using inandout.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        //creation du Dbset
        public DbSet<Item> Items { get; set; }//table 
        public DbSet<Expense> Expense { get; set; }
    }
}
