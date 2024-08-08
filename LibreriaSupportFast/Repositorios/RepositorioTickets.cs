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
                return tickets.id;
            }
            public async Task<int> modificarTicket(Tickets tickets)
            {
                Tickets tic = await context.Tickets.FindAsync(tickets.id);
                tic.id = tickets.id;
                tic.c_Descripcion = tickets.c_Descripcion;
                tic.id_categoria = tickets.id_categoria;
                tic.id_subcategoria = tickets.id_subcategoria;
                tic.id_tecnico_asignado = tickets.id_tecnico_asignado;
                tic.id_solucion = tickets.id_solucion;
                tic.id_estado = tickets.id_estado;
                tic.f_fecha_creacion = tickets.f_fecha_creacion;
                tic.f_fecha_Ultima_Gestion = tickets.f_fecha_Ultima_Gestion;
                tic.f_fecha_cierre = tickets.f_fecha_cierre;

                await context.SaveChangesAsync();
                return tickets.id;
            }
            public Task<List<Tickets>> listadoTickets()
            {
                return context.Tickets.ToListAsync();
            }
            async Task eliminarTickets(int id)
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
