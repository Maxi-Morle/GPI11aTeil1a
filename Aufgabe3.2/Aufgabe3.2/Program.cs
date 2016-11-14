using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e, summe, durchschnitt;
            a = 5;
            b = 9;
            c = 4;
            d = 17;
            e = 3;

            summe = a + b + c + d + e;
            durchschnitt = summe / 5; 

            Console.WriteLine("Der Durchschnitt beträgt " + durchschnitt); 
        }
    }
}
