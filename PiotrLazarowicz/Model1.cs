using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PiotrLazarowicz
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Reservation> Reservation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.FirstName)
                .IsUnicode(false);
        }
    }
}
