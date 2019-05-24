using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Context
{
    public class Empresamaps : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa", "dbo");
            builder.HasKey(q => q.Id);
            builder.Property(e => e.Id).IsRequired().UseSqlServerIdentityColumn();
            builder.Property(e => e.Nombre).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Mision).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Vision).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.SobreNosotro).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Contacto);
            builder.Property(e => e.Correo).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Contrasenia).HasColumnType("varchar(50)").HasMaxLength(50);

        }
    }
}
