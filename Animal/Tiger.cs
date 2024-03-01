using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{

    using System;

    public class Tiger : Animal
    {
        public Tiger(string name) : base(name)
        {
        }

        public override void Sound()
        {
            Console.WriteLine("The tiger roars.");
        }
    }

}
