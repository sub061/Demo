using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SubhashTripathi_Demo.Models;

namespace SubhashTripathi_Demo.Models
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext() : base("name=DemoContext")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        { 
        
        }

        public DbSet <Product> products { get; set; }
    }
}