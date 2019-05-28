using Microsoft.EntityFrameworkCore;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Context
{
    public class ProyectoDataContext : DbContext
    {
        public DbSet<AplicacionTrabajo> AplicacionTrabajos { get; set; }
        public DbSet<EducacionUsuario> EducacionUsuarios { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<PublicacionTrabajo> PublicacionTrabajos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = .\SQLEXPRESS;Database=ProyectoDB;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Usuariomap());
            modelBuilder.ApplyConfiguration(new Empresamap());
            modelBuilder.ApplyConfiguration(new Publicacionmap());
            modelBuilder.ApplyConfiguration(new EducacionUsuariomap());
            modelBuilder.ApplyConfiguration(new Aplicacionmap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
