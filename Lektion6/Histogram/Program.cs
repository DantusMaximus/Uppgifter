using System;
namespace Histogram
{
    static class Histogram{
        public static void ReadHistogram(string[] args, int[] histogram)
        {
            for(int i = 0; i<args.Length; i++)
            {
                for(int value = 1; value<=9; value++)
                {
                    if(args[i] == ($"{value}"))
                    {
                        histogram[value-1]++;
                    }
                }
            }
        }
        public static void GraphHistogram(int[] histogram)
        {
            int maxLength = 0;
            for(int i = 0; i<=8; i++)
            {
                if(histogram[i] > maxLength)
                {
                    maxLength = histogram[i];
                }
            }
            for(int i = maxLength; i>0; i--)
            {
                for(int j = 0; j<=8; j++)
                {
                    if(histogram[j] >= i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("1 2 3 4 5 6 7 8 9");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] histogram = new int[9];
            Histogram.ReadHistogram(args, histogram);
            Histogram.GraphHistogram(histogram);
        }
    }
}