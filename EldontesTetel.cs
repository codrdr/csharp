using System;

namespace Eldöntéstétel
{
    class Program
    {
        //Eldöntés tétel
        static bool Eldontes(int[] szamok)
        {
            foreach (int item in szamok)
            {
                if (item < 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] tomb = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool HasAnegative = Eldontes(tomb);

            if (HasAnegative) {
                Console.WriteLine("A tömbben van negatív szám.");
            }
            else
            {
                Console.WriteLine("A tömbben nincs negatív szám.");
            }
        }
    }
}