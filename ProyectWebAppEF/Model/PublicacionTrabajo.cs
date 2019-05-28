using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Model
{
    public class PublicacionTrabajo
    {
        public int IdPropuesta { get; set; }
        public String PuestoTrabajo { get; set; }
        public String Descripcion { get; set; }
        public int IdEmpresa { get; set; }
        public List<Empresa> Empresas { get; set; }
        public AplicacionTrabajo AplicacionTrabajo { get; set; }
    }
}
