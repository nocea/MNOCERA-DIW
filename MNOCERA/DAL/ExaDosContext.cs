using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MNOCERA.Models;

public partial class ExaDosContext : DbContext
{
    public ExaDosContext()
    {
    }

    public ExaDosContext(DbContextOptions<ExaDosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Prestamo> Prestamos { get; set; }

    public virtual DbSet<PrestamoVajilla> PrestamoVajillas { get; set; }

    public virtual DbSet<Vajilla> Vajillas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=exaDos;UserId=postgres;Password=mariomanu7.;SearchPath=esqexados");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prestamo>(entity =>
        {
            entity.HasKey(e => e.Idreserva).HasName("prestamo_pkey");

            entity.ToTable("prestamo", "esqexados");

            entity.Property(e => e.Idreserva)
                .HasDefaultValueSql("nextval('prestamo_idreserva_seq'::regclass)")
                .HasColumnName("idreserva");
            entity.Property(e => e.Fchreserva)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fchreserva");
        });

        modelBuilder.Entity<PrestamoVajilla>(entity =>
        {
            entity.HasKey(e => new { e.ListaprestamosIdreserva, e.ListavajillaIdelemento }).HasName("prestamo_vajilla_pkey");

            entity.ToTable("prestamo_vajilla");

            entity.Property(e => e.ListaprestamosIdreserva).HasColumnName("listaprestamos_idreserva");
            entity.Property(e => e.ListavajillaIdelemento).HasColumnName("listavajilla_idelemento");
        });

        modelBuilder.Entity<Vajilla>(entity =>
        {
            entity.HasKey(e => e.Idelemento).HasName("vajilla_pkey");

            entity.ToTable("vajilla", "esqexados");

            entity.Property(e => e.Idelemento)
                .HasDefaultValueSql("nextval('vajilla_idelemento_seq'::regclass)")
                .HasColumnName("idelemento");
            entity.Property(e => e.Cantidadelemento).HasColumnName("cantidadelemento");
            entity.Property(e => e.Codigoelemento)
                .HasMaxLength(255)
                .HasColumnName("codigoelemento");
            entity.Property(e => e.Descripcionelemento)
                .HasMaxLength(255)
                .HasColumnName("descripcionelemento");
            entity.Property(e => e.Nombreelemento)
                .HasMaxLength(255)
                .HasColumnName("nombreelemento");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
