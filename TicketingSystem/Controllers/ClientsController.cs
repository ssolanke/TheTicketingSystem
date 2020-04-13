using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TicketingSystem.Data;
using TicketingSystem.Models;
using TicketingSystem.Models.ClientsViewModels;
using ServiceBusMessaging;


namespace TicketingSystem.Controllers
{
    public class ClientsController : Controller
    {
        private SystemContext _context;
        private ServiceBusSender _serviceBusSender;
        /// <summary>
        /// Initializes _context
        /// </summary>
        /// <param name="context">context of client</param>
        public ClientsController(SystemContext context, ServiceBusSender serviceBusSender)
        {
            _context = context;
            _serviceBusSender = serviceBusSender;
        }

        /// <summary>
        /// Shows all clients
        /// </summary>
        /// <returns>clients page</returns>
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var clients = await _context.Clients.GroupJoin(_context.Tickets.Where(ticket => ticket.TicketStatus), client => client.ClientId, ticket => ticket.ClientId, (client, tickets) => new ClientDetails { Client = client, Tickets = tickets, OpenTicketCount = tickets.Count() }).OrderByDescending(details => details.Tickets.Count()).ToListAsync();
            return View(clients);
        }

        /// <summary>
        /// Gets view for adding a ticket.
        /// </summary>
        /// <returns>The view.</returns>
        [HttpGet]
        public IActionResult AddTicket([FromRoute] Guid id)
        {
            return View(new Ticket { ClientId = id });
        }

        /// <summary>
        /// Adds a ticket
        /// </summary>
        /// <param name="ticket">The ticket to be added</param>
        /// <returns>The added ticket</returns>
        [HttpPost]
        public async Task<IActionResult> AddTicket([FromForm] Ticket ticket)
        {
            //var date = new DateTime();
            //date = DateTime.Now;
           // ticket.DateAdded = DateTime.Now;
            ticket.IsUrgent = false;
            ticket.TicketStatus = true;

            _context.Tickets.Add(ticket);

            // Send this to the bus for the other services
            await _serviceBusSender.SendMessage(new QueueTicket
            {
                TicketId = ticket.TicketId,
                ClientId = ticket.ClientId,
                Title = ticket.Title
                
            });

            // await _context.SaveChangesAsync();

            //return View(ticket);
            return RedirectToAction(nameof(ClientsController.All), "Tickets");
        }

    }
}