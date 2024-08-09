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
    public class TecnicoController : ControllerBase
    {
        private readonly IRepositorioTecnico _repositorioTecnico;

        public TecnicoController(IRepositorioTecnico repositorioTecnico)
        {
            _repositorioTecnico = repositorioTecnico;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tecnicos>>> GetTecnicos()
        {
            var tecnicos = await _repositorioTecnico.listadoTecnicos();
            return Ok(tecnicos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tecnicos>> GetTecnico(int id)
        {
            var tecnico = await _repositorioTecnico.obtenerTecnicoPorId(id);

            if (tecnico == null)
            {
                return NotFound();
            }

            return Ok(tecnico);
        }

        [HttpPost]
        public async Task<ActionResult<Tecnicos>> PostTecnico(Tecnicos tecnico)
        {
            var id = await _repositorioTecnico.crearTecnico(tecnico);
            return CreatedAtAction(nameof(GetTecnico), new { id = id }, tecnico);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTecnico(int id, Tecnicos tecnico)
        {
            if (id != tecnico.Id)
            {
                return BadRequest();
            }

            await _repositorioTecnico.modificarTecnico(tecnico);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTecnico(int id)
        {
            var tecnico = await _repositorioTecnico.obtenerTecnicoPorId(id);

            if (tecnico == null)
            {
                return NotFound();
            }

            await _repositorioTecnico.eliminarTecnico(id);

            return NoContent();
        }
    }
}