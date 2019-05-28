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
    public class PublicacionController
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

                if (_baseDatos.PublicacionTrabajos.Count() == 1)
                {
                    _baseDatos.PublicacionTrabajos.Add(new PublicacionTrabajo
                    {
                        PuestoTrabajo = "Ingeniero en Redes",
                        Descripcion = "Se Busca un ingeniero en redes que conosca sobre wan",
                        IdPropuesta = 1
                    });
                    _baseDatos.SaveChanges();
                }
            }
            // GET: api/Usuario
            [HttpGet]
            public async Task<ActionResult<IEnumerable<PublicacionTrabajo>>> GetPublicacionTrabajo()
            {
                return await _baseDatos.PublicacionTrabajos.ToListAsync();
            }
            // GET: api/PublicacionTrabajo/1
            [HttpGet("{Id}")]
            public async Task<ActionResult<PublicacionTrabajo>> GetPublicacionTrabajo(long id)
            {
                var publicacion = await _baseDatos.PublicacionTrabajos.FirstOrDefaultAsync(q => q.IdPropuesta == id);

                if (publicacion == null)
                {
                    return NotFound();
                }
                return publicacion;
            }

            //POST: api/PublicacionTrabajo
            [HttpPost]
            public async Task<ActionResult<PublicacionTrabajo>> PostPublicacion(PublicacionTrabajo item)
            {
                /*var respuesta = await _usuarioAppServices.RegistrarUsuario(item);
                if (respuesta == null)
                {
                    return CreatedAtAction(nameof(GetUsuario), new { Id = item.Id }, item);
                }*/
                return null;
            }

            //POST Rango: api/PublicacionTrabajo
            [HttpPost("rango")]

            public async Task<ActionResult<PublicacionTrabajo>> PostPublicacionTrabajo(IEnumerable<PublicacionTrabajo> items)
            {
                _baseDatos.PublicacionTrabajos.AddRange(items);
                await _baseDatos.SaveChangesAsync();

                return CreatedAtAction(nameof(GetPublicacionTrabajo), items);
            }

            //PUT: api/PublicacionTrabajo/1
            [HttpPut("{Id}")]

            public async Task<ActionResult> PostPublicacionTrabajo(int id, PublicacionTrabajo item)
            {
                if (id != item.IdPropuesta)
                {
                    return BadRequest();
                }

                Empresa empresa = await _baseDatos.Empresas.FirstOrDefaultAsync(q => q.Idempresa == item.IdEmpresa);
                if (empresa == null)
                {
                    return NotFound("La empresa no existe");
                }

                _baseDatos.Entry(item).State = EntityState.Modified;
                await _baseDatos.SaveChangesAsync();
                return NoContent();
            }

            // Delete: api/PublicacionTrabajo/1
            [HttpDelete("{Id}")]
            public async Task<ActionResult> DeletePublicacionTrabajo(int id)
            {
                var publicacion = await _baseDatos.PublicacionTrabajos.FindAsync(id);

                if (publicacion == null)
                {
                    return NotFound();
                }
                _baseDatos.PublicacionTrabajos.Remove(publicacion);
                await _baseDatos.SaveChangesAsync();

                return NoContent();
            }

            //Delete Rango: api/PublicacionTrabajo/1
            [HttpDelete("rango")]

            public async Task<ActionResult> DeletePublicacionTrabajo(IEnumerable<int> ids)
            {
                IEnumerable<PublicacionTrabajo> publicacions = _baseDatos.PublicacionTrabajos.Where(q => ids.Contains(q.IdPropuesta));

                if (publicacions == null)
                {
                    return NotFound();
                }

                _baseDatos.PublicacionTrabajos.RemoveRange(publicacions);
                await _baseDatos.SaveChangesAsync();

                return NoContent();
            }
        }
    }
}