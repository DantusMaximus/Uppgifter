using System;

namespace övningav7gmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv tre tal.");
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double z = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Summan är {x+y+z:0.##}");
            var medel = (x+y+z)/3;
            Console.WriteLine($"Medel är {medel:0.##}");
            Console.WriteLine($"Variansen är är {(x-medel)*(x-medel) + (y-medel)*(y-medel) + (z-medel)*(z-medel):0.##}");
            
        }
    }
}
