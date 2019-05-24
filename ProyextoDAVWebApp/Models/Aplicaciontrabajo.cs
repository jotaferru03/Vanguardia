using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Models
{
    public class Aplicaciontrabajo
    {
        public int Id { get; set; }
        public int IdReclutamientoTrabajo { get; set; }
        public int IdUsuario { get; set; }

        public List<Usuario> Usuarios { get; set; }
        public List<ReclutamientoTrabajo> ReclutamientoTrabajo { get; set; }

    }
}
