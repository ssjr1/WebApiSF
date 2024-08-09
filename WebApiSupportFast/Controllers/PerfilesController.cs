using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiSupportFast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilController : ControllerBase
    {
        private readonly IRepositorioPerfiles _repositorioPerfil;

        public PerfilController(IRepositorioPerfiles repositorioPerfil)
        {
            _repositorioPerfil = repositorioPerfil;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perfiles>>> GetPerfiles()
        {
            var Perfiles = await _repositorioPerfil.ListadoPerfiles();
            return Ok(Perfiles);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Perfiles>> GetPerfil(int id)
        {
            var Perfil = await _repositorioPerfil.ObtenerPerfilPorId(id);

            if (Perfil == null)
            {
                return NotFound();
            }

            return Ok(Perfil);
        }

        [HttpPost]
        public async Task<ActionResult<Perfiles>> PostPerfil(Perfiles Perfil)
        {
            var id = await _repositorioPerfil.CrearPerfil(Perfil);
            return CreatedAtAction(nameof(GetPerfil), new { id = id }, Perfil);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerfil(int id, Perfiles Perfil)
        {
            if (id != Perfil.Id)
            {
                return BadRequest();
            }

            await _repositorioPerfil.ModificarPerfil(Perfil);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerfil(int id)
        {
            var Perfil = await _repositorioPerfil.ObtenerPerfilPorId(id);

            if (Perfil == null)
            {
                return NotFound();
            }

            await _repositorioPerfil.EliminarPerfil(id);

            return NoContent();
        }
    }
}