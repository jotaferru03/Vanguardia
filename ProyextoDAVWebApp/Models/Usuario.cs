using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public String PrimerNombre { get; set; }
        public String PrimerApellido { get; set; }
        public String Cuidad { get; set; }
        public String Direccion { get; set; }
        public int Telefono { get; set; }
        [DataType(DataType.EmailAddress)]
        public String Correo { get; set; }
        public String Contrasenia { get; set; }
        public Aplicaciontrabajo AplicacionTrabajo { get; set; }
        public OcupacionUsuario OcupacionUsuario { get; set; }
        public EducacionUsuario EducacionUsuario { get; set; }



    }
}
