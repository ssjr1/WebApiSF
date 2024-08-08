using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioAreas : IRepositorioAreas
    {
        private readonly ApplicationDbContext _context;

        public RepositorioAreas(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearArea(Areas area)
        {
            await _context.Areas.AddAsync(area);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarArea(Areas area)
        {
            _context.Areas.Update(area);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Areas>> ListadoAreas()
        {
            return await _context.Areas.ToListAsync();
        }

        public async Task EliminarArea(int id)
        {
            var area = await _context.Areas.FindAsync(id);
            if (area != null)
            {
                _context.Areas.Remove(area);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Areas> ObtenerAreaPorId(int id)
        {
            return await _context.Areas.FirstOrDefaultAsync(a => a.id == id);
        }
    }
}
