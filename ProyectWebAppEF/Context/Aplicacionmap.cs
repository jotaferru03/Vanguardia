using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Context
{
    public class Aplicacionmap : IEntityTypeConfiguration<AplicacionTrabajo>
    {
        public void Configure(EntityTypeBuilder<AplicacionTrabajo> builder)
        {
            builder.ToTable("AplicacionTrabajo", "dbo");
            builder.HasKey(q => q.Idaplicacion);
            builder.Property(e => e.Idaplicacion).IsRequired().UseSqlServerIdentityColumn();
        }

    }
}
