using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using static LibreriaSupportFast.Repositorios.RepositorioSubCategorias;

namespace WebApiSupportFast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly IRepositorioCategorias _repositorioCategoria;

        public CategoriaController(IRepositorioCategorias repositorioCategoria)
        {
            _repositorioCategoria = repositorioCategoria;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categorias>>> GetCategorias()
        {
            var Categorias = await _repositorioCategoria.ListadoCategorias();
            return Ok(Categorias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Categorias>> GetCategoria(int id)
        {
            var Categoria = await _repositorioCategoria.ObtenerCategoriaPorId(id);

            if (Categoria == null)
            {
                return NotFound();
            }

            return Ok(Categoria);
        }

        [HttpPost]
        public async Task<ActionResult<Categorias>> PostCategoria(Categorias Categoria)
        {
            try
            {
                var id = await _repositorioCategoria.CrearCategoria(Categoria);
                return Ok(id);

            }
            catch (Exception ex)
            {

                return BadRequest(ex.ToString());
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoria(int id, Categorias Categoria)
        {
            if (id != Categoria.Id)
            {
                return BadRequest();
            }

            await _repositorioCategoria.ModificarCategoria(Categoria);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoria(int id)
        {
            var Categoria = await _repositorioCategoria.ObtenerCategoriaPorId(id);

            if (Categoria == null)
            {
                return NotFound();
            }

            await _repositorioCategoria.EliminarCategoria(id);

            return NoContent();
        }
    }
}