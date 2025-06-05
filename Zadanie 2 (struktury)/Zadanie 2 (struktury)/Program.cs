using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__struktury_
{
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }
    class Program
    {
        //Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen. 
        // Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów. 
        // Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.
        static void Main(string[] args)
        {
            Uczen[] uczniowie;
            int ilu_uczniow, ile_ocen, i, j;
            Console.Write("Podaj liczbę uczniów w klasie:");
            ilu_uczniow = Convert.ToInt32(Console.ReadLine());
            uczniowie = new Uczen[ilu_uczniow];
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("Podaj imię ucznia {0}: ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj nazwisko ucznia {0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.Write("Ile ocen ma {0} {1}: ", uczniowie[i].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].oceny = new byte[ile_ocen];
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write("Podaj ocenę numer {0}", j + 1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("{0}. {1} {2}", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                foreach (byte o in uczniowie[i].oceny)
                    Console.Write("{0}, ", o);
                Console.WriteLine("");
            }
            Console.ReadKey(true);
        }
    }
    }

