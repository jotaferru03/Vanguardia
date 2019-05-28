using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Context
{
    public class EducacionUsuariomap : IEntityTypeConfiguration<EducacionUsuario>
    {
        public void Configure(EntityTypeBuilder<EducacionUsuario> builder)
        {
            builder.ToTable("EducacionUsuario", "dbo");
            builder.HasKey(q => q.IdEducacion);
            builder.Property(e => e.IdEducacion).IsRequired().UseSqlServerIdentityColumn();
            builder.Property(e => e.DondeEstudio).HasColumnType("varchar(100)").HasMaxLength(100);
            builder.Property(e => e.FechaFinal).HasColumnType("Date");
            builder.Property(e => e.FechaFinal).HasColumnType("Date");
            builder.Property(e => e.Descripcion).HasColumnType("Text");
        }
    }
}
