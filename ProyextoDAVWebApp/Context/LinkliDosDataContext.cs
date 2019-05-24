using Microsoft.EntityFrameworkCore;
using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Context
{
    public class LinkliDosDataContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aplicaciontrabajo> Aplicaciontrabajos { get; set; }
        public DbSet<EducacionUsuario> EducacionUsuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<NombreTrabajo> NombreTrabajos { get; set; }
        public DbSet<OcupacionUsuario> OcupacionUsuarios { get; set; }
        public DbSet<ReclutamientoTrabajo> ReclutamientoTrabajos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS;Database=ProyectoDAVDB;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LinkliDosmap());
            base.OnModelCreating(modelBuilder);
        }
    
    }
}
