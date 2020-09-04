using System;

namespace övningetch2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal mellan 0 och 255.");
            var tal = Byte.Parse(Console.ReadLine());
            int ettor = 0;
            while(tal>0)
            {
            if(tal%2 == 1)
            {
                ettor++;
            }
            tal/=2;
            }
            Console.WriteLine("Antal nollor:" + (8-ettor));
            Console.WriteLine($"Antal ettor: {ettor}");
        }
    }
}
