using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menge * 100 / Distanz 

            double menge, distanz;

            Console.WriteLine("Bitte geben Sie die Menge des verbrauchten Kraftstoffes ein");
            menge = double.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die Distanz der gefahrenen Kilometer ein");
            distanz = double.Parse(Console.ReadLine());

            Console.WriteLine("Der Durchschnittsverbrauch auf 100km/h beträgt: " + (menge * 100 / distanz));
            Console.ReadLine(); 

        }
    }
}
