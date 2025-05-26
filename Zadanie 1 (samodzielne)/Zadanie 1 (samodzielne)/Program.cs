using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący współrzędne punktu P=(x,y) i wypisujący na ekranie informację, 
            // do której ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/ lub osi OY.
            int x, y;
            Console.Write("Podaj współrzędną X: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Podaj współrzędną Y: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0)
                Console.WriteLine("Punkt leży na początku układu współrzędnych.");
            else if (x == 0)
                Console.WriteLine("Punkt leży na osi OY.");
            else if (y == 0)
                Console.WriteLine("Punkt leży na osi OX.");
            else if (x > 0 && y > 0)
                Console.WriteLine("Punkt leży w I. ćwiartce. ");
            else if (x < 0 && y > 0)
                Console.WriteLine("Punkt leży w II. ćwiartce. ");
            else if (x < 0 && y < 0)
                Console.WriteLine("Punkt leży w III. ćwiartce. ");
            else
                Console.WriteLine("Punkt leży w IV. ćwiartce. ");
            Console.ReadKey(true);


        }
    }
}
