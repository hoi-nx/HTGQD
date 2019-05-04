using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace HTGQD2.Models
{
    public class DataContext:DbContext
    {
        //public DataContext() : base("name=xxx")
        //{

        //}
        public virtual DbSet<University> University { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new DataInit());
        }
    }
}