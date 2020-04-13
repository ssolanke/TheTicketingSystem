using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Data;
using TicketingSystem.Models.TicketsViewModels;

namespace TicketingSystem.Controllers
{
    public class TicketsController : Controller
    {
        private SystemContext _context;
       
        /// <summary>
        /// Initializes _context
        /// </summary>
        /// <param name="context">context of client</param>
        public TicketsController(SystemContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Used to view all tickets in queue
        /// </summary>
        /// <param name="includeClosed">boolean for including closed tickets</param>
        /// <returns>view list of ordered tickets</returns>
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] bool includeClosed = false)
        {
            var orderedTickets = await _context.Tickets
                .OrderByDescending(ticket => ticket.DateAdded)
                .GroupBy(ticket => ticket.ClientId)
                .OrderBy(ticketClientGroup => ticketClientGroup.Count())
                .SelectMany(ticketClientGroup => ticketClientGroup)
                .Where(ticket => ticket.TicketStatus || ticket.TicketStatus != includeClosed)
                .OrderByDescending(ticket => ticket.IsUrgent)
                .OrderByDescending(ticket => ticket.TicketStatus)
                .ToListAsync();


            ViewData["includeClosed"] = includeClosed;

            return View(orderedTickets);
        }

        /// <summary>
        /// Opens a ticket
        /// </summary>
        /// <param name="id">unique id of ticket</param>
        /// <returns>view of the ticket</returns>
        [HttpGet]
        public async Task<IActionResult> Open([FromRoute] Guid id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            var client = await _context.Clients.FindAsync(ticket.ClientId);
            //var times = await _context.TechnicianTicketTimes.Where(time => time.TicketId == ticket.Id).Join(_context.Users, time => time.TechnicianId, tech => tech.UserName, (time, tech) => new TechnicianTime { Technician = tech, Time = time }).ToListAsync();
            return View(new TicketDetails { Ticket = ticket, Client = client });
            //return View();
        }
    }
}