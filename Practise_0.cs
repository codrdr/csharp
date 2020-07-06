using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace gyakorlas
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
            Tasks.Task6();
            Tasks.Task7();
            Tasks.Task8();
            Tasks.Task9();
            Tasks.Task10();
            Tasks.Task11();
            Tasks.Task12();
            Tasks.Task13();
            Tasks.Task14();
        }
    }
    internal class Data
    {
        internal int number;

        public Data()
        {
        }
    }

    internal class Tasks
    {
        internal static List<Data> adatok = new List<Data>();
        internal static void Task1()
        {
            FileStream fs = new FileStream(@"forras1.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string t = sr.ReadLine();
                Data data = new Data
                {
                    number = int.Parse(t)
                };
                adatok.Add(data);
            }
            sr.Close();
            fs.Close();
        }
        internal static void Task2()
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("Sorozat elemszáma: {0}", adatok.Count);
        }
        internal static void Task3()
        {
            Console.WriteLine("2. feladat");
#pragma warning disable CS0162 // Unreachable code detected
            for (int i = 0; i < adatok.Count; i++)
#pragma warning restore CS0162 // Unreachable code detected
            {
                if (adatok[i].number < 0)
                {
                    Console.WriteLine("Tartalmaz negatív számot a sorozat.");
                    break;
                }
                else
                {
                    Console.WriteLine("Nem tartalmaz negatív számot a sorozat.");
                    break;
                }
            }

        }
        internal static void Task4()
        {
            Console.WriteLine("3. feladat");
            var db = adatok.Count(c => c.number %2 == 0);
            Console.WriteLine("{0} db. páros szám található a sorozatban.", db.ToString());
        }
        internal static void Task5()
        {
            Console.WriteLine("4. feladat");
            int max = adatok.Max(c => c.number);
            Console.WriteLine("Legnagyobb elem: {0}", max);
        }
        internal static void Task6()
        {
            Console.WriteLine("5. feladat");
            var dividebyten = adatok.Where(c => c.number % 10 == 0);
            Console.Write("10-zel osztható számok: ");
            foreach (var item in dividebyten)
            {
                Console.Write(item.number + " ");
            }
        }
        internal static void Task7()
        {
            Console.WriteLine("6. feladat");
            int index = adatok.FindIndex(a => a.number % 29 == 0);
            Console.WriteLine("A legelső 29-cel osztható szám indexe: {0}", index);
        }
        internal static void Task8()
        {
            Console.WriteLine("7. feladat");
            bool igaze = false;
            foreach (var item in adatok)
            {
                if (item.number %2 != 0)
                {
                    igaze = true;
                }
                else
                {
                    igaze = false;
                }
            }
            if (igaze)
            {
                Console.WriteLine("Igaz. Minden szám páros.");
            }
            else
            {
                Console.WriteLine("Nem igaz. Nem páros minden szám.");
            }
        }
        internal static void Task9()
        {
            Console.WriteLine("8. feladat");
            double atlag = adatok.Average(c => c.number);
            Console.WriteLine("A sorozatban megtalálható számok átlaga: {0:.00}%", atlag);
        }
        internal static void Task10()
        {
            Console.WriteLine("9. feladat");
            //Van-e a sorozatban olyan negatív szám, amelyet nulla követ?
            if (Nullakovet())
            {
                Console.WriteLine("Van a sorozatban olyan negatív szám, amelyet nulla követ.");
            }
            else
            {
                Console.WriteLine("Nincs a sorozatban olyan negatív szám, amelyet nulla követ.");
            }
        }
        private static bool Nullakovet()
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].number < 0)
                {
                    if (adatok[i + 1].number == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        internal static void Task11()
        {
            Console.WriteLine("10. feladat"); //Írjuk ki az utolsó 17-tel osztható szám indexét!
            int index = adatok.FindIndex(c => c.number % 17 == 0);
            Console.WriteLine("Utolsó 17-tel osztható szám indexe: {0}", index);
        }        
        internal static void Task12()
        {
            //Mennyi a sorozatban található számok szorzatának kétszerese?
            Console.WriteLine("11. feladat");
            int pro = 1;
            for (int i = 0; i < adatok.Count; i++)
            {pro = pro * adatok[i].number; }
            Console.WriteLine(pro*2);
        }
        internal static void Task13()
        {
            
        }        
        internal static void Task14()
        {
        
        }
    }
}
