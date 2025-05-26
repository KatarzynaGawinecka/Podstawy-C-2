using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący współrzędne dwóch punktów A=(x1,y1) i B=(x2,y2) oraz 
            // wypisujący na ekranie wzór funkcji liniowej przechodzącej przez te dwa punkty.
            double x1, y1, x2, y2, a, b;
            Console.Write("Podaj x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            if (x1 == x2)
                Console.WriteLine("Prosta jest pionowa: x=" + x1);
            else
             a = (y2 - y1) / (x2 - x1);
             b = y1 - a * x1;
            Console.WriteLine("Równanie prostej: y = {0}x+{1}", a, b);


        }
    }
}
