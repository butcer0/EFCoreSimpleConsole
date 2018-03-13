using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSimpleConsole.Repository.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool AcademyWinner { get; set; }
    }
}
