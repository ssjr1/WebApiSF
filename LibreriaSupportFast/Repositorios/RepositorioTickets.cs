using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioTickets : IRepositorioTickets
    {
        private readonly ApplicationDbContext _context;

        public RepositorioTickets(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> CrearTicket(Tickets Ticket)
        {
            await _context.Tickets.AddAsync(Ticket);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> ModificarTicket(Tickets Ticket)
        {
            _context.Tickets.Update(Ticket);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<Tickets>> ListadoTickets()
        {
            return await _context.Tickets.ToListAsync();
        }

        public async Task EliminarTicket(int id)
        {
            var Ticket = await _context.Tickets.FindAsync(id);
            if (Ticket != null)
            {
                _context.Tickets.Remove(Ticket);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Tickets> ObtenerTicketPorId(int id)
        {
            return await _context.Tickets.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
