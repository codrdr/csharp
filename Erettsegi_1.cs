using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.WebSockets;

namespace metjelentes
{
    class Program
    {
        static void Main(string[] args)
        {
            Tasks.Task1();
            Tasks.Task2();
            Tasks.Task3();
            Tasks.Task4();
            Tasks.Task5();
        }
    }
    internal class Data
    {
        internal string telepules;
        internal string ido;
        internal string szel;
        internal byte homerseklet;
        public Data()
        {
            
        }
    }
    internal class Tasks
    {
        internal static List<Data> adatok = new List<Data>();
        internal static void Task1()
        {
            FileStream fs = new FileStream(@"tavirathu13.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(' ');
                Data item = new Data
                {
                    telepules = temp[0],
                    ido = temp[1].Insert(2, ":"),
                    szel = temp[2],
                    homerseklet = byte.Parse(temp[3])
                };
                adatok.Add(item);
            }
            sr.Close();
            fs.Close();
        }
        internal static void Task2()
        {
            Console.WriteLine("2. feladat");
            Console.Write("Adja meg egy település kódját! Település: ");
            string telepules = Console.ReadLine();
            Console.WriteLine("Az utolsó mérési adat a megadott településről {0}-kor érkezett.", UtolsoMeresiAdat(telepules));
        }
        private static string UtolsoMeresiAdat(string _telepules)
        {
            string result="";
            for (int i = adatok.Count - 1; i >= 0; i--)
            {
                if (adatok[i].telepules == _telepules)
                {
                    result = adatok[i].ido.ToString();
                    break;
                }
            }
            return result;
        }
        internal static void Task3()
        {
            Console.WriteLine("3. feladat");

            byte minho = adatok.Min(c => c.homerseklet);
            Data min = adatok.Where(min => min.homerseklet == minho).FirstOrDefault();
            Console.WriteLine("A legalacsonyabb hőmérséklet: {0} {1} {2} fok.", min.telepules, min.ido, min.homerseklet);

            byte maxho = adatok.Max(c => c.homerseklet);
            Data max = adatok.Where(max => max.homerseklet == maxho).FirstOrDefault();
            Console.WriteLine("A legmagasabb hőmérséklet: {0} {1} {2} fok.", max.telepules, max.ido, max.homerseklet);
        }
        internal static void Task4()
        {
            Console.WriteLine("4. feladat");
            byte count = 0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].szel == "00000")
                {
                    count++;
                    Console.WriteLine(adatok[i].telepules+" "+adatok[i].ido);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Nem volt szélcsend a mérések idején.");
            }
        }
        internal static void Task5()
        {
            Console.WriteLine("5. feladat");
            
            IEnumerable<byte> db = from darab in adatok where (darab.homerseklet == 1 || darab.homerseklet == 7 || darab.homerseklet == 13 || darab.homerseklet == 19) select (darab.homerseklet);
            int sum = adatok.Where(c => c.homerseklet == 1 || c.homerseklet == 7 || c.homerseklet == 13 || c.homerseklet == 19).Sum(c => c.homerseklet);
                

            List<Data> rendezett = adatok.OrderBy(o => o.telepules).ToList();
            for (int i = 0; i < rendezett.Count; i++)
            {
                int darab = adatok.Where(c => c.telepules == rendezett[i].telepules).Count(c => c.ido.Substring(0, 2) == "1" || c.ido.Substring(0, 2) == "7" || c.ido.Substring(0, 2) == "13" || c.ido.Substring(0, 2) == "19");
                var ossz = adatok.Sum()
            }
            Console.WriteLine("{0} Középhőmérséklet: {1}; Hőmérséklet-ingadozás: {2}");
            //var ossz adatok.sum
        }
    }
}
