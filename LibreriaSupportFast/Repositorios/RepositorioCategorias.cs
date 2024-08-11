using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        private readonly ApplicationDbContext _context;

        public RepositorioCategorias(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearCategoria(Categorias Categoria)
        {
            await _context.Categorias.AddAsync(Categoria);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarCategoria(Categorias Categoria)
        {
            _context.Categorias.Update(Categoria);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Categorias>> ListadoCategorias()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task EliminarCategoria(int id)
        {
            var Categoria = await _context.Categorias.FindAsync(id);
            if (Categoria != null)
            {
                _context.Categorias.Remove(Categoria);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Categorias> ObtenerCategoriaPorId(int id)
        {
            return await _context.Categorias.FirstOrDefaultAsync(a => a.Id == id);
        }
    }
}
