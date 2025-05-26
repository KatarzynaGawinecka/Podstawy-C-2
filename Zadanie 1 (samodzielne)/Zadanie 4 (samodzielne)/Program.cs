using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4__samodzielne_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący kwotę w złotych, a następnie przeliczający ją na taką walutę jaką 
            // wybierze użytkownik: funty, dolary, euro.Użyj instrukcji switch.
            Console.Write("Podaj kwotę w zł: ");
            double pln = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wybierz walutę (funt/dolar/euro): ");
            string waluta = Console.ReadLine().ToLower();

            switch (waluta)
            {
                case "funt":
                    Console.WriteLine("Kwota w funtach: {0}", pln/5.0);
                    break;
                case "dolar":
                    Console.WriteLine("Kwora w dolarach: {0}", pln/4.5);
                    break;
                case "euro":
                    Console.WriteLine("Kwota w euro: {0}", pln/4.5);
                    break;
                default:
                    Console.WriteLine("Nieznana waluta.");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
