using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Context
{
    public class AplicacionTrabajomap : IEntityTypeConfiguration<Aplicaciontrabajo>
    {
        public void Configure(EntityTypeBuilder<Aplicaciontrabajo> builder)
        {
            builder.ToTable("AplicacionTrabajo", "dbo");
            builder.HasKey(q => q.Id);
            builder.Property(e => e.Id).IsRequired().UseSqlServerIdentityColumn();

        }
    
    }
}
