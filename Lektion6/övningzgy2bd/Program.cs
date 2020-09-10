using System;

namespace övningzgy2bd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett ord");
            string ord = Console.ReadLine();
            int i = ord.Length - 1;
            for(;i>=0;i--)
            {
                Console.Write(ord[i]);
            }
            /*for(int i = ord.Length-1; i>=0;i++)
            {
                Console.Write(ord[i]);
            }*/
        }
    }
}
