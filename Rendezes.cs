using System;

namespace Rendezés
{
    class Program
    {
        static void Main(string[] args)
        {
            //Buborékrendezés
            int[] Array = { 0, 9, 2, 7, -13};
            for (int i = Array.Length; i >= 0; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        var temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
            foreach (var item in Array)
            {
                Console.Write(item.ToString()+", ");
            }
            Console.ReadKey();
        }
    }
}