using System;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {

            /*-------------------------- Számláló ciklus -----------------------------*/
            /*------------------------------------------------------------------------*/
            for (int i=0;i<100;i++) {
                Console.Write("Teszt");
            }
            
            Console.ReadLine();

            // Az i += 2 annyit jelent, mint i = i+2 
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine(i);
            }
            /*------------------------------------------------------------------------*/




            /*----------------------- Elöltesztelő ciklusok --------------------------*/
            /*------------------------------------------------------------------------*/

            /*
             *      while (true)
             *       {
             *           Console.Write("nem! ");     -Ez egy végtelen ciklusra való példa.
             *       }
            */

            bool permission = false;
            int toleranceLimit = 100;
            int requestCounter = 0;

            while (!permission)
            {
                requestCounter++;
                Console.WriteLine("Kérem szépen!");
                Console.WriteLine(requestCounter.ToString());

                if (requestCounter == toleranceLimit)
                {
                    permission = true;
                }
            }

            //Időközben rájöttem, hogy a "int x = int.Parse(Console.ReadLine());" parancs mire jó.
            //1. Az int x-szel eltárolunk egy integer típusú és x nevű változót.
            //2. Az int.Parse(); paranccsal típuskényszerítést alkalmazunk rajta, hogy a később beolvasott adatot ne stringként kezelje.
            //3. A Console.ReadLine(); metódussal beolvasott stringet eltároljuk egy integer típusú változóban (az x-ben).

            //Másik: a valami.ToString(); metódussal string típusúvá alakítjuk át az átalakítanivalónkat.

            // Tehát:
            // bool típuskényszerítés    : bool.Parse();
            // byte típuskényszerítés    : byte.Parse();
            // integer típuskényszerítés : int.Parse();
            // char típuskényszerítés    : char.Parse();
            // double típuskényszerítés  : double.Parse();
            // float típuskényszerítés   : float.Parse();
            // long típuskényszerítés    : long.Parse();
            // string típuskényszerítés  : .ToString();

        //Példa a .ToString(); metódusra:
            int asd = 23;
            int asd1 = 25;
            Console.WriteLine(asd.ToString() + asd1); //Mivel az asd string típusú ezért szövegként jelenik meg, nem lehet összeadni.
         //Példa az int.Parse(); metódusra:
            Console.WriteLine("Írj be egy számot:");
            int asd2 = int.Parse(Console.ReadLine());

            /*------------------------------------------------------------------------*/




            /*----------------------- Hátultesztelő ciklusok -------------------------*/
            // Az elnevezés logikus, hiszen először fut le a ciklusmag, és csak azután ellenőrzi a feltételt.
            // Pont emiatt, nagy a hibalehetőség és ritkán használjuk (csak nyomós indokkal!).

            int counter = 5;
            do
            {
                counter--;
                Console.WriteLine("A számláló nagyobb, mint 0.");
            } while (counter > 0);


            int counter1 = -3;                                          // Ez egy hibás kód, mivel a -3 nem nagyobb mint nulla,
            do                                                          // mégis lefut egyszer a kód. Ezért használjuk ritkán.
            {       
                counter1--;
                Console.WriteLine("A számláló nagyobb, mint 0.");
            } while (counter1 > 0);
        }
    }
}