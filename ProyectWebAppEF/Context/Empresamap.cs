using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Context
{
    public class Empresamap : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa", "dbo");
            builder.HasKey(q => q.Idempresa);
            builder.Property(e => e.Idempresa).IsRequired().UseSqlServerIdentityColumn();
            builder.Property(e => e.RTN).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(e => e.Mision).HasColumnType("Text");
            builder.Property(e => e.Vision).HasColumnType("Text");
            builder.Property(e => e.SobreNosotros).HasColumnType("Text");
            builder.Property(e => e.Contacto);
            builder.Property(e => e.Correo).HasColumnType("varchar(100)").HasMaxLength(100);
            builder.Property(e => e.Contrasenia).HasColumnType("varchar(50)").HasMaxLength(50);

            builder.HasOne(e => e.PublicacionTrabajo)
                .WithMany(e => e.Empresas)
                .HasPrincipalKey(e => e.IdEmpresa);
        }
    }
}
