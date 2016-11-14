using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meilen, yards, kilometer;

            meilen = 26.0;
            yards = 385.0;

            kilometer = 1.609 * (meilen + yards / 1760.0);

            Console.WriteLine("Die Länge des Marathonlaufes " + "beträgt " + kilometer + "km"); 
        }
    }
}
