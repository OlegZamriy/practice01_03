using Domain;
using System;

namespace practice01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new Builder("John", 35, "Male", "Carpenter");
            builder.Introduce();
            builder.Build();

            Sailor sailor = new Sailor("Alice", 28, "Female", "Cargo ship");
            sailor.Introduce();
            sailor.Sail();

            Pilot pilot = new Pilot("Mike", 40, "Male", "Boeing 737");
            pilot.Introduce();
            pilot.Fly();

        }
    }
}


