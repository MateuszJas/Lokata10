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
            double lok = 10000, m;
            double procenty = 0.05 / 12;
                        
            for ( m = 0; m < 12; m++)
            {

                lok = lok + (lok * procenty);

                
            }
           
            Console.WriteLine("Razem = {0:C} ", lok );
                
            Console.ReadKey();


        }
    }
}
