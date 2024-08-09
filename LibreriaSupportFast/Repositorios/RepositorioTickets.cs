using LibreriaSupportFast.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public class RepositorioTickets
    {
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
            {
                return context.Tickets.ToListAsync();
            }
            public async Task eliminarTicket(int id)
            {
                Tickets tickets= await context.Tickets.FindAsync(id);
                context.Tickets.Remove(tickets);
                await context.SaveChangesAsync();
            }
            public async Task<Tickets> obtenerTicketPorId(int id)
            {
                return await context.Tickets.FindAsync(id);
            }
        }

    }
}
