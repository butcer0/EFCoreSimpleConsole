using Microsoft.EntityFrameworkCore;

namespace EFCoreSimpleConsole.Repository.Entities
{
    public class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Erik - 3/13/2018 Move to config file with encrypted connection string
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=ActorDb;"
                + "Trusted_Connection=True;");
        }
    }
}
