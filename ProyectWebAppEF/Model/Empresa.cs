using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Model
{
    public class Empresa
    {
        public int Idempresa { get; set; }
        public String RTN { get; set; }
        public String Nombre { get; set; }
        public String Mision { get; set; }
        public String Vision { get; set; }
        public String SobreNosotros { get; set; }
        public int Contacto { get; set; }
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }
        public String Contrasenia { get; set; }
        public PublicacionTrabajo PublicacionTrabajo { get; set; }

    }
}
