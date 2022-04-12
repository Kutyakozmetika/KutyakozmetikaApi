using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace KutyakozmetikaApi.Models
{
    public partial class kutyakozmetikaContext : DbContext
    {
        public kutyakozmetikaContext()
        {
        }

        public kutyakozmetikaContext(DbContextOptions<kutyakozmetikaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<felhasznalo> felhasznalo { get; set; }
        public virtual DbSet<kutya> kutya { get; set; }
        public virtual DbSet<megrendeles> megrendeles { get; set; }
        public virtual DbSet<szolgaltatas> szolgaltatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user id=root;database=kutyakozmetika_2019n", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.6-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_hungarian_ci");

            modelBuilder.Entity<szolgaltatas>(entity =>
            {
                entity.Property(e => e.szolgaltatasID).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
