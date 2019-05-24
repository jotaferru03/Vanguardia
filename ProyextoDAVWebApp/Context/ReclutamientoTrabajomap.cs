using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Context
{
    public class ReclutamientoTrabajomap : IEntityTypeConfiguration<ReclutamientoTrabajo>
    {
        public void Configure(EntityTypeBuilder<ReclutamientoTrabajo> builder)
        {
            builder.ToTable("ReclutamientoTrabajo", "dbo");
            builder.HasKey(q => q.Id);
            builder.Property(e => e.Id).IsRequired().UseSqlServerIdentityColumn();
            builder.Property(e => e.SeRecluta).HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(e => e.Descripcion).HasColumnType("varchar(50)").HasMaxLength(50);


            //builder.HasOne(e => e.Aplicaciontrabajo).WithOne(e => e.ReclutamientoTrabajo).HasPrincipalKey(e => e.)

            //           builder.HasOne(e => e.EducacionUsuario)
            //    .WithMany(e => e.Usuarios)
            //    .HasPrincipalKey(e => e.IdUsuario);
        }


    }
}
