using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__metody_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca 
            // obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola.
            static double pole_kola(double r)
            {
                return Math.PI * r * r;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Dla r=3 Pole={0}", pole_kola(3));
                Console.ReadKey(true);
            }
        }
    }
}
