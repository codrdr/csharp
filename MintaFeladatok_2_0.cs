using System;
using System.Collections.Generic;

namespace Mintafeladatok_2._0
{
    class Program
    {
        /*
        static bool Vane(int[] elsotomb, int masodiktomb)
        {
            foreach (int item in elsotomb)
            {
                if (item == masodiktomb)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] Unio(int[] elsotomb, int[] masodiktomb)
        {
            int kozoselemekszama = 0;

            foreach (int item in masodiktomb)
            {
                if (Vane(elsotomb, item))
                {
                    kozoselemekszama++;
                }
            }

            int index = 0;
            
            for (index = 0; index < masodiktomb.Length; index++)
            {
                if (Vane(elsotomb,index))
                {
                    kozoselemekszama++;

                }
            }
            int[] kozoselemek = new int[kozoselemekszama];
            for (int i = 0; i < kozoselemekszama; i++)
            {
                kozoselemek[i] = Vane(elsotomb.ToString, index);
            }

            return kozoselemek;
        }

        */


        //Add meg két tömb unióját (az eredménytömbben minden szám csak 1x szerepelhet!)
        static bool HasValue(int[] collection, int data)
        {                                                                     // ----- Negyedik Program ------ \\
            foreach (int item in collection)
            {
                if (item == data)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] CreateUnion(int[] opA, int[] opB)
        {
            int countOfCommonItems = 0;
            
            foreach (int item in opB)
            {
                if (HasValue(opA, item))
                {
                    countOfCommonItems++;
                }
            }
            int unionLength = opA.Length + opB.Length - countOfCommonItems;
            
            int[] result = new int[unionLength];
            
            int index;

            for (index = 0; index < opA.Length; index++)
            {
                result[index] = opA[index];
            }

            foreach (int item in opB)
            {
                if (HasValue(opA, item))
                {
                    result[index] = item;
                    index++;
                }
            }
            return result;
        }
        

        //Tölts fel egy tömböt véletlen számokkal 1 és 100 között, majd számold meg, hány van 10 fölött!
        static int[] RandomszamokGeneral(Random random, int meret)
        {
            int[] eredmeny = new int[meret];
            for (int i = 0; i < meret; i++)                                // ----- Harmadik Program ----- \\
            {
                eredmeny[i] = random.Next(1, 101);
            }
            return eredmeny;
        }

        static int Mennyivan10felett(int[] gyujtemeny, int threshold)
        {
            int count = 0;
            foreach (int item in gyujtemeny)
            {
                if (item > threshold)
                {
                    count++;
                }
            }
            return count;
        }

        //Egy tömbben tárolj el szavakat, majd kérj be egy stringet a felhasználótól és állapítsd meg, hogy az adott szó benne van-e a tömbben.
        static bool Contains(string[] Words, string Userword)             // ----- Második Program ----- \\
        {
            foreach (string item in Words)
            {
                if (item == Userword)
                {
                    return true;
                }
            }
            return false;
        }

        //Ez a program előállítja a következő sorozat első 10 elemét: 1;-2;3;-4  // ----- Első program ----- \\
        static int[] FirstNumbersOfAnArray(int length)
        {
            int[] array = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                if (i%2 == 0)
                {
                    array[i] = -1 * i;
                }
                else
                {
                    array[i] = i;
                }
            }
            return array;
        }
        
        static void Main(string[] args)
        {   
            
            // Első program
            int[] first10 = FirstNumbersOfAnArray(10);

            foreach (int number in first10)
            {
                Console.Write(number + ", ");
            }
            Console.ReadLine();


            // Második program
            Console.WriteLine("Írj be egy szót.");

            string[] tomb = { "első", "második", "negyedik", "ötödik"};

            string szo = Console.ReadLine();

            bool vane = Contains(tomb, szo);

            if (vane)
            {
                Console.WriteLine("A(z) {0} szó szerepel a listában.", szo);
            }
            else
            {
                Console.WriteLine("A(z) {0} szó nem szerepel a listában.", szo);
            }

            // Harmadik program
            Random sourceOfRandomness = new Random();

            int[] numbers = RandomszamokGeneral(sourceOfRandomness, 10);

            int szamoktizfelett = Mennyivan10felett(numbers, 10);

            Console.WriteLine("Számok 10 felett a tömbben: {0}db.",szamoktizfelett);

            Console.Read();

            // Negyedik program
            int[] elso = { 1, 2, 3, 4, 5, -6, -7, 8, -9, 10 };
            int[] masodik = { 1, 2, -3, -4, -5, 6, -7, -8, 9, 10 };
            int[] eredmeny = CreateUnion(elso, masodik);

            for (int i = 0; i < eredmeny.Length; i++)
            {
                Console.Write("{0}, ",eredmeny[i]);
            }
            
            /*int[] tomb1 = { 1, 2, 3, 4, 5 };
            int[] tomb2 = { 2, 3, -4, -5 };

            int[] currentResult = CreateUnion(tomb1, tomb2);
            
            int[] Result = new int[currentResult.Length];

            foreach  (int eredmeny in Result)
            {
                Console.Write(eredmeny+", ");
            }
            */
        }
    }
}