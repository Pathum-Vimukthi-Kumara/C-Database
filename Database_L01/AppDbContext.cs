using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_L01
{
    public class AppDbContext : DbContext
    {
        public DbSet<Transactions> Transactions { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\\Users\\hp\\Documents\\Budget Tracker\\Budget_Tracker\\C# code\\Budget Tracker\\Transactions.db");
        }

    }
}