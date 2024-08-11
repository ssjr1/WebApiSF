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
    public class SolucionController : ControllerBase
    {
        private readonly IRepositorioSoluciones _repositorioSolucion;

        public SolucionController(IRepositorioSoluciones repositorioSolucion)
        {
            _repositorioSolucion = repositorioSolucion;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Soluciones>>> GetSoluciones()
        {
            var Soluciones = await _repositorioSolucion.ListadoSoluciones();
            return Ok(Soluciones);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Soluciones>> GetSolucion(int id)
        {
            var Solucion = await _repositorioSolucion.ObtenerSolucionPorId(id);

            if (Solucion == null)
            {
                return NotFound();
            }

            return Ok(Solucion);
        }

        [HttpPost]
        public async Task<ActionResult<Soluciones>> PostSolucion(Soluciones Solucion)
        {
            var id = await _repositorioSolucion.CrearSolucion(Solucion);
            return CreatedAtAction(nameof(GetSolucion), new { id = id }, Solucion);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSolucion(int id, Soluciones Solucion)
        {
            if (id != Solucion.Id)
            {
                return BadRequest();
            }

            await _repositorioSolucion.ModificarSolucion(Solucion);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSolucion(int id)
        {
            var Solucion = await _repositorioSolucion.ObtenerSolucionPorId(id);

            if (Solucion == null)
            {
                return NotFound();
            }

            await _repositorioSolucion.EliminarSolucion(id);

            return NoContent();
        }
    }
}