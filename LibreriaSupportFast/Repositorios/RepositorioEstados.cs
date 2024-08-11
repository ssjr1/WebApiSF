using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioEstados: IRepositorioEstados
    {
        private readonly ApplicationDbContext _context;

        public RepositorioEstados(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearEstado(Estados estado)
        {
            await _context.Estados.AddAsync(estado);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarEstado(Estados estado)
        {
            _context.Estados.Update(estado);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Estados>> ListadoEstados()
        {
            return await _context.Estados.ToListAsync();
        }

        public async Task EliminarEstado(int id)
        {
            var Estado = await _context.Estados.FindAsync(id);
            if (Estado != null)
            {
                _context.Estados.Remove(Estado);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Estados> ObtenerEstadoPorId(int id)
        {
            return await _context.Estados.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
