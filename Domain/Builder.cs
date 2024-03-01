using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    using System;

    public class Builder : Human
    {
        public string ConstructionSpecialty { get; set; }

        public Builder(string name, int age, string gender, string constructionSpecialty)
            : base(name, age, gender)
        {
            ConstructionSpecialty = constructionSpecialty;
        }

        public void Build()
        {
            Console.WriteLine($"{Name} is a {ConstructionSpecialty} builder.");
        }
    }

}
