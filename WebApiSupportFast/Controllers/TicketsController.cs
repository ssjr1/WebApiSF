using LibreriaSupportFast.Models;
using LibreriaSupportFast.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiSupportFast.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly IRepositorioTickets _repositorioTicket;

        public TicketsController(IRepositorioTickets repositorioTicket)
        {
            _repositorioTicket = repositorioTicket;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tickets>>> GetTicket()
        {
<<<<<<< HEAD
            var Tickets = await _repositorioTicket.ListadoTickets();
=======
            var Tickets = await _repositorioTicket.listadoTickets();
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac
            return Ok(Tickets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tickets>> GetTicket(int id)
        {
<<<<<<< HEAD
            var Ticket = await _repositorioTicket.ObtenerTicketPorId(id);
=======
            var Ticket = await _repositorioTicket.obtenerTicketPorId(id);
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac

            if (Ticket == null)
            {
                return NotFound();
            }

            return Ok(Ticket);
        }

        [HttpPost]
        public async Task<ActionResult<Tickets>> PostTicket(Tickets Tickets)
        {
<<<<<<< HEAD
            var id = await _repositorioTicket.CrearTicket(Tickets);
            return Ok(id);
=======
            var id = await _repositorioTicket.crearTicket(Tickets);
            return CreatedAtAction(nameof(GetTicket), new { id = id }, Tickets);
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Tickets Tickets)
        {
            if (id != Tickets.Id)
            {
                return BadRequest();
            }

<<<<<<< HEAD
            await _repositorioTicket.ModificarTicket(Tickets);
=======
            await _repositorioTicket.modificarTicket(Tickets);
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
<<<<<<< HEAD
            var Ticket = await _repositorioTicket.ObtenerTicketPorId(id);
=======
            var Ticket = await _repositorioTicket.obtenerTicketPorId(id);
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac

            if (Ticket == null)
            {
                return NotFound();
            }

<<<<<<< HEAD
            await _repositorioTicket.EliminarTicket(id);
=======
            await _repositorioTicket.eliminarTicket(id);
>>>>>>> 735d03c26e28ffd077cda4add6c062b853091aac

            return NoContent();
        }
    }
}