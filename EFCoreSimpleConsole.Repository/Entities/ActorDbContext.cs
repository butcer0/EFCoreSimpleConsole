using Microsoft.EntityFrameworkCore;

namespace EFCoreSimpleConsole.Repository.Entities
{
    public class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //TODO: Erik - 3/13/2018 Move to config file with encrypted connection string
            //optionsBuilder.UseSqlServer(
            //    @"Server=(localdb)\mssqllocaldb;Database=ActorDb;"
            //    + "Trusted_Connection=True;");

            #region Depricated - Use Linux SQL Server DB
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ActorDb;Trusted_Connection=True;");
            #endregion
            optionsBuilder.UseSqlServer(@"Server=108.161.137.144; Initial Catalog = master; Database=ActorDb; Integrated Security = False; User ID = SA; Password = Password1; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
        }
    }
}
