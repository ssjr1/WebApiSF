using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioPerfiles : IRepositorioPerfiles
    {
        private readonly ApplicationDbContext _context;

        public RepositorioPerfiles(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearPerfil(Perfiles Perfil)
        {
            await _context.Perfiles.AddAsync(Perfil);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarPerfil(Perfiles Perfil)
        {
            _context.Perfiles.Update(Perfil);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Perfiles>> ListadoPerfiles()
        {
            return await _context.Perfiles.ToListAsync();
        }

        public async Task EliminarPerfil(int id)
        {
            var Perfil = await _context.Perfiles.FindAsync(id);
            if (Perfil != null)
            {
                _context.Perfiles.Remove(Perfil);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Perfiles> ObtenerPerfilPorId(int id)
        {
            return await _context.Perfiles.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
