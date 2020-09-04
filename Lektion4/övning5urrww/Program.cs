using System;

namespace övning5urrww
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv talen.");
            int[] rutnät = new int[9];
            for(int i=0;i<=8;i++)
            {
                rutnät[i] = Int32.Parse(Console.ReadLine());
            }
            int summa = rutnät[0] + rutnät[1] + rutnät[2];
            for(int i=0; i<=2; i++)
            {
                if(rutnät[i] + rutnät[i+3] + rutnät[i+6] != summa)
                {
                Console.WriteLine("Inte en magisk fyrkant.");
                return;
                }
                if(rutnät[3*i] + rutnät[3*i+1] + rutnät[3*i+2] != summa)
                {
                Console.WriteLine("Inte en magisk fyrkant.");
                return;
                }
            }
            if(rutnät[0] + rutnät[4] + rutnät[8] != summa || rutnät[2] +rutnät[4] + rutnät[6] != summa)
            {
                Console.WriteLine("Inte en magisk fyrkant.");
                return;
            }
            Console.WriteLine("Magisk fyrkant!");
        }
    }
}
