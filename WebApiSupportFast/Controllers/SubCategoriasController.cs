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
    public class SubCategoriasController : ControllerBase
    {
        private readonly IRepositorioSubCategorias _repositorioSubCategoria;

        public SubCategoriasController (IRepositorioSubCategorias repositorioSubCategoria)
        {
            _repositorioSubCategoria = repositorioSubCategoria;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubCategorias>>> GetSubCategoria()
        {
            var subCategorias = await _repositorioSubCategoria.listadoSubCategorias();
            return Ok(subCategorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategorias>> GetSubCategoria(int id)
        {
            var subCategoria = await _repositorioSubCategoria.obtenerSubCategoriaPorId(id);

            if (subCategoria == null)
            {
                return NotFound();
            }

            return Ok(subCategoria);
        }

        [HttpPost]
        public async Task<ActionResult<SubCategorias>> PostSubCategoria(SubCategorias subCategorias)
        {
            var id = await _repositorioSubCategoria.crearSubCategoria(subCategorias);
            return CreatedAtAction(nameof(GetSubCategoria), new { id = id }, subCategorias);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubcategoria(int id, SubCategorias subCategorias)
        {
            if (id != subCategorias.Id)
            {
                return BadRequest();
            }

            await _repositorioSubCategoria.modificarSubCategorias(subCategorias);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubCategoria(int id)
        {
            var subCategoria = await _repositorioSubCategoria.obtenerSubCategoriaPorId(id);

            if (subCategoria == null)
            {
                return NotFound();
            }

            await _repositorioSubCategoria.eliminarSubCategoria(id);

            return NoContent();
        }
    }
}