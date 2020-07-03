using System;
using System.Collections.Generic;
namespace GyakorlóFeladatok_2._0
{
    class Program
    {
        // Első Feladat: tölts fel egy tömböt random számokkal, és írasd ki a legkisebbet!
        // Tömb feltöltése random számokkal.

        static int[] RandomTomb (Random rnd, int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(1, 501);
            }
            return array;
        }

        // Legkisebb elem megkeresése a tömbben.

        static int LegkisebbElem (int[] tomb)
        {
            int kicsi = tomb[0];

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < kicsi)
                {
                    kicsi = tomb[i];
                }
            }
            return kicsi;
        }

        // Második Feladat: Számold meg, hány 10-nél, 20-nál, 30-nál, n-nél nagyobb szám van egy random számokkal feltöltött tömbben.
        // N: a felhasználó által bekért adat.

        static int[] GeneralRandomTomb(Random rnd, int[] tomb)
        {
            int[] array = new int[tomb.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 200);
            }
            return array;
        }

        static string MennyiNagyobb(int[] tomb, int n)
        {
            int tiz = 0;
            int husz = 0;
            int harminc = 0;
            int bekert = 0; // A felhasználó az n-be menti a bekért szám értékét, ezt fogja vizsgálni a függvény.
            
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] > 10)
                {
                    tiz++;
                }
                if (tomb[i] > 20)
                {
                    husz++;
                }
                if (tomb[i] > 30)
                {
                    harminc++;
                }
                if (tomb[i] > n)
                {
                    bekert++;
                }
            }
            string osszes = ("10-nél nagyobb elemek száma: "+tiz+"db. 20-nál nagyobb elemek száma: "+husz+"db. " +
                "30-nál nagyobb elemek száma: "+harminc+".db "+n+"-nál/-nél nagyobb elemek száma: "+bekert+"db.");
            return osszes;
        }

        // Harmadik Feladat:

        static bool VanKozosElem(int[] collection, int adat)
        {
            foreach (int temp in collection)
            {
                if (temp == adat)
                {
                    return true;
                }
            }
            return false;
        }

        static int KozosElemek(int[] t1, int[] t2)
        {
            int kozoselemekszama = 0;

            foreach (int item in t2)
            {
                if (VanKozosElem(t1,item))
                {
                    kozoselemekszama++;
                }
            }
            return kozoselemekszama;
        }

        // Negyedik Feladat:
        
        static int MennyiKozosString(string[] collection, string[] data)
        {
            int kozoselemek = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == data[i])
                {
                    kozoselemek++;
                }
            }
            return kozoselemek;
        }

        static string[] KozosString(string[] collection, string[] data)
        {
            string[] kozos = new string[collection.Length];

            for (int i = 0; i < data.Length; i++)
            {
                if (collection[i] == data[i])
                {
                    kozos[i] = data[i];
                }
            }
            return kozos;
        }

        static string[] StringTombok(string[] array1, string[] array2)
        {
            string[] kozosstring = new string[MennyiKozosString(array1,array2)];
            for (int i = 0; i < kozosstring.Length; i++)
            {
                kozosstring[i] = KozosString(array1, array2)[i];
            }
            return kozosstring;
        }
        

        static void Main(string[] args)
        {
            // Első Feladat:

            Console.Write("Kérlek, add meg a tömb méretét: ");
            
            int meret = int.Parse(Console.ReadLine());
            
            Random SourceOfRandom = new Random();

            int[] ertekek = new int[meret];

            for (int i = 0; i < meret; i++)
            {
                ertekek = RandomTomb(SourceOfRandom, meret);
            }

            Console.WriteLine("A tömb elemei: ");
            for (int i = 0; i < ertekek.Length; i++)
            {
                Console.WriteLine(ertekek[i]);
            }

            int min = LegkisebbElem(ertekek);
            Console.WriteLine("A legkisebb elem a tömbben: {0}", min);

            // Második Feladat:

            Console.Write("Kérlek, add meg mekkora legyen a tömb mérete: ");

            Random srcRandomness = new Random();                                 // A metódushoz szükséges Random függvény.
            int[] srcArray = new int[int.Parse(Console.ReadLine())];             // A metódushoz szükséges tömb és a méret megadása.
                        
            Console.WriteLine("A tömb feltöltése random számokkal...");
            int[] rtomb = GeneralRandomTomb(rnd: srcRandomness, tomb: srcArray); // A tömb feltöltése a GeneralRandomTomb metódussal.

            Console.Write("Kérlek, add meg, mekkora számnál keressek nagyobbat a tömbben: ");
            string mennyiazannyi = MennyiNagyobb(tomb: rtomb, n: int.Parse(Console.ReadLine()));

            Console.WriteLine("A tömbben lévő elemek: ");
            for (int i = 0; i < rtomb.Length; i++)
            {
                Console.WriteLine(rtomb[i]);
            }
            // Végeredmény kiíratása:
            Console.WriteLine(mennyiazannyi);

            // Harmadik Feladat: Tölts fel 2 tömböt random számokkal, majd állapítsd meg hány közös elemük van!
            // Ebben a feladatban már használni fogom az előre definiált metódusokat.

            int[] array1 = new int[20];
            int[] array2 = new int[20];
            array1 = GeneralRandomTomb(rnd: srcRandomness, tomb: array1);
            array2 = GeneralRandomTomb(rnd: srcRandomness, tomb: array2);

            int kozoselemek = KozosElemek(t1: array1, t2: array2);

            if (kozoselemek == 0)
            {
                Console.WriteLine("A két tömbben nincsenek közös elemek.");
            }
            else
            {
                Console.WriteLine("Összesen {0} közös elem van a két tömbben.", kozoselemek);
            }

            // Negyedik Feladat:
            
            string[] elsotomb = new string[] { "elso", "masodik", "harmadik"};
            string[] masodiktomb = new string[] { "elso", "negyedik", "masodik"};

            string[] eredmenytomb = new string[MennyiKozosString(collection: elsotomb, data: masodiktomb)];

            for (int i = 0; i < eredmenytomb.Length; i++)
            {
                eredmenytomb[i] = StringTombok(array1: elsotomb, array2: masodiktomb)[i];
            }

            for (int i = 0; i < eredmenytomb.Length; i++)
            {
                Console.WriteLine(eredmenytomb[i]);
            }
            

            string[] asd1 = new string[] { "Mahesh Chand", "Mike Gold", "Raj Beniwal", "Praveen Kumar", "Dinesh Beniwal" };
            string[] asd2 = new string[] { "Mahesh Chand", "Mike Gold", "faszfej", "Raj Beniwal" };
            
            int kozos1 = 0;
            for (int i = 0; i < asd1.Length; i++)
            {
                for (int j = 0; j < asd2.Length; j++)
                {
                    if (asd1[i]==asd2[j])
                    {
                        //result.Add(asd2[j]);
                        kozos1++;
                    }
                }
            }
            
            string[] kozelemek = new string[kozos1];
            
            for (int i = 0; i < kozos1; i++)
            {
                for (int j = 0; j < asd1.Length; j++)
                {
                    for (int k = 0; k < asd2.Length; k++)
                    {
                        if (asd1[j] == asd2[k])
                        {
                            kozelemek[k] = asd2[k];
                        }
                    }
                }
            }
            Console.WriteLine("Közös elemek: ");

            for (int i = 0; i < kozos1; i++)
            {
                if (i == kozos1)
                {
                    Console.Write(kozelemek[i] + ". ");
                }
                else
                {
                    Console.Write(kozelemek[i] + ", ");
                }
            }
        }
    }
}