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
        Task<int> CrearTicket(Tickets tickets);
        Task<int> ModificarTicket(Tickets tickets);
        Task<List<Tickets>> ListadoTickets();
        Task EliminarTicket(int id);
        Task<Tickets> ObtenerTicketPorId(int id);
    }
}
