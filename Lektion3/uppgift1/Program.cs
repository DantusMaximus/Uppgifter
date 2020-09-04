using System;

namespace uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad är ditt namn?");
            string namn = Console.ReadLine();
            Console.WriteLine("Hej " + namn + "!");
        } 
    }
}
