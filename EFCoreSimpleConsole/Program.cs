using EFCoreSimpleConsole.Repository.Entities;
using System;
using System.Linq;

namespace EFCoreSimpleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActorDbContext())
            {
                if(!db.Actors.Where(c => c.Name.Equals("Bruce Lee", StringComparison.InvariantCultureIgnoreCase)).Any()
                    && !db.Actors.Where(c => c.Name.Equals("Madonna", StringComparison.InvariantCultureIgnoreCase)).Any())
                {
                    Program.SeedData(db);
                }

                var count = db.SaveChanges();

                // Fetch data & write it out
                Console.WriteLine($"{count} records added");
                foreach (var Actor in db.Actors)
                {
                    Console.WriteLine($"Name - {Actor.Name},\t" +
                                      $"Age: {Actor.Age},\t" +
                                      $"Academy Winner: {Actor.AcademyWinner}");
                }
                Console.ReadLine();
            }
        }

        internal static void SeedData(ActorDbContext db)
        {
            // Seed
            db.Actors.AddRange(new Actor
            {
                Name = "Bruce Lee",
                Age = 75,
                AcademyWinner = false
            },
            new Actor
            {
                Name = "Madonna",
                Age = 55,
                AcademyWinner = true
            });
        }
    }
}
