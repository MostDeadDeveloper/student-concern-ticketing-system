namespace app.Models

{
    public class Ticket
    {
        public int id { get; set; }
        public string? TicketName { get; set; }
        public string? Content { get; set; }
        public bool IsFinished { get; set; }
    }
}
