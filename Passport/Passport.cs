using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passport
{


    using System;

    public class PassportInfo  
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportNumber { get; set; }

        public PassportInfo(string firstName, string lastName, string nationality, DateTime dateOfBirth, string passportNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
            DateOfBirth = dateOfBirth;
            PassportNumber = passportNumber;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Nationality: {Nationality}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
        }
    }


}
