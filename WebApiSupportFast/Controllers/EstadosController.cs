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
    public class EstadoController : ControllerBase
    {
        private readonly IRepositorioEstados _repositorioEstado;

        public EstadoController(IRepositorioEstados repositorioEstado)
        {
            _repositorioEstado = repositorioEstado;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Estados>>> GetEstados()
        {
            var Estados = await _repositorioEstado.ListadoEstados();
            return Ok(Estados);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Estados>> GetEstado(int id)
        {
            var Estado = await _repositorioEstado.ObtenerEstadoPorId(id);

            if (Estado == null)
            {
                return NotFound();
            }

            return Ok(Estado);
        }

        [HttpPost]
        public async Task<ActionResult<Estados>> PostEstado(Estados Estado)
        {
            var id = await _repositorioEstado.CrearEstado(Estado);
            return CreatedAtAction(nameof(GetEstado), new { id = id }, Estado);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstado(int id, Estados Estado)
        {
            if (id != Estado.Id)
            {
                return BadRequest();
            }

            await _repositorioEstado.ModificarEstado(Estado);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstado(int id)
        {
            var Estado = await _repositorioEstado.ObtenerEstadoPorId(id);

            if (Estado == null)
            {
                return NotFound();
            }

            await _repositorioEstado.EliminarEstado(id);

            return NoContent();
        }
    }
}