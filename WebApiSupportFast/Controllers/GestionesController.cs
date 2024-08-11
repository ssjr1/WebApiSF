using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiSupportFast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GestionesController : ControllerBase
    {
        private readonly IRepositorioGestiones _repositorioGestiones;

        public GestionesController(IRepositorioGestiones repositorioGestiones)
        {
            _repositorioGestiones = repositorioGestiones;
        }

        // GET: api/Gestiones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gestiones>>> GetGestiones()
        {
            var gestiones = await _repositorioGestiones.ListadoGestiones();
            return Ok(gestiones);
        }

        // GET: api/Gestiones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Gestiones>> GetGestion(int id)
        {
            var gestion = await _repositorioGestiones.ObtenerGestionPorId(id);

            if (gestion == null)
            {
                return NotFound();
            }

            return Ok(gestion);
        }

        // POST: api/Gestiones
        [HttpPost]
        public async Task<ActionResult<Gestiones>> PostGestion(Gestiones gestion)
        {
            await _repositorioGestiones.CrearGestion(gestion);
            return CreatedAtAction(nameof(GetGestion), new { id = gestion.Id }, gestion);
        }

        // PUT: api/Gestiones/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGestion(int id, Gestiones gestion)
        {
            if (id != gestion.Id)
            {
                return BadRequest();
            }

            await _repositorioGestiones.ModificarGestion(gestion);
            return NoContent();
        }

        // DELETE: api/Gestiones/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGestion(int id)
        {
            await _repositorioGestiones.EliminarGestion(id);
            return NoContent();
        }
    }
}
