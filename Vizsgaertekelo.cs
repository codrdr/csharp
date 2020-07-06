using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace vizsgaertekelo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks.Beolvas();
            Tasks.Kiertekel();
        }
    }

    internal class Data
    {
        // exam number, prediction, good or no //
        internal string fszam;
        internal string tipp;
        internal string megoldas;
    }

    internal class Tasks
    {
        internal static List<Data> adatok = new List<Data>();
        internal static void Beolvas()
        {
            FileStream fs = new FileStream(@"adat.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] t = sr.ReadLine().Split(' ');
                Data obj = new Data
                {
                    fszam = t[0],
                    tipp = t[1],
                    megoldas = t[2]
                };
                adatok.Add(obj);
            }
            sr.Close();
            fs.Close();
        }
        internal static void Kiertekel()
        {
            int helyes = adatok.Count(c => c.megoldas == "jó");
            int helytelen = adatok.Count(c => c.megoldas == "rossz");
            int osszesen = adatok.Count();

            Console.WriteLine("Összes válaszlehetőség száma: {0}", osszesen);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Helyes válaszok száma: {0}.", helyes);
            Console.WriteLine("Helytelen válaszok száma: {0}.", helytelen);
            Console.WriteLine("Elért: {0}%", helyes*2);
        }
    }
}
