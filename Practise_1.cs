using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace gyakorlas2
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
            Tasks.Task15();
            Tasks.Task16();
            Tasks.Task17();
            Tasks.Task18();
            Tasks.Task19();
            Tasks.Task20();
            Tasks.Task21();
            Tasks.Task22();
            Tasks.Task23();
            Tasks.Task24();
            Tasks.Task25();
            Tasks.Task26();
            Tasks.Task27();
            Tasks.Task28();
            Tasks.Task29();
            Tasks.Task30();
            Tasks.Task31();
            Tasks.Task32();
            Tasks.Task33();
        }
    }
    internal class Data
    {
        internal byte tanulokod;
        internal string diaknev;
        internal string matekinfo;
        internal string angol;
        internal string idegennyelv;
        internal string nem;
        internal byte csalad;
        internal byte testver;
    }
    internal class Tasks
    {
        private static readonly List<Data> adatok = new List<Data>();
        internal static void Task1()
        {
            FileStream fs = new FileStream(@"forras.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(';');
                Data diak = new Data
                {
                    tanulokod = byte.Parse(a[0]),
                    diaknev = a[1],
                    matekinfo = a[2],
                    angol = a[3],
                    idegennyelv = a[4],
                    nem = a[5],
                    csalad = byte.Parse(a[6]),
                    testver = byte.Parse(a[7])
                };
                adatok.Add(diak);
            }
            sr.Close();
            fs.Close();
        }

        internal static void Task2()
        {
            Console.WriteLine("1. feladat");
            Console.WriteLine("{0} diák tanul az osztályban.", adatok.Count);
        }

        internal static void Task3()
        {
            Console.WriteLine("2. feladat");
            int fiuk = adatok.Count(c => c.nem == "F");
            Console.WriteLine("{0} fiú jár az osztályba.", fiuk);
        }

        internal static void Task4()
        {
            Console.WriteLine("3. feladat");
            int lanyok = adatok.Count(c => c.nem == "L");
            Console.WriteLine("{0} lány jár az osztályba.", lanyok);
        }

        internal static void Task5()
        {
            Console.WriteLine("4. feladat");
            int testvercount = adatok.Count(c => c.testver > 1);
            Console.WriteLine("{0} olyan diák van akinek 1-nél több testvére van.", testvercount);
        }

        internal static void Task6()
        {
            Console.WriteLine("5. feladat");
            //Gyűjtse ki azon diákok nevét, akiknek több mint 1 testvérük van!
            IEnumerable<string> StudentNamesWhoHasMoreThanOneBrother = adatok.Where(c => c.testver > 1).Select(c => c.diaknev);
            foreach (string item in StudentNamesWhoHasMoreThanOneBrother)
            {
                Console.Write(item.ToString()+". ");
            }
            Console.WriteLine();
        }

        internal static void Task7()
        {
            Console.WriteLine("6. feladat");
            int testver2 = adatok.Count(c => c.testver > 2);
            Console.WriteLine("{0} olyan diák van, akiknek több mint 2 testvére van!", testver2);
        }

        internal static void Task8()
        {
            Console.WriteLine("7. feladat");
            IEnumerable<string> testver2 = adatok.Where(c => c.testver > 2).Select(c => c.diaknev);
            Console.WriteLine("Azon diákok neve, akiknek több mint 2 testvérük van: ");
            foreach (string item in testver2)
            {
                Console.Write(item + ". ");
            }
            Console.WriteLine();
        }

        internal static void Task9()
        {
            Console.WriteLine("8. feladat");
            int masodikidegennyelv = adatok.Count(c => c.idegennyelv == "német");
            Console.WriteLine("{0} olyan diák van, akik a 2. idegen nyelvként a németet tanulják!", masodikidegennyelv);
        }

        internal static void Task10()
        {
            Console.WriteLine("9. feladat");
            IEnumerable<string> nemetnevek = adatok.Where(c => c.idegennyelv == "német").Select(c => c.diaknev);
            Console.WriteLine("Azon fiú diákok neve, akik a 2.idegen nyelvként a németet tanulják: ");
            foreach (string item in nemetnevek)
            {
                Console.Write(item.ToString()+". ");
            }
            Console.WriteLine();
        }

        internal static void Task11()
        {
            Console.WriteLine("10. feladat");
            int HowManyStudentsAreLearningInTheFirstEnglishGroup = adatok.Count(c => c.angol.Substring(0, 1) == "1");
            Console.WriteLine("{0} diák tanul, az egyes angol csoportban.", HowManyStudentsAreLearningInTheFirstEnglishGroup);
        }

        internal static void Task12()
        {
            Console.WriteLine("11. feladat");
            int kettesangolcsoport = adatok.Count(c => c.angol.Substring(0, 1) == "2");
            Console.WriteLine("{0} diák tanul, a kettes angol csoportban.", kettesangolcsoport);
        }
        internal static void Task13()
        {
            Console.WriteLine("12. feladat");
            int alfacsoport = adatok.Count(c => c.matekinfo == "alfa");
            Console.WriteLine("{0} diák tanul az alfa matematika csoportban.", alfacsoport);
        }
        internal static void Task14()
        {
            Console.WriteLine("13. feladat");
            int betacsoport = adatok.Count(c => c.matekinfo == "beta");
            Console.WriteLine("{0} diák tanul a beta matematika csoportban.", betacsoport);
        }
        internal static void Task15()
        {
            Console.WriteLine("14. feladat");
            var alfalany = adatok.Count(c => c.nem == "L" && c.matekinfo == "alfa");
            Console.WriteLine("{0} lány diák tanul az alfa matematika csoportban.", alfalany);
        }
        internal static void Task16()
        {
            Console.WriteLine("15. feladat");
            var betalany = adatok.Count(c => c.nem == "L" && c.matekinfo == "beta");
            Console.WriteLine("{0} lány diák tanul a beta matematika csoportban.", betalany);
        }
        internal static void Task17()
        {
            Console.WriteLine("16. feladat");
            var alfafiu = adatok.Count(c => c.nem == "F" && c.matekinfo == "alfa");
            Console.WriteLine("{0} fiú diák tanul az alfa matematika csoportban.", alfafiu);
        }
        internal static void Task18()
        {
            Console.WriteLine("17. feladat");
            var betafiu = adatok.Count(c => c.nem == "F" && c.matekinfo == "beta");
            Console.WriteLine("{0} fiú diák tanul a beta matematika csoportban.", betafiu);
        }
        internal static void Task19()
        {
            Console.WriteLine("18. feladat");
            bool orosz = false;
            foreach (var item in adatok)
            {
                if (item.idegennyelv == "orosz")
                {
                    orosz = true;
                    break;
                }
            }
            if (orosz)
            {
                Console.WriteLine("Van olyan diák aki 2. idegennyelvként oroszt tanul.");
            }
            else
            {
                Console.WriteLine("Nincs olyan diák aki 2. idegennyelvként oroszt tanul.");
            }
        }
        internal static void Task20()
        {
            Console.WriteLine("19. feladat");
            bool olasz = false;
            foreach (var item in adatok)
            {
                if (item.idegennyelv == "olasz")
                {
                    olasz = true;
                    break;
                }
            }
            if (olasz)
            {
                Console.WriteLine("Van olyan diák aki 2. idegennyelvként olaszt tanul.");
            }
            else
            {
                Console.WriteLine("Nincs olyan diák aki 2. idegennyelvként olaszt tanul.");
            }
        }
        internal static void Task21()
        {
            Console.WriteLine("20. feladat");
            bool spanyol = false;
            foreach (var item in adatok)
            {
                if (item.idegennyelv == "spanyol")
                {
                    spanyol = true;
                    break;
                }
            }
            if (spanyol)
            {
                Console.WriteLine("Van olyan diák aki 2. idegennyelvként spanyolt tanul.");
            }
            else
            {
                Console.WriteLine("Nincs olyan diák aki 2. idegennyelvként spanyolt tanul.");
            }
        }
        internal static void Task22()
        {
            Console.WriteLine("21. feladat");
            var biggestfamily = adatok.Max(c => c.csalad);
            Console.WriteLine("A legnagyobb család az osztályban: {0} fő.", biggestfamily);
        }
        internal static void Task23()
        {
            Console.WriteLine("22. feladat");
            byte max = adatok.Max(c => c.testver);
            IEnumerable<string> nev = adatok.Where(c => c.testver == max).Select(c => c.diaknev);
            foreach (var item in nev)
            {
                Console.WriteLine(item.ToString() + " az egyik olyan diák akinek a legtöbb testvére van!");
            }
        }
        internal static void Task24()
        {
            Console.WriteLine("23. feladat");
        }
        internal static void Task25()
        {
            Console.WriteLine("24. feladat");
        }
        internal static void Task26()
        {
            Console.WriteLine("25. feladat");
        }
        internal static void Task27()
        {
            Console.WriteLine("26. feladat");
        }
        internal static void Task28()
        {
            Console.WriteLine("27. feladat");
        }
        internal static void Task29()
        {
            Console.WriteLine("28. feladat");
        }
        internal static void Task30()
        {
            Console.WriteLine("29. feladat");
        }
        internal static void Task31()
        {
            Console.WriteLine("30. feladat");
        }
        internal static void Task32()
        {
            Console.WriteLine("31. feladat");
        }
        internal static void Task33()
        {
            Console.WriteLine("32. feladat");
        }
    }
}
