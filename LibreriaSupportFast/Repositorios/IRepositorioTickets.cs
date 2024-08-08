using LibreriaSupportFast.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaSupportFast.Repositorios
{
    public interface IRepositorioTickets
    {
        Task<int> crearTicket(Tickets tickets);
        Task<int> modificarTicket(Tickets tickets);
        Task<List<Tickets>> listadoTickets();
        Task eliminarTicket(int id);
        Task<Tickets> obtenerTicketPorId(int id);
    }
}
