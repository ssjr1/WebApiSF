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
            var Tickets = await _repositorioTicket.listadoTickets();
            return Ok(Tickets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tickets>> GetTicket(int id)
        {
            var Ticket = await _repositorioTicket.obtenerTicketPorId(id);

            if (Ticket == null)
            {
                return NotFound();
            }

            return Ok(Ticket);
        }

        [HttpPost]
        public async Task<ActionResult<Tickets>> PostTicket(Tickets Tickets)
        {
            var id = await _repositorioTicket.crearTicket(Tickets);
            return CreatedAtAction(nameof(GetTicket), new { id = id }, Tickets);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Tickets Tickets)
        {
            if (id != Tickets.id)
            {
                return BadRequest();
            }

            await _repositorioTicket.modificarTicket(Tickets);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var Ticket = await _repositorioTicket.obtenerTicketPorId(id);

            if (Ticket == null)
            {
                return NotFound();
            }

            await _repositorioTicket.eliminarTicket(id);

            return NoContent();
        }
    }
}