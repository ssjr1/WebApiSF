using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioTickets : IRepositorioTickets
    {
<<<<<<< HEAD
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
=======
        public class RepositorioTicket : IRepositorioTickets
        {
            private readonly ApplicationDbContext context;
            public RepositorioTicket(ApplicationDbContext context)
            {
                this.context = context;
            }
            public async Task<int> crearTicket(Tickets tickets)
            {
                context.Tickets.Add(tickets);
                await context.SaveChangesAsync();
                return tickets.Id;
            }
            public async Task<int> modificarTicket(Tickets tickets)
            {
                Tickets tic = await context.Tickets.FindAsync(tickets.Id);
                tic.Id = tickets.Id;
                tic.C_Descripcion = tickets.C_Descripcion;
                tic.Id_categoria = tickets.Id_categoria;
                tic.Id_SubCategoria = tickets.Id_SubCategoria;
                tic.Id_tecnico_asignado = tickets.Id_tecnico_asignado;
                tic.Id_solucion = tickets.Id_solucion;
                tic.Id_estado = tickets.Id_estado;
                tic.F_fecha_creacion = tickets.F_fecha_creacion;
                tic.F_fecha_Ultima_Gestion = tickets.F_fecha_Ultima_Gestion;
                tic.F_fecha_cierre = tickets.F_fecha_cierre;

                await context.SaveChangesAsync();
                return tickets.Id;
            }
            public Task<List<Tickets>> listadoTickets()
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac
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
