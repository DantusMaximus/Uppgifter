using System;
namespace övning9d8nz3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din längd [cm]");
            var langd = Double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in din vikt [kg]");
            var vikt = Double.Parse(Console.ReadLine());
            langd/=100;
            Console.WriteLine($"Ditt BMI är: {vikt/(langd*langd):0.##}");
        }
    }
}
