using System;
using System.Collections.Generic;

namespace Tömbök__listák
{
    class Program
    {
        static void Main(string[] args)
        {                                                   //TÖMBÖK//
            //A Gyűjteményekre tömböket és listákat használunk.
            //A tömbök hossza fix, létrehozás után nem változtatható. Minden egyes elemét azok sorszáma (indexe) szerint érhető el.
            //Deklarálása kapcsos zárójelekkel történik:
            double[] numbers = new double[10];
            //Előre is fel lehet tölteni:
            double[] numbers1 = {11.0, 12.0, 13.0, 14.0, 15.0 };
            //Az első elemre mindig 0-ként kell hivatkozni(mint mindig).
            
            //íráskor:
            numbers[0] = 11.2;

            //olvasáskor:
            double firstNumber = numbers[0];

            //A tárolt értékek feltöltéséhez sokkal ésszerűbb ciklust használni:
            double[] numbers2 = new double[10];
            //A for ciklus i belső változójával megindexeljük a tömb egyes elemeit majd beleírja a program a képlet által kiszámolt eredményt.
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = (((i + 1) * 3) / 2) - 1;
            }
            //A foreach ciklus végigiterál a tömb összes elemén. Az aktuálisat az item ciklusváltozó képviseli.
            //A cikluson belül így eltűnnek az indexek.
            foreach (double item in numbers2)
            {
                Console.WriteLine(item);
            }
                                                      //GENERIKUS LISTÁK//
            //A generikus listák használatához integrálni kell a using System.Collections.Generic; paranccsal.
            //Hasonlóan a tömbökhöz, ez is feltölthető előre mindenféle típussal / üresen is létrehozható.
            List<int> magicNubers = new List<int> { 4, 8, 15, 16, 23 ,42};
            List<string> asd = new List<string> { "asd", "basd", "casd" };
            List<string> toDoList = new List<string> { };

            //A legjobb dolog a listában az, hogy bármikor szabadon adhatsz hozzá/vehetsz el belőle elemet.
            //Minden új érték, amit felveszel, értelemszerűen a lista végére kerül.
            toDoList.Add("Bevásárolni");
            toDoList.Add("Híreket olvasni");
            toDoList.Add("Takarítani");

            toDoList.Remove("Bevásárolni");

            foreach  (string item in toDoList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
