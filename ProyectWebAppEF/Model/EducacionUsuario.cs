using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Model
{
    public class EducacionUsuario
    {
        public int IdEducacion { get; set; }
        public int DondeEstudio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public String Descripcion { get; set; }
        public int IdUsuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
