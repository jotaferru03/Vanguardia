using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Context
{
    public class Usuariomap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "dbo");
            builder.HasKey(q => q.Idusuario);
            builder.Property(e => e.Idusuario).IsRequired().UseSqlServerIdentityColumn();
            builder.Property(e => e.PrimerNombre).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.PrimerApellido).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Cuidad).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Direccion).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Telefono);
            builder.Property(e => e.Correo).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Contrasenia).HasColumnType("varchar(50)").HasMaxLength(50);

            builder.HasOne(e => e.EducacionUsuario)
                .WithMany(e => e.Usuarios)
                .HasPrincipalKey(e => e.IdUsuario);

            builder.HasOne(e => e.AplicacionTrabajo)
                .WithMany(e => e.Usuarios)
                .HasPrincipalKey(e => e.IdUsuario);
        }
    }
}
