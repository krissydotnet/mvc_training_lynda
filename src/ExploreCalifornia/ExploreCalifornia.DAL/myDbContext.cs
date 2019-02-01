using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExploreCalifornia.Models
{
    public class myDbContext : DbContext
    {
        public myDbContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dukesc\source\repos\krissydotnet\mvc_training_lynda\src\ExploreCalifornia\ExploreCalifornia\App_Data\ExploreCalifornia.mdf;Integrated Security=True")
        {

        }
        public DbSet<Tour> Tours { get; set; }
    }
}