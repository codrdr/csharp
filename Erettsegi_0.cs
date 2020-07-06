using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace utca
{
    class utca
    {
        internal byte oldal;
        internal byte meret;
        internal string szin;

        static void Main(string[] args)
        {
            Tasks.Task1();
            Tasks.Task2();
            Tasks.Task3();
            Tasks.Task4();
            Tasks.Task5();
        }
    }
    class Tasks
    {
        public static List<utca> adatok = new List<utca>();
        internal static void Task1()
        {
            FileStream fs = new FileStream(@"kerites.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            while (!sr.EndOfStream)
            {
                string[] t = sr.ReadLine().Split(' ');
                utca Data = new utca
                {
                    oldal = byte.Parse(t[0]),
                    meret = byte.Parse(t[1]),
                    szin = t[2]
                };
                adatok.Add(Data);
            }
            sr.Close();
            fs.Close();
        }
        internal static void Task2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("Az eladott telkek száma: {0}", adatok.Count);
            Console.WriteLine();
        }
        internal static void Task3()
        {
            Console.WriteLine("3. feladat");
            Console.WriteLine("{0} oldalon adták el az utolsó telket.", ParosParatlan());
            Console.WriteLine("Az utolsó telek házszáma: {0}", UtolsoTelek());
        }
        internal static string ParosParatlan()
        {
            string paros = "A páros";
            string paratlan = "A páratlan";
            #pragma warning disable CS0162 // Unreachable code detected
            for (int i = adatok.Count - 1; i >= 0; i--)
            #pragma warning restore CS0162 // Unreachable code detected
            {
                if (adatok[i].oldal == 0)
                {
                    return paros;
                }
                else
                {
                    return paratlan;
                }
            }
            return "Hiba";
        }
        internal static byte UtolsoTelek()
        {
            byte paros = 0;
            byte paratlan = 1;

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].oldal % 2 == 0)
                {
                    paros += 2;
                }
                else
                {
                    paratlan += 2;
                }
            }

            if (ParosParatlan() == "A páros")
            {
                return paros;
            }
            else return paratlan;
        }
        internal static void Task4()
        {
            int paratlan = -1;

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].oldal % 2 != 0)
                {
                    paratlan += 2;
                    if (adatok[i + 1].oldal % 2 != 0)
                    {
                        if (adatok[i].szin != ":" && adatok[i].szin != "#" && adatok[i + 1].szin != ":" && adatok[i + 1].szin != "#")
                        {
                            if (adatok[i].szin == adatok[i + 1].szin)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("4. feladat");
            Console.WriteLine("A szomszédossal egyezik a kerítés színe: {0}", paratlan);
        }

        internal static void Task5()
        {
            Console.WriteLine();
            Console.WriteLine("5.feladat");
            Console.Write("Adjon meg egy házszámot! ");
            int hazszam = byte.Parse(Console.ReadLine());
            Console.WriteLine("A kerítés színe / állapota: {0}", KeritesSzine(hazszam));
        }

        private static string KeritesSzine(int hazszam)
        {
            int paros = 0;
            int paratlan = 1;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].oldal % 2 == 0)
                {
                    paros += 2;
                }
                else
                {
                    paratlan += 2;
                }
                if (hazszam == paros || hazszam == paratlan)
                {
                    return adatok[i].szin;
                }
            }
            return "Error";
        }
    }
}
