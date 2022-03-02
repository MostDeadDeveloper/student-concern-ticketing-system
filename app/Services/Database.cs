using System.Collections.Generic;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using app.Models;

namespace app.Services
{
    public class Database : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }

        public string DbPath { get; }

        public Database()
        {
            DbPath = "blogging.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public IEnumerable<Ticket> GetItems() => this.Tickets;
    }
}


