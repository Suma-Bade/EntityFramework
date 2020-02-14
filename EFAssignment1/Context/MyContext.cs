using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFAssignment1.Models;


namespace EFAssignment1.Context
{
    public class MyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GBUT1E8\SQLEXPRESS;Initial Catalog=OrderAssDB;Persist Security Info=True;User ID=sa;Password=pass@word1");
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
