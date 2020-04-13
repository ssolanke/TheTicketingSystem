using Microsoft.Extensions.Configuration;
using ServiceBusMessaging;
using System.Threading.Tasks;
using TicketingSystem.Data;
using TicketingSystem.Models;

namespace TicketingSystem
{
    public class ProcessData : IProcessData
    {
        private IConfiguration _configuration;
        //private SystemContext _systemContext;

        public ProcessData(IConfiguration configuration)
        {
            _configuration = configuration;
           // _systemContext = systemContext;
        }

        public async Task Process(QueueTicket queueTicket)
        {
            using (var _systemContext =
               new SystemMessageContext(
                   _configuration.GetConnectionString("SqlConnection")))
            {
                await _systemContext.AddAsync(new Ticket
                {
                    TicketId = queueTicket.TicketId,
                    ClientId = queueTicket.ClientId,
                    Title = queueTicket.Title
                });

                await _systemContext.SaveChangesAsync();
            }
        }
    }
}
