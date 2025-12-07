using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMS.Domain.Entity;

namespace SMS.Infrastructure.Data
{
    public class SmsDbContext : DbContext
    {
        public SmsDbContext(DbContextOptions<SmsDbContext> options)
          : base(options)
        {
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Section> Sections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");
                entity.HasKey(x => x.ClassId);
                entity.Property(x => x.ClassId)
                      .ValueGeneratedOnAdd();

                entity.Property(x => x.ClassName)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(e => e.IsActive).HasDefaultValue(true);
                entity.Property(e => e.CreationDate)
               .HasDefaultValueSql("(getdate())")
               .HasColumnType("datetime");
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.ToTable("Section");
                entity.HasKey(x => x.SectionId);
                entity.Property(x => x.SectionId)
                      .ValueGeneratedOnAdd();

                entity.Property(x => x.SectionName)
                      .IsRequired()
                      .HasMaxLength(100);
                entity.Property(e => e.IsActive).HasDefaultValue(true);
                entity.Property(e => e.CreationDate)
               .HasDefaultValueSql("(getdate())")
               .HasColumnType("datetime");
            });
        }

    }
}
