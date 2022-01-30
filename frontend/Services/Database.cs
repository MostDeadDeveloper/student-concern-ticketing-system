using System.Collections.Generic;
using app.Models;

namespace app.Services
{
    public class Database
    {
        public IEnumerable<Ticket> GetItems() => new[]
        {
            new Ticket { TicketName = "First Ticket" },
            new Ticket { TicketName = "Second Ticket" },
            new Ticket { TicketName = "Third Ticket", IsFinished = true },
        };
    }
}
