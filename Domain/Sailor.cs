using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    using System;

    public class Sailor : Human
    {
        public string ShipType { get; set; }

        public Sailor(string name, int age, string gender, string shipType)
            : base(name, age, gender)
        {
            ShipType = shipType;
        }

        public void Sail()
        {
            Console.WriteLine($"{Name} is a sailor aboard a {ShipType}.");
        }
    }

}
