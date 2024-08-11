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
    public class AreaController : ControllerBase
    {
        private readonly IRepositorioAreas _repositorioArea;

        public AreaController(IRepositorioAreas repositorioArea)
        {
            _repositorioArea = repositorioArea;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Areas>>> GetAreas()
        {
            var Areas = await _repositorioArea.ListadoAreas();
            return Ok(Areas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Areas>> GetArea(int id)
        {
            var Area = await _repositorioArea.ObtenerAreaPorId(id);

            if (Area == null)
            {
                return NotFound();
            }

            return Ok(Area);
        }

        [HttpPost]
        public async Task<ActionResult<Areas>> PostArea(Areas Area)
        {
            var id = await _repositorioArea.CrearArea(Area);
            return CreatedAtAction(nameof(GetArea), new { id = id }, Area);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutArea(int id, Areas Area)
        {
            if (id != Area.Id)
            {
                return BadRequest();
            }

            await _repositorioArea.ModificarArea(Area);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArea(int id)
        {
            var Area = await _repositorioArea.ObtenerAreaPorId(id);

            if (Area == null)
            {
                return NotFound();
            }

            await _repositorioArea.EliminarArea(id);

            return NoContent();
        }
    }
}