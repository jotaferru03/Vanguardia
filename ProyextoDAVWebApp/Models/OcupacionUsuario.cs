using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Models
{
    public class OcupacionUsuario
    {
        public int Id { get; set; }
        public String Ocupacion { get; set; }
        public int IdUsuario { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
