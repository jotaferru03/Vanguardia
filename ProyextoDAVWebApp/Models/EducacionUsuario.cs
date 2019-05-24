using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Models
{
    public class EducacionUsuario
    {
        public int Id { get; set; }
        public String DondeEstudio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public int IdUsuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
