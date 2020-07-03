using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ErettsegiGyakorlas
{
    class ProgTetelek
    {
        internal static void RendezesCsokkeno()
        {
            Console.WriteLine("Tömb rendezése Linq segítségével csökkenő sorrendben.");
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9, -5, 3, -4 };
            arr = arr.OrderByDescending(valami => valami).ToArray();
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        internal static void RendezesNovekvo()
        {
            Console.WriteLine("Tömb rendezése Linq segítségével növekvő sorrendben.");
            int[] tomb = new int[] { 9, 8, 6, 5, 7, 2, 3, 1, 10, -4, -3, 0, -2, -1 };
            tomb = tomb.OrderBy(c => c).ToArray();
            foreach (var item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        internal static void RendezesCsokkenoLista()
        {
            Console.WriteLine("Nevek csökkenő sorrendben:");
            List<string> nevek = new List<string> { "Péter", "Kálmán", "Béla", "Jenő", "Cecília", "Zsombor" };
            nevek = nevek.OrderBy(c => c).ToList();
            foreach (var item in nevek)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        internal static void RendezesNovekvoLista()
        {
            Console.WriteLine();
            Console.WriteLine("Nevek növekvő sorrendben:");
            List<string> nevek = new List<string> { "Kálmán Áron", "Rezső Menő", "Béla Bekakil", "Armand Makacs", "József Szedál", "Ernő Bernő" };
            List<string> rnevek = nevek.OrderBy(c => c).ToList();
            foreach (var item in rnevek)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }

        internal static void MaximumKereses()
        {
            Console.WriteLine("Maximumkeresés:");
            int[] n = { 1, 10, 4, -2, 3, 6, 7, 2};
            int max = n.Max();
            Console.WriteLine(max);
            Console.WriteLine();
        }

        internal static void MinimumKereses()
        {
            Console.WriteLine("Minimumkeresés:");
            int[] n = { 1, 10, 3, 12, 4, 7, -10, -2, -3, 5, 7, 9 };
            int min = n.Min();
            Console.WriteLine(min);
            Console.WriteLine();
        }

        internal static void Atlag()
        {
            int[] osztalyzatok = { 1, 2, 2, 1, 4, 5, 5, 4, 4, 5, 3, 5 };
            double atlag = osztalyzatok.Average();
            Console.WriteLine("A tanuló átlaga: {0:N2}%", atlag); // 2 tizedesjegy pontosság

            // A tizedesjegyek meghatározására 2 módszer van: //
            Console.WriteLine("A tanuló átlaga: {0:N2}", atlag);
            //vagy//
            Console.WriteLine("A tanuló átlaga: {0:0.00}", atlag);
        }

        internal static void Osszegzes()
        {
            Console.WriteLine();
            int[] tomb = { 1, 3, 10, 2, 6, 7, 2 };
            int ossz = tomb.Sum();
            Console.WriteLine("A tömb értékeinek összege: {0}", ossz);
        }

        internal static void Megszamolas()
        {
            // Meg kell számolni, hogy hány olyan elem van, ami megfelel az adott feltétel(ek)nek. //
            int[] n = { 1, 2, 3, 4, 5, -2, -3, -1, 0, 6, 7, 8, 10, -9, 9 };
            int db = n.Count(c => c > 3);
            Console.WriteLine("3-nál kisebb elemek darabszáma: {0}", db);
        }

        internal static void Kivalasztas()
        {
            // Megadja, hogy a keresett elem hányadik indexen helyezkedik el. //
            List<string> nevek = new List<string> { "Béla", "Rezső", "Árpád"};
            int index = nevek.IndexOf("Rezső");
            Console.WriteLine("Rezső indexe a tömbben: {0}", index);
        }

        internal static void Eldontes()
        {
            /* Ismerjük 11 ember magasságát. Készítsen programot, amely megadja, hogy van-e olyan ember
             * aki alacsonyabb, mint a mögötte állók valamelyike! */

            int[] magassag = new int[11];
            Random rnd = new Random();
            bool kisebb = false;

            for (int i = 0; i < magassag.Length; i++)
            {
                magassag[i] = rnd.Next(150, 181);
                Console.Write(magassag[i]+"cm. "); // Ellenőrzés céljából
            }

            for (int i = 0; i < magassag.Length; i++)
            {
                for (int j = i+1; j < magassag.Length; j++)
                {
                    if (magassag[i] < magassag[j])
                    {
                        kisebb = true;
                        break;
                    }
                }
            }
            Console.WriteLine();
            if (kisebb)
            {
                Console.WriteLine("Van ilyen ember.");
            }
            else
            {
                Console.WriteLine("Nincs ilyen ember.");
            }
        }
    }
}
