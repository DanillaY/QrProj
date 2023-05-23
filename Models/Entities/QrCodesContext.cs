using System;
using System.Collections.Generic;
using copyqr.Controllers;
using Microsoft.EntityFrameworkCore;

namespace copyqr.Models.Entities;

public partial class QrCodesContext : DbContext
{
    public static string? _connectionString { get; set; }
    public QrCodesContext()
    {
    }

    public QrCodesContext(DbContextOptions<QrCodesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<QrInfo> QrInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(_connectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<QrInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_qr_info");

            entity.ToTable("qr_info");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContentEncode).HasColumnName("content_encode");
            entity.Property(e => e.DateCreated)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("date_created");
            entity.Property(e => e.Image).HasColumnName("image");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public static void SetConnectionString(string sqlConnection)
           => _connectionString = sqlConnection;
}
