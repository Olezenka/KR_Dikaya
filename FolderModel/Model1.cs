using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KR.FolderModel
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelEF")
        {
        }

        public virtual DbSet<Mall> Mall { get; set; }
        public virtual DbSet<Tenants> Tenants { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mall>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);
        }
    }
}
