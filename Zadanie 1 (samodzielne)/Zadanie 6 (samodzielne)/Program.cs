using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n>0 i oblicz 1^1 + 2^2 + 3^3 + 4^4 + ⋯ + n^n.
            int n, i, suma;
            Console.Write("Podaj liczbę naturalną n>0:");
            n = Convert.ToInt32(Console.ReadLine());
            suma = 0;
            for (i = 1; i <= n; i++)
            {
                int potega = 1;
                for (int j = 1; j <= i; j++)
                {
                    potega *= i;
                }

                suma += potega;
            }

            Console.WriteLine("Suma wyrażeń 1^1 + 2^2 + ... + {0}^{0} = {1}",n,suma);
            Console.ReadKey(true);
        }

    }
    }

