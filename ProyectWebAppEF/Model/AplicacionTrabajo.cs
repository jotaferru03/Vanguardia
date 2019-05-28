using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Model
{
    public class AplicacionTrabajo
    {
        public int Idaplicacion { get; set; }
        public int IdUsuario { get; set; }
        public int IdPublicacionTrabajo { get; set; }
        public List<Usuario> Usuarios { get; set; }
        public List<PublicacionTrabajo> PublicacionTrabajos { get; set; }
    }
}
