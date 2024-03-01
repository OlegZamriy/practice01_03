using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{

    using System;

    public class Crocodile : Animal
    {
        public Crocodile(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("The crocodile swims.");
        }

        public override void Sound()
        {
            Console.WriteLine("The crocodile growls.");
        }
    }

}
