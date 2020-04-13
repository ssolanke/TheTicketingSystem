using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models.TicketsViewModels
{
    /// <summary>
    /// ticket details model
    /// </summary>
    public class TicketDetails
    {
        /// <summary>
        /// get's ticket
        /// </summary>
        /// <returns>the ticket</returns>
        public Ticket Ticket { get; set; }

        /// <summary>
        /// get's Client
        /// </summary>
        /// <returns>the client</returns>
        public Client Client { get; set; }


    }   
}
