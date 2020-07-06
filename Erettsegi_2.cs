using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace eutazas
{
    class eutazas
    {
        internal byte sorszam;
        internal string datum;
        internal int azonosito;
        internal string tipus;
        internal string ervenyes;

        static void Main(string[] args)
        {
            Tasks.Task1();
            Tasks.Task2();
            Console.WriteLine("3. feladat");
            Console.WriteLine("A buszra "+Tasks.Task3().ToString()+" utas nem szállhatott fel.");
            Tasks.Task4();
            Tasks.Task5();
        }
    }

    class Tasks
    {
        internal static List<eutazas> adatok = new List<eutazas>();

        internal static void Task1()
        {
            FileStream fs = new FileStream(@"utasadat.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(' ');
                eutazas Data = new eutazas
                {
                    sorszam = byte.Parse(a[0]),
                    datum = a[1],
                    azonosito = int.Parse(a[2]),
                    tipus = a[3],
                    ervenyes = a[4]
                };
                adatok.Add(Data);
            }
            sr.Close();
            fs.Close();
        }

        internal static void Task2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("A buszra "+adatok.Count+" utas akart felszállni.");
        }

        internal static int Task3()
        {
            int osszes = 0;
            foreach (var utas in adatok)
            {
                if (!Ervenyessegellenorzes(utas.ervenyes, utas.datum))
                {
                    osszes++;
                }
            }
            return osszes;
        }

        internal static bool Ervenyessegellenorzes(string ervenyes, string datum)
        {
            if (ervenyes.Length <= 2)
            {
                if (int.Parse(ervenyes) == 0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                if (DateTime.Compare(DateTime.ParseExact(datum.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture),
                    DateTime.ParseExact(ervenyes, "yyyyMMdd", CultureInfo.InvariantCulture)) > 0)
                {
                    return false;
                }
                return true;
            }
        }

        internal static void Task4()
        {
            Console.WriteLine("4. feladat");
            List<int> megallo = new List<int>();
            int temp = 0;
            for (int i = 0; i < adatok.Count-1; i++)
            {
                if (adatok[i].sorszam == adatok[i+1].sorszam)
                {
                    temp++;
                }
                else
                {
                    megallo.Add(temp);
                    temp = 0;
                }
            }
            int index = megallo.IndexOf(megallo.Max());
            Console.WriteLine("A legtöbb utas ({0} fő) a {1}. megállóban próbált felszállni.", megallo.Max() + 1, index);
        }

        internal static void Task5()
        {
            Console.WriteLine("5. feladat");
            Console.WriteLine("Ingyenesen utazók száma: {0} fő", Ingyenes());
            Console.WriteLine("A kedvezményesen utazók száma: {0} fő", Kedvezmenyes());
        }

        internal static int Ingyenes()
        {
            int free = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (Ervenyessegellenorzes(adatok[i].ervenyes, adatok[i].datum))
                {
                    if (adatok[i].tipus == "NYP" || adatok[i].tipus == "RVS" ||adatok[i].tipus == "GYK")
                    {
                        free++;
                    }
                }
            }
            return free;
        }

        internal static int Kedvezmenyes()
        {
            int spec = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (Ervenyessegellenorzes(adatok[i].ervenyes, adatok[i].datum))
                {
                    if (adatok[i].tipus == "TAB" || adatok[i].tipus == "NYB")
                    {
                        spec++;
                    }
                }
            }
            return spec;
        }

        internal static int napokszama(int e1, int h1, int n1, int e2, int h2, int n2)
        {
            h1 = (h1 + 9) % 12;
            e1 = e1 - h1 / 10;
            int d1 = 365 * e1 + e1 / 4 - e1 / 100 + e1 / 400 + (h1 * 306 + 5) / 10 + n1 - 1;
            h2 = (h2 + 9) % 12;
            e2 = e2 - h2 / 10;
            int d2 = 365 * e2 + e2 / 4 - e2 / 100 + e2 / 400 + (h2 * 306 + 5) / 10 + n2 - 1;
            return d2 - d1;
        }
    }
}
