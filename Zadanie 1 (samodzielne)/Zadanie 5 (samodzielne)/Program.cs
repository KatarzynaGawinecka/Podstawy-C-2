using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n>0 i oblicz n^n. Nie można używać funkcji matematycznych. 
            int n, i, wynik;
            Console.Write("Podaj liczbę naturalną n>0: ");
            n = Convert.ToInt32(Console.ReadLine());
            wynik = 1;
            for (i = 0; i < n; i++)
                wynik *= n;
            Console.WriteLine("n^n= {0}", wynik);
            Console.ReadKey(true);
        }
    }
}
