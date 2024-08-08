using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioCiudades : IRepositorioCiudades
    {
        private readonly ApplicationDbContext _context;

        public RepositorioCiudades(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearCiudad(Ciudades ciudad)
        {
            await _context.Ciudades.AddAsync(ciudad);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarCiudad(Ciudades ciudad)
        {
            _context.Ciudades.Update(ciudad);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Ciudades>> ListadoCiudades()
        {
            return await _context.Ciudades.ToListAsync();
        }

        public async Task EliminarCiudad(int id)
        {
            var ciudad = await _context.Ciudades.FindAsync(id);
            if (ciudad != null)
            {
                _context.Ciudades.Remove(ciudad);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Ciudades> ObtenerCiudadPorId(int id)
        {
            return await _context.Ciudades.FirstOrDefaultAsync(c => c.id == id);
        }
    }
}
