using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectWebAppEF.Context;
using ProyectWebAppEF.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProyectWebAppEF.Controllers
{ [Route("api/[Controller]")]
    [ApiController]
    public class EducacionController : ControllerBase
    {
        private readonly ProyectoDataContext _baseDatos;
       [HttpGet]
       public async Task<ActionResult<EducacionUsuario>> GetEducacionUsuario(long id)
        {
            var educacion = await _baseDatos.EducacionUsuarios.FirstOrDefaultAsync(e => e.IdEducacion == id);
           
            if (educacion == null)
            {
                return NotFound();
            }
            return educacion;
        }
        [HttpPost]
        public async Task<ActionResult<EducacionUsuario>> PostEducacionUsuario(EducacionUsuario item)
        {
            _baseDatos.EducacionUsuarios.Add(item);
            await _baseDatos.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEducacionUsuario), new { Id = item.IdEducacion }, item);
        }

        //POST Rango: api/Empresa
        [HttpPost("rango")]

        public async Task<ActionResult<Empresa>> PostEducacionUsuario(IEnumerable<EducacionUsuario> items)
        {
            _baseDatos.EducacionUsuarios.AddRange(items);
            await _baseDatos.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEducacionUsuario), items);
        }

        //PUT: api/Empresa/1
        [HttpPut("{Id}")]

        public async Task<ActionResult> PostEducacionUsuari(int id, EducacionUsuario item)
        {
            if (id != item.IdEducacion)
            {
                return BadRequest();
            }
            //PublicacionTrabajo publicacion = await _baseDatos.PublicacionTrabajos.FirstOrDefaultAsync(q => q.IdEmpresa == item.);
            //if (educacion == null)
            //{
            //    return NotFound("El curso no existe");
            //}

            _baseDatos.Entry(item).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();
            return NoContent();
        }

        // Delete: api/Empresa/1
        [HttpDelete("{Id}")]
        public async Task<ActionResult> DeleteEducacionUsuario(int id)
        {
            var educacion = await _baseDatos.EducacionUsuarios.FindAsync(id);

            if (educacion == null)
            {
                return NotFound();
            }
            _baseDatos.EducacionUsuarios.Remove(educacion);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }

        //Delete Rango: api/Empresa/1
        [HttpDelete("rango")]

        public async Task<ActionResult> DeleteEducacionUsuario(IEnumerable<int> ids)
        {
            IEnumerable<EducacionUsuario> educacionUsuarios = _baseDatos.EducacionUsuarios.Where(q => ids.Contains(q.IdEducacion));

            if (educacionUsuarios == null)
            {
                return NotFound();
            }

            _baseDatos.EducacionUsuarios.RemoveRange(educacionUsuarios);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }
    }
}
