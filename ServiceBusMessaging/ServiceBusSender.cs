﻿using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading.Tasks;


namespace ServiceBusMessaging
{
    public class ServiceBusSender
    {
        private readonly QueueClient _queueClient;
        private readonly IConfiguration _configuration;
        private const string QUEUE_NAME = "ticketqueue";

        public ServiceBusSender(IConfiguration configuration)
        {
            _configuration = configuration;
            _queueClient = new QueueClient(
              _configuration.GetConnectionString("sbConnectionString"),
              QUEUE_NAME);
        }

        public async Task SendMessage(QueueTicket ticket)
        {
            string data = JsonConvert.SerializeObject(ticket);
            Message message = new Message(Encoding.UTF8.GetBytes(data));

            await _queueClient.SendAsync(message);
        }
    }
}
