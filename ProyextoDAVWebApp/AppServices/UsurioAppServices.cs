using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyextoDAVWebApp.Context;
using ProyextoDAVWebApp.DomainServices;
using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.AppServices
{
    public class UsurioAppServices
    {
        private readonly LinkliDosDataContext _baseDatos;
        private readonly UsuarioDomainServices _usuarioDomainServicesDatos;
        public UsurioAppServices(LinkliDosDataContext baseDatos, UsuarioDomainServices usuarioDomainServicesDatos)
        {
            _baseDatos = baseDatos;
            _usuarioDomainServicesDatos = usuarioDomainServicesDatos;
        }
        public async Task<String> RegistrarUsuario(Usuario usuarioRequest)
        {
            var usuario = _baseDatos.Usuarios.FirstOrDefaultAsync(q => q.Id == usuarioRequest.Id);
            var usuarioyaexiste = usuario != null;
            if (usuarioyaexiste)
            {
                return "El Usaurio ya existe existe";
            }

             


            
            var respuestaDomain = _usuarioDomainServicesDatos.RegistrarUsuario(usuarioRequest);
            var vieneconErroreneldomain = respuestaDomain != null;
            if (vieneconErroreneldomain)
            {
                return respuestaDomain;
            }

            _baseDatos.Usuarios.Add(usuarioRequest);
            await _baseDatos.SaveChangesAsync();

            return null;
        }

        private object LinkeliDosDataContext()
        {
            throw new NotImplementedException();
        }
    }
}
