﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketingSystem.Models.ClientsViewModels
{
    /// <summary>
    /// Client details request model
    /// </summary>
    public class ClientDetails
    {
        /// <summary>
        /// Get's client
        /// </summary>
        /// <returns>the client</returns>
        public Client Client { get; set; }

        /// <summary>
        /// List of tickets associated with client
        /// </summary>
        /// <returns>client's ticket list</returns>
        public IEnumerable<Ticket> Tickets { get; set; }

        /// <summary>
        /// Count of open tickets.
        /// </summary>
        public int OpenTicketCount { get; set; }
    }
}
