using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    using System;

    public class Pilot : Human
    {
        public string AircraftType { get; set; }

        public Pilot(string name, int age, string gender, string aircraftType)
            : base(name, age, gender)
        {
            AircraftType = aircraftType;
        }

        public void Fly()
        {
            Console.WriteLine($"{Name} is a pilot flying a {AircraftType}.");
        }
    }

}
