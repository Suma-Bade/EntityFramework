using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnEFCodefirst.Models;
namespace HandsOnEFCodefirst.Context
{
    class MyContext:DbContext
    {
        //define entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GBUT1E8\SQLEXPRESS;Initial Catalog=StudentDB;User ID=sa;Password=pass@word1");
        }
    }
}
