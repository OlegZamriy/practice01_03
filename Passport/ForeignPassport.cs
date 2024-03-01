using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passport
{

    using System;
    using System.Collections.Generic;

    public class ForeignPassport : PassportInfo
    {
        public List<string> Visas { get; set; }
        public string PassportType { get; set; }

        public ForeignPassport(string firstName, string lastName, string nationality, DateTime dateOfBirth, string passportNumber, List<string> visas, string passportType)
            : base(firstName, lastName, nationality, dateOfBirth, passportNumber)
        {
            Visas = visas;
            PassportType = passportType;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Visas:");
            foreach (var visa in Visas)
            {
                Console.WriteLine(visa);
            }
            Console.WriteLine($"Passport Type: {PassportType}");
        }
    }

}
