using System;

namespace Maximumkeresés
{
    class Program
    {
        static int maxKeres(int[] Array)
        {
            int maxIndex = 0;
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > Array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        static void Main(string[] args)
        {
            int[] ertekek = { 20, 02, 23, 04, 54, 10, 10, 22, 71, 55, 44, 22, 33, 22, 63, 33, 22, 12, 32, 53, 43, 21 };
            Console.WriteLine("A tömbben szereplő legnagyobb érték indexe: {0} ", maxKeres(ertekek));
        }
    }
}
