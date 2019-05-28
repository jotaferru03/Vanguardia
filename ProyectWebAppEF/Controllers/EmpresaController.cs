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
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        // GET: /<controller>/
        private readonly ProyectoDataContext _baseDatos;
        //private readonly UsurioAppServices _usuarioAppServices;
        //public EmpresaController(ProyectoDataContext context, UsurioAppServices usuarioAppServices)
        //{
        //    _baseDatos = context;
        //    _usuarioAppServices = usuarioAppServices;

        //    if (_baseDatos.Usuarios.Count() == 1)
        //    {
        //        _baseDatos.Usuarios.Add(new Usuario
        //        {
        //            PrimerNombre = "Jordan",
        //            PrimerApellido = "Ferrufino",
        //            Cuidad = "San Pedro Sula",
        //            Direccion = "Colonia Las Universidades",
        //            Telefono = 87741883,
        //            Correo = "jota.ferru3@gmail.com",
        //            Contrasenia = "Contrasenia"
        //        });
        //        _baseDatos.SaveChanges();
        //    }
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empresa>>> GetEmpresa()
        {
            return await _baseDatos.Empresas.ToListAsync();
        }
        [HttpGet("{Id}")]
        public async Task<ActionResult<Usuario>> GetUsuario(long id)
        {
            var usuario = await _baseDatos.Usuarios.FirstOrDefaultAsync(q => q.Idusuario == id);

            if (usuario == null)
            {
                return NotFound();
            }
            return usuario;
        }

        //POST: api/Empresa
        [HttpPost]
        public async Task<ActionResult<Empresa>> PostEmpresa(Empresa item)
        {
            _baseDatos.Empresas.Add(item);
            await _baseDatos.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmpresa), new { Id = item.Idempresa }, item);
        }

        //POST Rango: api/Empresa
        [HttpPost("rango")]

        public async Task<ActionResult<Empresa>> PostEmpresa(IEnumerable<Empresa> items)
        {
            _baseDatos.Empresas.AddRange(items);
            await _baseDatos.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmpresa), items);
        }

        //PUT: api/Empresa/1
        [HttpPut("{Id}")]

        public async Task<ActionResult> PostEmpresa(int id, Empresa item)
        {
            if (id != item.Idempresa)
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
        public async Task<ActionResult> DeleteEmpresa(int id)
        {
            var empresa = await _baseDatos.Empresas.FindAsync(id);

            if (empresa == null)
            {
                return NotFound();
            }
            _baseDatos.Empresas.Remove(empresa);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }

        //Delete Rango: api/Empresa/1
        [HttpDelete("rango")]

        public async Task<ActionResult> DeleteEstudiante(IEnumerable<int> ids)
        {
            IEnumerable<Empresa> empresas = _baseDatos.Empresas.Where(q => ids.Contains(q.Idempresa));

            if (empresas == null)
            {
                return NotFound();
            }

            _baseDatos.Empresas.RemoveRange(empresas);
            await _baseDatos.SaveChangesAsync();

            return NoContent();
        }
    }
}
