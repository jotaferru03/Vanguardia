using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.DomainServices
{
    public class UsuarioDomainServices
    {
        public string RegistrarUsuario(Usuario usuarioRequest)
        {
            var esEdadValida = usuarioRequest.Id < 18;
            if (esEdadValida)
            {
                return "No tiene la edad suficiente";
            }
            return null;
        }
    }
}
