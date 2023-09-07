using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.Models;

public partial class VeterinariaContext : DbContext
{
    public VeterinariaContext()
    {
    }

    public VeterinariaContext(DbContextOptions<VeterinariaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Comidum> Comida { get; set; }

    public virtual DbSet<Dueño> Dueños { get; set; }

    public virtual DbSet<Mascota> Mascotas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-PO6LMRS\\YEIMIGONZALEZ;Database=Veterinaria; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Comidum>(entity =>
        {
            entity.HasKey(e => e.IdComida);

            entity.Property(e => e.IdComida).HasColumnName("ID_Comida");
            entity.Property(e => e.Marca)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nombre)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Dueño>(entity =>
        {
            entity.HasKey(e => e.IdDueños);

            entity.Property(e => e.IdDueños).HasColumnName("ID_Dueños");
            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Direccion).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Mascota>(entity =>
        {
            entity.HasKey(e => e.IdMascotas);

            entity.Property(e => e.IdMascotas).HasColumnName("ID_Mascotas");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Raza).HasMaxLength(50);
            entity.Property(e => e.Tamaño).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
