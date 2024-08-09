using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioGestiones : IRepositorioGestiones
    {
        private readonly ApplicationDbContext _context;

        public RepositorioGestiones(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearGestion(Gestiones gestion)
        {
            await _context.Gestiones.AddAsync(gestion);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarGestion(Gestiones gestion)
        {
            _context.Gestiones.Update(gestion);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Gestiones>> ListadoGestiones()
        {
            return await _context.Gestiones
                .Include(g => g.Id_Ticket)
                .Include(g => g.Categorias)
<<<<<<< HEAD
                .Include(g => g.Id_SubCategoria)
=======
                .Include(g => g.Id_subcategoria)
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac
                .Include(g => g.Id_tecnico_asignado)
                .Include(g => g.Soluciones)
                .Include(g => g.Estados)
                .ToListAsync();
        }

        public async Task EliminarGestion(int id)
        {
            var gestion = await _context.Gestiones.FindAsync(id);
            if (gestion != null)
            {
                _context.Gestiones.Remove(gestion);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Gestiones> ObtenerGestionPorId(int id)
        {
            return await _context.Gestiones
                .Include(g => g.Id_Ticket)
                .Include(g => g.Categorias)
<<<<<<< HEAD
                .Include(g => g.Id_SubCategoria)
=======
                .Include(g => g.Id_subcategoria)
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac
                .Include(g => g.Id_tecnico_asignado)
                .Include(g => g.Soluciones)
                .Include(g => g.Estados)
                .FirstOrDefaultAsync(g => g.Id == id);
        }
    }
}
