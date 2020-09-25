using System;
using Avalanche.Host.Models;
using Microsoft.EntityFrameworkCore;

namespace Avalanche.Host.Data
{
    public class AvalancheDbContext : DbContext
    {
        public AvalancheDbContext(DbContextOptions<AvalancheDbContext> options) : base(options)
        {

        }

        public DbSet<MobileNumber> MobileNumbers { get; set; }
        public DbSet<OperationLog> OperationLogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MobileNumber>(b =>
            {
                b.ToTable("m912");
                b.HasNoKey();

                b.Property(a => a.Msisdn)
                .HasColumnName("MOBILENUMBER")
                .HasMaxLength(50)
                .IsRequired(false);
            });

            modelBuilder.Entity<OperationLog>(b =>
            {
                b.ToTable("OperationLogs");
                b.HasKey(a => a.Id);

                b.Property(a => a.Msisdn).HasColumnType("varchar(11)").IsRequired();
                b.Property(a => a.Text).HasColumnType("nvarchar(512)").IsRequired();
                b.Property(a => a.SentDate).HasColumnType("datetime").IsRequired();
                b.Property(a => a.BrokerResponse).HasColumnType("nvarchar(1024)").IsRequired();
            });
        }
    }
}
