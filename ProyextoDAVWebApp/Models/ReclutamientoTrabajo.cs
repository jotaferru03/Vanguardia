using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Models
{
    public class ReclutamientoTrabajo
    {
        public int Id { get; set; }
        public String SeRecluta { get; set; }
        public String Descripcion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdAplicaciontrabajo { get; set;}
        public Empresa Empresa { get; set; }
        //public NombreTrabajo NombreTrabajo { get; set; }
        public Aplicaciontrabajo Aplicaciontrabajo { get; set; }
    }
}
