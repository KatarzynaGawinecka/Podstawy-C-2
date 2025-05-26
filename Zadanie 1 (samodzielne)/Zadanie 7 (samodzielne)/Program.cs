using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n>1 i wypisz wszystkie liczby pierwsze z przedziału [1,n].
            Console.Write("Podaj liczbę n > 1: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool pierwsza = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        pierwsza = false;
                        break;
                    }
                }
                if (pierwsza)
                    Console.Write(i + " ");
            }
            Console.ReadKey(true);
        }
    }
}
