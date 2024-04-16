using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Kalkulacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadej první číslo:");
            double prvniCislo = double.Parse(Console.ReadLine());

            Console.Write("Zadej operátor (+, -, *, /):");
            string oper = Console.ReadLine();

            Console.Write("Zadej druhé číslo:");
            double druheCislo = double.Parse(Console.ReadLine());

            double result = 0;
            if (oper == "+")
            {
                result = prvniCislo + druheCislo;
            }
            else if (oper == "-")
            {
                result = prvniCislo - druheCislo;
            }
            else if (oper == "*")
            {
                result = prvniCislo * druheCislo;
            }
            else if (oper == "/")
            {
                result = prvniCislo / druheCislo;
            }
            Console.WriteLine("Výsledek: " + prvniCislo + oper + druheCislo + "=" + result);
        }
    }
}
