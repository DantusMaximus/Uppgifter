using System;

namespace övningk47qkb
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = {'g', 'f', 'o', 'z', 'o', 'p', 'd', 'u', ' ', 'w', 'w', 'i', 'o', 'g', 'r', 'l', 'k'};
            for(int i = 0; i<a.Length; i+= 2)
            {
                Console.Write(a[i]);
            }
        }
    }
}
