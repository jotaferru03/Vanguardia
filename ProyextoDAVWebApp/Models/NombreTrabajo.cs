using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Models
{
    public class NombreTrabajo
    {
        public int Id { get; set; }
        public String PuestoTrabajo { get; set; }
        public int IdReclutamientoTrabajo { get; set; }
        public ReclutamientoTrabajo ReclutamientoTrabajo { get; set; }
    }
}
