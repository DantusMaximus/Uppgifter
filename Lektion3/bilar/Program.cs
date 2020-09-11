using System;

namespace bilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många personer?");
            int personCount = Int32.Parse(Console.ReadLine());
            const int carCapacity = 5;
            int carCount = (personCount + (carCapacity-1))/carCapacity;
            Console.WriteLine($"Det krävs {carCount} bilar och blir {carCount*carCapacity-personCount} platser över");
        }
    }
}
