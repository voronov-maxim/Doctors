using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GomoiuWeb.Shared.Data.DB
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientAppointments> ClientAppointments { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=127.0.0.1;Database=mydb;Uid=root;password=123456;Connection Timeout=300");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientAppointments>(entity =>
            {
                entity.HasIndex(e => e.DoctorId)
                    .HasName("FK_ClientAppointments_Doctors_Id");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ClientAppointments)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_ClientAppointments_Doctors_Id");
            });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Name).HasColumnType("varchar(255)");
            });
        }
    }
}
