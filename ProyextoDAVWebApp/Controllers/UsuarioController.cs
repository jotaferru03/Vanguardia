using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyextoDAVWebApp.AppServices;
using ProyextoDAVWebApp.Context;
using ProyextoDAVWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyextoDAVWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly LinkliDosDataContext _baseDatos;
        private readonly UsurioAppServices _usuarioAppServices;
        // GET: /<controller>/

        public UsuarioController(LinkliDosDataContext context, UsurioAppServices usuarioAppServices)
        {
            _baseDatos = context;
            _usuarioAppServices = usuarioAppServices;

            if(_baseDatos.Usuarios.Count() == 1)
            {
                _baseDatos.Usuarios.Add(new Usuario { PrimerNombre = "Jordan", PrimerApellido = "Ferrufino",
                    Cuidad = "San Pedro Sula", Direccion = "Colonia Las Universidades", Telefono = 87741883,
                    Correo = "jota.ferru3@gmail.com", Contrasenia = "Contrasenia" });
                _baseDatos.SaveChanges();
            }
        }
        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuario()
        {
            return await _baseDatos.Usuarios.ToListAsync();
        }
        // GET: api/Usuario/1
        [HttpGet("{Id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(long id)
        {
            var usuario = await _baseDatos.Usuarios.FirstOrDefaultAsync(q => q.Id == id);

            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }

        //POST: api/Usuario
        [HttpPost]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario item)
        {
            var respuesta = await _usuarioAppServices.RegistrarUsuario(item); 
            if(respuesta == null)
            {
                return CreatedAtAction(nameof(GetUsuario), new { Id = item.Id }, item);
            }
            return null;
        }

        //POST Rango: api/Usuario
        [HttpPost("rango")]

        public async Task<ActionResult<Usuario>> PostUsuario(IEnumerable<Usuario> items)
        {
            _baseDatos.Usuarios.AddRange(items);
            await _baseDatos.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsuario), items);
        }

        //PUT: api/Usuario/1
        [HttpPut("{Id}")]

        public async Task<ActionResult> PostUsuario(int id, Usuario item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }

            /*Clase curso = await _baseDatos.Cursos.FirstOrDefaultAsync(q => q.Id == item.CrusoId);
            if (curso == null)
            {
                return NotFound("El curso no existe");
            }*/

            _baseDatos.Entry(item).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();
            return NoContent();
        }

        // Delete: api/Usuario/1
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteUsuario(int id)
        {
            var usuario = await _baseDatos.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }
            _baseDatos.Usuarios.Remove(usuario);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }

        //Delete Rango: api/Usuario/1
        [HttpDelete("rango")]

        public async Task<ActionResult> DeleteEstudiante(IEnumerable<int> ids)
        {
            IEnumerable<Usuario> usuarios = _baseDatos.Usuarios.Where(q => ids.Contains(q.Id));

            if (usuarios == null)
            {
                return NotFound();
            }

            _baseDatos.Usuarios.RemoveRange(usuarios);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }
    }
}
