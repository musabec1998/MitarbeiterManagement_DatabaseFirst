using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseFirst_Projekte_Mitarbeiter.Models
{
    public partial class NETDBContext : DbContext
    {
        public NETDBContext()
        {
        }

        public NETDBContext(DbContextOptions<NETDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; } = null!;
        public virtual DbSet<Projects> Projects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectRole).HasMaxLength(100);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__Employees__Proje__797309D9");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
