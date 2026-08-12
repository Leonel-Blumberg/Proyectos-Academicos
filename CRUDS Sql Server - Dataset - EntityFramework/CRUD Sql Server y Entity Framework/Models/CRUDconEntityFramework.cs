using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Sql_Server_y_Entity_Framework.Models;

public partial class CRUDconEntityFramework : DbContext
{
    public CRUDconEntityFramework()
    {
    }

    public CRUDconEntityFramework(DbContextOptions<CRUDconEntityFramework> options)
        : base(options)
    {
    }

    public virtual DbSet<Personas3> Personas3 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CRUDconEntityFramework;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personas3>(entity =>
        {
            entity.ToTable("Personas3");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Correo)
                .HasMaxLength(120)
                .IsUnicode(false);
            entity.Property(e => e.FechaDeNacimiento).HasColumnName("Fecha de Nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
