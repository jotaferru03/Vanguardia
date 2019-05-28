using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Model
{
    public class Usuario
    {
        public int Idusuario { get; set; }
        public String PrimerNombre { get; set; }
        public String PrimerApellido { get; set; }
        public String Cuidad { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }
        public String Contrasenia { get; set; }
        public EducacionUsuario EducacionUsuario { get; set; }
        public AplicacionTrabajo AplicacionTrabajo { get; set; }
    }
}
