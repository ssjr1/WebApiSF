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
    public class UsuarioController : ControllerBase
    {
        private readonly IRepositorioUsuarios _repositorioUsuario;

        public UsuarioController(IRepositorioUsuarios repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuarios>>> GetUsuarios()
        {
            var Usuarios = await _repositorioUsuario.ListadoUsuarios();
            return Ok(Usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuarios>> GetUsuario(int id)
        {
            var Usuario = await _repositorioUsuario.ObtenerUsuarioPorId(id);

            if (Usuario == null)
            {
                return NotFound();
            }

            return Ok(Usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuarios>> PostUsuario(Usuarios Usuario)
        {
            var id = await _repositorioUsuario.CrearUsuario(Usuario);
            return CreatedAtAction(nameof(GetUsuario), new { id = id }, Usuario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuario(int id, Usuarios Usuario)
        {
            if (id != Usuario.Id)
            {
                return BadRequest();
            }

            await _repositorioUsuario.ModificarUsuario(Usuario);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var Usuario = await _repositorioUsuario.ObtenerUsuarioPorId(id);

            if (Usuario == null)
            {
                return NotFound();
            }

            await _repositorioUsuario.EliminarUsuario(id);

            return NoContent();
        }
    }
}