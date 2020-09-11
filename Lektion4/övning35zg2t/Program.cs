using System;

namespace övning35zg2t
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken månad är du född i?");
            string m = Console.ReadLine();
            Console.WriteLine($"Vilken dag i " + m + " är du född på?");
            int d = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ditt stjärntecken är " + Stjärntecken(m, d));
        }
        static string Stjärntecken(string m, int d)
        {
            if((m.Equals("mars") && 21<=d) || (m.Equals("april") && d<=19))
            {
                return "Väduren";
            }

            else if((m.Equals("april") && 20<=d) || (m.Equals("maj") && d<=20))
            {
                return "Oxen";
            }

            else if((m.Equals("maj") && 21<=d) || (m.Equals("juni") && d<=21))
            {
                return "Tvillingarna";
            }

            else if((m.Equals("juni") && 22<=d )||( m.Equals("juli") && d<=22))
            {
                return "Kräftan";
            }

           
            else if((m.Equals("juli") && 23<=d) || (m.Equals("augusti") && d<=22))
            {
                return "Lejonet";
            }

           
            else if((m.Equals("augusti") && 23<=d )||( m.Equals("september") && d<=22))
            {
                return "Jungfrun";
            }

           
            else if((m.Equals("september") && 23<=d) || (m.Equals("oktober") && d<=22))
            {
                return "Vågen";
            }

           
            else if((m.Equals("oktober") && 22<=d) || (m.Equals("november") && d<=22))
            {
                return "Skorpionen";
            }

           
            else if((m.Equals("november") && 22<=d) || (m.Equals("december") && d<=21))
            {
                return "Skytten";
            }

           
            else if((m.Equals("december") && 22<=d) || (m.Equals("januari") && d<=19))
            {
                return "Stenbocken";
            }

           
            else if((m.Equals("januari") && 20<=d) || (m.Equals("februari") && d<=18))
            {
                return "Vattumannen";
            }
            
            else if((m.Equals("februari") && 19<=d )|| (m.Equals("mars") && d<=20))
            {
                return "Fiskarna";
            }
            else{
                return "Felinmatning";
            }
        }
    }
}