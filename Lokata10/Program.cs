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
            double oprocentowanie = 0.05 / 12;
            double zysk = 0;
            
            for (int m = 0; m < 12; m++)
            {

                zysk = lok + (lok * oprocentowanie);

                lok = zysk;
            }

           
            Console.WriteLine("Razem = {0:C} ", lok );
                
            Console.ReadKey();


        }
    }
}
