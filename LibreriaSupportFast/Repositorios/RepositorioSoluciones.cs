using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioSoluciones : IRepositorioSoluciones
    {
        private readonly ApplicationDbContext _context;

        public RepositorioSoluciones(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearSolucion(Soluciones Solucion)
        {
            await _context.Soluciones.AddAsync(Solucion);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarSolucion(Soluciones Solucion)
        {
            _context.Soluciones.Update(Solucion);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Soluciones>> ListadoSoluciones()
        {
            return await _context.Soluciones.ToListAsync();
        }

        public async Task EliminarSolucion(int id)
        {
            var Solucion = await _context.Soluciones.FindAsync(id);
            if (Solucion != null)
            {
                _context.Soluciones.Remove(Solucion);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Soluciones> ObtenerSolucionPorId(int id)
        {
            return await _context.Soluciones.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
