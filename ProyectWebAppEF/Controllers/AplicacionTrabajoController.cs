using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectWebAppEF.Context;
using ProyectWebAppEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectWebAppEF.Controllers
{
    public class AplicacionTrabajoController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class UsuarioController : ControllerBase
        {
            private readonly ProyectoDataContext _baseDatos;
            //private readonly UsurioAppServices _usuarioAppServices;
            // GET: /<controller>/

            public UsuarioController(ProyectoDataContext context/*, UsurioAppServices usuarioAppServices*/)
            {
                _baseDatos = context;
                //_usuarioAppServices = usuarioAppServices;

                if (_baseDatos.AplicacionTrabajos.Count() == 1)
                {
                    _baseDatos.AplicacionTrabajos.Add(new AplicacionTrabajo
                    {
                        IdUsuario = 1,
                        IdPublicacionTrabajo = 1
                    });
                    _baseDatos.SaveChanges();
                }
            }
            // GET: api/AplicacionTrabajo
            [HttpGet]
            public async Task<ActionResult<IEnumerable<AplicacionTrabajo>>> GetAplicacionTrabajo()
            {
                return await _baseDatos.AplicacionTrabajos.ToListAsync();
            }
            // GET: api/AplicacionTrabajo/1
            [HttpGet("{Id}")]
            public async Task<ActionResult<AplicacionTrabajo>> GetAplicacionTrabajo(long id)
            {
                var aplicacion = await _baseDatos.AplicacionTrabajos.FirstOrDefaultAsync(q => q.Idaplicacion == id);

                if (aplicacion == null)
                {
                    return NotFound();
                }
                return aplicacion;
            }

            //POST: api/AplicacionTrabajo
            [HttpPost]
            public async Task<ActionResult<AplicacionTrabajo>> PostAplicacionTrabajo(AplicacionTrabajo item)
            {
                /*var respuesta = await _usuarioAppServices.RegistrarUsuario(item);
                if (respuesta == null)
                {
                    return CreatedAtAction(nameof(GetUsuario), new { Id = item.Id }, item);
                }*/
                return null;
            }

            //POST Rango: api/AplicacionTrabajo
            [HttpPost("rango")]

            public async Task<ActionResult<AplicacionTrabajo>> PostAplicacionTrabajo(IEnumerable<AplicacionTrabajo> items)
            {
                _baseDatos.AplicacionTrabajos.AddRange(items);
                await _baseDatos.SaveChangesAsync();

                return CreatedAtAction(nameof(GetAplicacionTrabajo), items);
            }

            //PUT: api/AplicacionTrabajo/1
            [HttpPut("{Id}")]

            public async Task<ActionResult> PostAplicacionTrabajo(int id, AplicacionTrabajo item)
            {
                if (id != item.Idaplicacion)
                {
                    return BadRequest();
                }

                Usuario usuario = await _baseDatos.Usuarios.FirstOrDefaultAsync(q => q.Idusuario == item.IdUsuario);
                if (usuario == null)
                {
                    return NotFound("La empresa no existe");
                }

                PublicacionTrabajo publicacion = await _baseDatos.PublicacionTrabajos.FirstOrDefaultAsync(q => q.IdPropuesta == item.IdPublicacionTrabajo);
                if (publicacion == null)
                {
                    return NotFound("La empresa no existe");
                }

                _baseDatos.Entry(item).State = EntityState.Modified;
                await _baseDatos.SaveChangesAsync();
                return NoContent();
            }

            // Delete: api/AplicacionTrabajo/1
            [HttpDelete("{Id}")]
            public async Task<ActionResult> DeleteAplicacionTrabajo(int id)
            {
                var aplicacion = await _baseDatos.AplicacionTrabajos.FindAsync(id);

                if (aplicacion == null)
                {
                    return NotFound();
                }
                _baseDatos.AplicacionTrabajos.Remove(aplicacion);
                await _baseDatos.SaveChangesAsync();

                return NoContent();
            }

            //Delete Rango: api/AplicacionTrabajo/1
            [HttpDelete("rango")]

            public async Task<ActionResult> DeleteAplicacionTrabajo(IEnumerable<int> ids)
            {
                IEnumerable<AplicacionTrabajo> aplicacions = _baseDatos.AplicacionTrabajos.Where(q => ids.Contains(q.Idaplicacion));

                if (aplicacions == null)
                {
                    return NotFound();
                }

                _baseDatos.AplicacionTrabajos.RemoveRange(aplicacions);
                await _baseDatos.SaveChangesAsync();

                return NoContent();
            }
        }
    }
}