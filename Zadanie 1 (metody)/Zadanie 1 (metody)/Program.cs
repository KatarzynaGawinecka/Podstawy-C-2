using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1__metody_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami 
           // całkowitymi.Napisz program wykorzystujący funkcję suma.

            //funkcja, która oblicza sumę jej argumentów

            static int suma (int a, int b)
            {
                return a + b;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("2+5={0}", suma(2, 5));
                Console.ReadKey(true);
            }

        }
    }
}
