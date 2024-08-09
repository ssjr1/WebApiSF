using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioUsuarios : IRepositorioUsuarios
    {
        private readonly ApplicationDbContext _context;

        public RepositorioUsuarios(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearUsuario(Usuarios Usuario)
        {
            await _context.Usuarios.AddAsync(Usuario);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarUsuario(Usuarios Usuario)
        {
            _context.Usuarios.Update(Usuario);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Usuarios>> ListadoUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task EliminarUsuario(int id)
        {
            var Usuario = await _context.Usuarios.FindAsync(id);
            if (Usuario != null)
            {
                _context.Usuarios.Remove(Usuario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Usuarios> ObtenerUsuarioPorId(int id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
