using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;

namespace cegesauto
{
    class cegesauto
    {
        static void Main(string[] args)
        {
            Tasks.Task1();
            Tasks.Task2();
            Tasks.Task3();
            Tasks.Task4();
            Tasks.Task5();
            Tasks.Task6();
        }
    }
    internal class Data
    {
        internal int nap;
        internal string idopont;
        internal string rendszam;
        internal int azonosito;
        internal int km;
        internal string kibe;

        public Data()
        {
        }
    }
    internal class Tasks
    {
        internal static List<Data> adatok = new List<Data>();
        internal static List<Data> rendezettadatok = new List<Data>();
        internal static byte fnap = 0;
        internal static void Task1()
        {
            FileStream fs = new FileStream(@"autok.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            
            while (!sr.EndOfStream)
            {
                string[] t = sr.ReadLine().Split(' ');
                Data temp = new Data
                {
                    nap = int.Parse(t[0]),
                    idopont = t[1],
                    rendszam = t[2],
                    azonosito = int.Parse(t[3]),
                    km = int.Parse(t[4]),
                    kibe = int.Parse(t[5]) == 0 ? "ki" : "be"
                };
                adatok.Add(temp);
            }
            sr.Close();
            fs.Close();
        }
        internal static void Task2()
        {
            Console.WriteLine("2. feladat");
            for (int i = adatok.Count - 1; i >= 0; i--)
            {
                if (adatok[i].kibe == "ki")
                {
                    Console.WriteLine("{0}.nap rendszám: {1}", adatok[i].nap, adatok[i].rendszam);
                    break;
                }
            }
        }
        internal static void Task3()
        {
            Console.WriteLine("3. feladat");
            Console.Write("Nap: ");
            fnap = byte.Parse(Console.ReadLine());
            Console.WriteLine("Forgalom a(z) {0}.napon: ", fnap);
            
            var forgalom = adatok.Where(d => d.nap == fnap);

            foreach (var adott in forgalom)
            {
                Console.WriteLine(adott.idopont + " " + adott.rendszam + " " + adott.azonosito + " " + adott.kibe);
            }
        }
        internal static void Task4()
        {
            Console.WriteLine("4. feladat");
            int db = adatok.Count(c => c.kibe == "ki" && c.nap >= 29);
            Console.WriteLine("A hónap végén {0} autót nem hoztak vissza.", db);
        }

        public static void Task5()
        {
            // Gyakorlás, nem az érettségi feladat része. //
            Console.Write("Autó: ");
            string auto = Console.ReadLine();
            int autoki = adatok.Count(c => c.rendszam == auto && c.kibe == "ki");
            int autobe = adatok.Count(c => c.rendszam == auto && c.kibe == "be");
            int autosum = adatok.Count(c => c.rendszam == auto);
            var adriver = from barmi in adatok .Where(c=> c.rendszam == auto) .Distinct() select new { barmi.azonosito, barmi.nap, barmi.idopont, barmi.kibe };
            Console.WriteLine("A {0} nevű autó {1} alkalommal hagyta el a helyszínt és {2} alkalommal tért vissza. Összes: {3}", auto, autoki, autobe, autosum);
            Console.WriteLine("{0} nevű autót ekkor vezették a következő alkalmazottak: ", auto);
            foreach (var drivers in adriver)
            {
                Console.WriteLine(drivers.ToString()+" ");
            }
        }

        internal static void Task6()
        {
           
        }
        /*
        internal static void Task5()
        {
            int elso = 0;
            int er = 0;
            bool t = true;
            rendezettadatok = adatok.OrderBy(s => s.rendszam).ToList();
            
            for (int i = 0; i < rendezettadatok.Count-1; i++)
            {
                while (t)
                {
                    if (rendezettadatok[i + 1].km > rendezettadatok[i].km)
                    {
                        elso = rendezettadatok[i].km;
                        t = false;
                    }
                }
                if (rendezettadatok[i+1].rendszam != rendezettadatok[i].rendszam)
                {
                    er = rendezettadatok[i].km - elso;
                    Console.WriteLine(rendezettadatok[i].rendszam + " " + er + " km");
                    t = true;
                }
                if (rendezettadatok[i].rendszam == "CEG309")
                {
                    while (t)
                    {
                        if (rendezettadatok[i + 1].km > rendezettadatok[i].km)
                        {
                            elso = rendezettadatok[i].km;
                            int utolsoindex = rendezettadatok.Count - 1;
                            int utolso = rendezettadatok[utolsoindex].km;
                            int eredmeny = utolso - elso;
                            Console.WriteLine(rendezettadatok[i].rendszam + " " + eredmeny + " km");
                            t = true;
                        }
                    }
                }
            }
        }
        */
    }
}
