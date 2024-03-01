using Passport;
using System;

class Program
{
    static void Main(string[] args)
    {
        PassportInfo passport = new PassportInfo("John", "Doe", "USA", new DateTime(1985, 7, 15), "AB123456");
        passport.PrintInfo();

        Console.WriteLine();

        ForeignPassport foreignPassport = new ForeignPassport("Jane", "Smith", "UK", new DateTime(1990, 3, 25), "XY789012", new List<string> { "USA", "Canada" }, "Biometric");
        foreignPassport.PrintInfo();
    }
}
