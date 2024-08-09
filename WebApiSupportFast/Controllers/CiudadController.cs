using LibreriaSupportFast.Repositorios;
using LibreriaSupportFast.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            var ciudades = await _repositorioCiudad.ListadoCiudades();
            return Ok(ciudades);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ciudades>> GetCiudadId(int id)
        {
            var ciudad = await _repositorioCiudad.ObtenerCiudadPorId(id);

            if (ciudad == null)
            {
                return NotFound();
            }

            return Ok(ciudad);
        }

        [HttpPost]
        public async Task<IActionResult> PostCiudad(Ciudades ciudad)
        {
            try
            {
                var ListCiudades = await _repositorioCiudad.CrearCiudad(ciudad);
                return Ok(ListCiudades);

            }
            catch (Exception ex) { return BadRequest(ex.Message); }

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiudad(int id, Ciudades ciudad)
        {
            if (id != ciudad.id)
            {
                return BadRequest();
            }

            await _repositorioCiudad.ModificarCiudad(ciudad);

            return NoContent();
        }
    }
}
