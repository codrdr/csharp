using System;

namespace Algoritmusok_és_adatstruktúrák
{
    class Program
    {
//---------------------------------------------------------------------------------------------------------------------------------------//
        
            //Függvények/metódusok/eljárások hozzáadása:

        static int szorzas(int szam)
        {
            return szam * 2;
        }


            //Csak visszatérési érték:

        static int DoubleOf(int elsoszam, int masodikszam, int harmadikszam)
        {
            return elsoszam + masodikszam + harmadikszam;
        }

            //Return nélkül:

        static void Udvozles()
        {
            Console.WriteLine("Szia!");
        }

            //Eldöntés tétel függvénye:

        static bool HasNegative(int[] array)
        {
            foreach (int number in array)
            {
                if (number < 0)
                {
                    return true;
                }
            }
            return false;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------//

        static void Main(string[] args)
        {

            //A felhasználótól bekért adatot megszorozza kettővel, ami a függvényben is látható.
            Console.WriteLine("Írj be egy számot: ");

            int a = szorzas(int.Parse(Console.ReadLine()));
            Console.WriteLine("A megadott szám kétszeres szorzata: " + a);


            //Csak visszatérési érték

            Console.WriteLine(DoubleOf(1, 2, 3));

            //Visszatérési érték nélkül

            Udvozles();

            //-------------------------------------------SOROZATSZÁMÍTÁS-------------------------------------------//

            //Az első 10 pozitív egész szám meghatározása (Összegzés tétel)

            Console.WriteLine("A számok összege 1-től 10ig:");

            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += i;
            }

            Console.WriteLine("Az eredmény: " + sum);

            //Egy adott szám faktoriálisának kiszámítása:

            Console.WriteLine("Kérem adjon meg egy pozitív egész számot: ");
            uint number = uint.Parse(Console.ReadLine()); // Az uint egy előjel nélküli egész szám, tehát csak pozitív lehet!

            long factorial = number;
            for (uint i = number; i > 1; i--)
            {
                factorial *= i - 1;
            }
            Console.WriteLine(number + "! = " + factorial);

            //-----------------------------------------------ELDÖNTÉS----------------------------------------------//

            // Az eldöntés egy egyszerű progtétel.
            // Akkor alkalmazható, amikor meg kell állapítani, hogy egy gyűjtemény elemei közül van-e olyan, ami megfelel egy adott feltételnek.
            // Pl.: van-e az iskolában olyan tanuló, aki kitűnő? Van-e prímszám 22 és 25 között?
            // Fontos! Csak egy igaz/hamis értékkel tér vissza, ami megmutatja, hogy talált-e a kritériumnak megfelelő elemet vagy sem.
            // A keresett elem helyéről (indexéről) nem árulkodik.

            /* Működése dióhéjban:

            static bool HasNegative(int[]array)
            {
                //...
            }
            
            A metódus visszatérési értéke bool. Ez azt jelenti, hogy a futás eredményét elmenthetjük egy bool típusú változóba. 
            
            A továbbiakban fennt deklarálom a függvényt és ezalatt a komment alatt dolgozok vele (hiszen a Main metódusban vagyunk).
             */

            int[] numbers = { 1, -2, 3, 4, 5, 6, 7, 8, 9, 10 };

            bool negativeIndicator = HasNegative(numbers);

            if (negativeIndicator)
            {
                Console.WriteLine("Találtam egy negatív számot.");
            }
            else
            {
                Console.WriteLine("Csak pozitív számok vannak a gyűjteményben.");
            }
        }
    }
}
