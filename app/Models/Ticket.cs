using System;
using System.Collections.Generic;

namespace app.Models

{
    public class User
    {
        public int id {get; set;}

        public bool IsAdmin {get; set;}
        public string name {get; set;}
        public int age {get; set;}

        public ICollection<Ticket> Tickets { get; set;}

        public ICollection<Comment> Comments { get; set;}

    }
    public class Ticket
    {
        public int id { get; set; }

        public string? TicketName { get; set; }
        public string? Content { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }

        public int UserId {get; set;}
        public User User {get; set;}

        public ICollection<Comment> Comments { get; set;}


    }

    public class Comment
    {
        public int id {get; set;}
        public string Content {get; set;}

        public Ticket Ticket {get; set;}
        public int ticketId {get; set;}

        public User User {get; set;}
        public int userId {get; set;}

    }

}
