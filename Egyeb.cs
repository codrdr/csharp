using System;
using System.Collections.Generic;
using System.Text;

namespace ErettsegiGyakorlas
{
    class Egyeb
    {
        public static void Egyebek()
        {
            // Dátummá alakítás a megadott formátumban és Substring használata.

            //string datum = DateTime.ParseExact(atalakitandoadat.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            // A .ToString() metódusnak csak akkor kell paramétert adni, ha a kimeneti megjelenítésén változtatni szeretnénk.

            // Egy tömb elemében az összes feltételnek megfelelő elem megszámolása.
            string[] array = { "XXOOIXX", "XXOOIXXX", "OOXXXXX", "XIIXXXX" };

            int num = 0;

            foreach (var k in array)
            {
                if (k.Contains("O"))
                {
                    var p = k.ToCharArray();
                    for (int i = 0; i < p.Length; i++)
                    {
                        if (p[i].ToString() == "O")
                        {
                            num++;
                        }
                    }
                }
            }
            Console.WriteLine("Number of 0's = " + num);
        }
    }
}
