using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokata10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lok = 10000;
            double odsetki = 0.1 / 12;
            double zysk = 0;
            for (int m = 0; m < 12; m++)
            {

                zysk = lok + (lok * odsetki);

                lok = zysk;
            }

            Console.WriteLine((Math.Round(zysk)) + " zł" );
                
            Console.ReadKey();


        }
    }
}
