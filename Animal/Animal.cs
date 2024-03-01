using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{

    using System;

    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Move()
        {
            Console.WriteLine("The animal moves.");
        }

        public virtual void Sound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

}
