using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dany jest trójkąt o współrzędnych A=(-4,-4), B=(4,-2), C=(6,6). Wczytaj od użytkownika 
            //   współrzędne punktu P = (x, y).Wypisz na ekranie informację czy punkt P leży wewnątrz, na
            //zewnątrz, czy też na boku trójkąta ABC. 
           
    
            {
                // Wierzchołki trójkąta
                var A = (-4.0, -4.0);
                var B = (4.0, -2.0);
                var C = (6.0, 6.0);

                // Wczytanie punktu P
                Console.Write("Podaj współrzędną x punktu P: ");
                double px = double.Parse(Console.ReadLine());
                Console.Write("Podaj współrzędną y punktu P: ");
                double py = double.Parse(Console.ReadLine());

                // Oblicz równania prostych AB, BC i CA w postaci Ax + By + C = 0
                (double a, double b, double c) RownanieProstej((double x, double y) p1, (double x, double y) p2)
                {
                    double a = p1.y - p2.y;
                    double b = p2.x - p1.x;
                    double c = p1.x * p2.y - p2.x * p1.y;
                    return (a, b, c);
                }

                double PozycjaWzgledemProstej((double A, double B, double C) prosta, double x, double y)
                {
                    return prosta.A * x + prosta.B * y + prosta.C;
                }

                var AB = RownanieProstej(A, B);
                var BC = RownanieProstej(B, C);
                var CA = RownanieProstej(C, A);

                double w1 = PozycjaWzgledemProstej(AB, px, py);
                double w2 = PozycjaWzgledemProstej(BC, px, py);
                double w3 = PozycjaWzgledemProstej(CA, px, py);

                // Sprawdź znaki
                bool onEdge = w1 == 0 || w2 == 0 || w3 == 0;
                bool sameSign = (w1 > 0 && w2 > 0 && w3 > 0) || (w1 < 0 && w2 < 0 && w3 < 0);

                if (onEdge)
                {
                    Console.WriteLine("Punkt P leży na boku trójkąta ABC.");
                }
                else if (sameSign)
                {
                    Console.WriteLine("Punkt P leży wewnątrz trójkąta ABC.");
                }
                else
                {
                    Console.WriteLine("Punkt P leży na zewnątrz trójkąta ABC.");
                }
                Console.ReadKey(true);
            }
        }

    }
}

