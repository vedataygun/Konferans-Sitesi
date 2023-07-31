using Conference_Website.Models;
using Microsoft.EntityFrameworkCore;

namespace Conference_Website.Context
{
    public class DatabaseContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

  
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

    }
}
