using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{

    using System;

    public class Kangaroo : Animal
    {
        public Kangaroo(string name) : base(name)
        {
        }

        public override void Move()
        {
            Console.WriteLine("The kangaroo hops.");
        }

        public override void Sound()
        {
            Console.WriteLine("The kangaroo makes a clicking sound.");
        }
    }

}
