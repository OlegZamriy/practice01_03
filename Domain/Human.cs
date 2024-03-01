using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    using System;

    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Human(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name}, I'm {Age} years old.");
        }
    }

}
