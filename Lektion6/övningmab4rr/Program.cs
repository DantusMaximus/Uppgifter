using System;

namespace övningmab4rr
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa = 0;
            foreach(var arg in args)
            {
                summa += Double.Parse(arg);
            }
            Console.WriteLine($"Summan är {summa}");
        }
    }
}
