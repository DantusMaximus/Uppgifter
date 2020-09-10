using System;

namespace övning35zg2t
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken månad är du född i?");
            m = Console.ReadLine();
            Console.WriteLine($"Vilken dag i {m} är du född på?");
            d = Int32.Parse(Console.ReadLine());
            string stjärntecken = (Stjärntecken(m, d));
            Console.WriteLine("Du är " + stjärntecken);
        }
        string Stjärntecken(string m, int d)
        {
            if(m == "mars" && 21<=d || m = "april" && 19>=d)
            {
                return "Väduren";
            }

            else if(m == "april" && 20<=d || m = "maj" && 20>=d)
            {
                return "Oxen";
            }

            else if(m == "maj" && d>=21 || m = "juni" && 21<=d)
            {
                return "Tvillingarna";
            }

            else if(m == "juni" && d>=21 || m = "juli" && 19<=d)
            {
                return "Väduren";
            }

            else if(m == "juli" && d>=21 || m = "augusti" && 19<=d)
            {
                return "Väduren";
            }

            else if(m == "mars" && d>=21 || m = "april" && 19<=d)
            {
                return "Väduren";
            }

            else if(m == "mars" && d>=21 || m = "april" && 19<=d)
            {
                return "Väduren";
            }

            else if(m == "mars" && d>=21 || m = "april" && 19<=d)
            {
                return "Väduren";
            }

            else if(m == "mars" && d>=21 || m = "april" && 19<=d)
            {
                return "Väduren";
            }

        }
    }
}
