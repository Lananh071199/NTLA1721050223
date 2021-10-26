using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NTLA1721050223.Models
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext")
        {
        }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.PersonID)
                .IsUnicode(false);

        }
    }
}