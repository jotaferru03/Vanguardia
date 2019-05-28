using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.DomainServices
{
    public class UsuarioDomainServices
    {
        public string RegistrarUsuario(Usuario usuarioRequest)
        {
            var esEdadValida = usuarioRequest.Idusuario < 18;
            if (esEdadValida)
            {
                return "No tiene la edad suficiente";
            }
            return null;
        }
    }
}
