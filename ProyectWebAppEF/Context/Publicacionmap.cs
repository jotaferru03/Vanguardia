using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Context
{
    public class Publicacionmap : IEntityTypeConfiguration<PublicacionTrabajo>
    {
        public void Configure(EntityTypeBuilder<PublicacionTrabajo> builder)
        {
            builder.ToTable("PublicacionTrabajo", "dbo");
            builder.HasKey(q => q.IdPropuesta);
            builder.Property(e => e.IdPropuesta).IsRequired().UseSqlServerIdentityColumn();
            builder.Property(e => e.PuestoTrabajo).HasColumnType("varchar(80)").HasMaxLength(80);
            builder.Property(e => e.Descripcion).HasColumnType("Text").HasMaxLength(500);

            builder.HasOne(e => e.AplicacionTrabajo)
                .WithMany(e => e.PublicacionTrabajos)
                .HasPrincipalKey(e => e.IdPublicacionTrabajo);
        }
    }
}
