using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufgabe 3.3//
            float a, b, summe, differenz, produkt, quotienten; 
            a = 1.234F;
            b = 5.678F;

            summe = a + b;
            differenz = a - b;
            produkt = a * b;
            quotienten = a / b;

            Console.WriteLine("Die Ergebnisse von a und b sind: " + summe + "ist die Summe, " + differenz + "ist die Differenz, "
                + produkt + "ist das Produkt und " + quotienten + "entspricht den Quotienten.");
            Console.ReadLine();

            //Testeingabe über Konsole// 
            String eingabe = Console.ReadLine(); 
            Console.WriteLine("Jo " + eingabe);
            Console.ReadLine();
        }
    }
}
