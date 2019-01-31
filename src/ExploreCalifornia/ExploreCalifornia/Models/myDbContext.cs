using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExploreCalifornia.Models
{
    public class myDbContext : DbContext
    {
        public myDbContext() : base("ExploreCalifornia")
        {

        }
        public DbSet<Tour> Tours { get; set; }
    }
}