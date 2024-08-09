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
    public class CiudadController : ControllerBase
    {
        private readonly IRepositorioCiudades _repositorioCiudad;

        public CiudadController(IRepositorioCiudades repositorioCiudad)
        {
            _repositorioCiudad = repositorioCiudad;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciudades>>> GetCiudades()
        {
            var Ciudades = await _repositorioCiudad.ListadoCiudades();
            return Ok(Ciudades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudades>> GetCiudad(int id)
        {
            var Ciudad = await _repositorioCiudad.ObtenerCiudadPorId(id);

            if (Ciudad == null)
            {
                return NotFound();
            }

            return Ok(Ciudad);
        }

        [HttpPost]
        public async Task<ActionResult<Ciudades>> PostCiudad(Ciudades Ciudad)
        {
            var id = await _repositorioCiudad.CrearCiudad(Ciudad);
            return CreatedAtAction(nameof(GetCiudad), new { id = id }, Ciudad);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudad(int id, Ciudades Ciudad)
        {
            if (id != Ciudad.Id)
            {
                return BadRequest();
            }

            await _repositorioCiudad.ModificarCiudad(Ciudad);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCiudad(int id)
        {
            var Ciudad = await _repositorioCiudad.ObtenerCiudadPorId(id);

            if (Ciudad == null)
            {
                return NotFound();
            }

            await _repositorioCiudad.EliminarCiudad(id);

            return NoContent();
        }
    }
}