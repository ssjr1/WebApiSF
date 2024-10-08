﻿using LibreriaSupportFast.Models;
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
            var Tickets = await _repositorioTicket.ListadoTickets();
            return Ok(Tickets);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tickets>> GetTicket(int id)
        {
            var Ticket = await _repositorioTicket.ObtenerTicketPorId(id);

            if (Ticket == null)
            {
                return NotFound();
            }

            return Ok(Ticket);
        }

        [HttpPost]
        public async Task<ActionResult<Tickets>> PostTicket(Tickets Tickets)
        {
            var id = await _repositorioTicket.CrearTicket(Tickets);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTicket(int id, Tickets Tickets)
        {
            if (id != Tickets.Id)
            {
                return BadRequest();
            }

            await _repositorioTicket.ModificarTicket(Tickets);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            var Ticket = await _repositorioTicket.ObtenerTicketPorId(id);

            if (Ticket == null)
            {
                return NotFound();
            }

            await _repositorioTicket.EliminarTicket(id);

            return NoContent();
        }
    }
}