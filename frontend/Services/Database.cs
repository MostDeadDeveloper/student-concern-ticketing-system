using System.Collections.Generic;
using student_concern_ticketing_system.frontend.Models;

namespace student_concern_ticketing_system.frontend.Services
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
