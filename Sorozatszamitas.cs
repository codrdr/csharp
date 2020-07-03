using System;

namespace Sorozatszámítás
{
    class Program
    {
        static int Sum(int[]szamok)
        {
            int max = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                max += szamok[i];
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem, adja meg a tömb hosszát: ");
            int[] Tomb = new int [int.Parse(Console.ReadLine())];
            Console.WriteLine("Adja meg a számokat és összeadom őket:");
            for (int i = 0; i < Tomb.Length; i++)
            {
                Console.WriteLine(i + 1 + ". elem: ");
                Tomb[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A tömb elemeinek összege: " + Sum(Tomb));
        }
    }
}