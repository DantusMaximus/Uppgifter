using System;

namespace övning45tbeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange x1.");
            double x1= Double.Parse(Console.ReadLine());
            Console.WriteLine("Ange y1.");
            double y1= Double.Parse(Console.ReadLine());
            Console.WriteLine("Ange x2.");
            double x2= Double.Parse(Console.ReadLine());
            Console.WriteLine("Ange y2.");
            double y2= Double.Parse(Console.ReadLine());
            Console.WriteLine("Ange x3.");
            double x3= Double.Parse(Console.ReadLine());
            Console.WriteLine("Ange y3.");
            double y3= Double.Parse(Console.ReadLine());
            double area = ((x2-x1)*(y3-y1)-(y2-y1)*(x3-x1))/2;
            Console.WriteLine($"Triangelns area är {area:0.###}");

        }
    }
}
