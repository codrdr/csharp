using System;

namespace MintaFeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kérd be egy téglalap két oldalának hosszát konzolon, majd írasd ki a területét és kerületét!
            Console.WriteLine("Kérlek add meg a téglalap magasságát:");
            int magassag = int.Parse(Console.ReadLine());

            Console.WriteLine("Kérlek add meg a téglalap szélességét:");
            int szelesseg = int.Parse(Console.ReadLine());

            int kerulet = (magassag + szelesseg) * 2;
            int terulet = (magassag * szelesseg);

            Console.WriteLine("A téglalap kerülete: " + kerulet + ".");
            Console.WriteLine("A téglalap területe: " + terulet + ".");

            //Olvass be egy számot konzolról és állapítsd meg, hogy az páros-e vagy páratlan!
            Console.WriteLine("Írj be egy számot, hogy eldönthessem páros-e vagy páratlan!");
            System.Int64 number = System.Int64.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }

            //Olvass be egy számot a konzolról és állapítsd meg, hogy az pozitív, negatív vagy nulla!
            Console.WriteLine("Írj be egy számot, hogy eldönthessem pozitív, negatív vagy nulla!");
            int number1 = int.Parse(Console.ReadLine());

            if (number1 > 0)
            {
                Console.WriteLine("Ez egy pozitív szám.");
            }
            else if (number1 < 0)
            {
                Console.WriteLine("Ez egy negatív szám.");
            }
            else
            {
                Console.WriteLine("A megadott szám 0.");
            }

            //Tölts fel egy tömböt véletlen számokkal! A tömb hosszát a konzolról olvasd be!
            Console.Write("Add meg a tömb hosszát:");
            int hossz = int.Parse(Console.ReadLine());
            
            int randomMinimum = 0;          /* Nulla és száz között generál, mert a nullát a nulladik elemnek veszi*/
            int randomMaximum = 101;        /* Ha 1-től 101-ig állítanánk be, akkor 1 és 100 között generálna.*/
            
            int[] tomb = new int[hossz];
            Random rnd = new Random();

            for (int i = 0; i < hossz; i++)
            {
                tomb[i] = rnd.Next(randomMinimum, randomMaximum);
                
                if (tomb[i] == 0 || tomb[i] == 100)
                {
                    Console.WriteLine(tomb[i]);
                }
            }

            /* Írj egy számkitalálós játékot! A program gondol egy számra (1 és 10 között), amit a játékosnak ki kell találni.
             * Ha a tizedik próbálkozásra sem sikerül, a program megmondja az eredményt.*/

            Random random = new Random();
            int computerNumber = random.Next(1, 11);

            int answerCounter = 0;

            bool match = false;

            while (!match && (answerCounter < 10))
            {
                Console.Write("Tippelj: ");
                int myNumber = int.Parse(Console.ReadLine());
                answerCounter ++;

                if (myNumber == computerNumber)
                {
                    match = true;
                    Console.WriteLine("Gratulálok, kitaláltad!");
                }
                else 
                {
                    Console.WriteLine("Nem talált! Ez volt a(z) " + answerCounter + ". ötleted.");
                    if (myNumber<computerNumber)
                    {
                        Console.WriteLine("Nagyobb számra gondoltam!");
                    }
                    else if(myNumber>computerNumber)
                    {
                        Console.WriteLine("Kisebb számra gondoltam!");
                    }
                }
                if (answerCounter == 10)
                {
                    Console.WriteLine("A megoldás: "+computerNumber);
                }
            }
            
            // Gyakorlófeladatok //
            
            // 1.Feladat: Olvasd be a konzolról egy gömb sugarát, és írasd ki a gömb felszínét és térfogatát!
            Console.WriteLine("Üdv! Írd be a gömb sugarát!");
            double r = double.Parse(Console.ReadLine());
            //Gömb felszínének kiszámítása:
            double A = (4*(r*r)*Math.PI);
            Console.WriteLine("A gömb felszíne: "+A);
            //Gömb térfogatának kiszámítása:
            double V = ((4*(r*r*r)*Math.PI)/3);
            Console.WriteLine("A gömb térfogata: "+V);

            // 3.Feladat: Tízszer egymás után kérj be számokat a konzolról és számold meg hányszor volt a bemenet pozitív, és
            // hányszor volt negatív! A tizedik bevitel után mutasd meg a statisztikát!*/
            // for ciklussal is megoldható.
            Console.WriteLine("Tízszer adj meg egymás után bármilyen számot (pozitív/negatív), majd statisztikát készítek belőle!");
            bool ciklus = false;
            int szamlalo = 0;
            int beker;
            
            int pozitiv = 0;
            int negativ = 0;

            while (!ciklus)
            {
                Console.WriteLine("Kérlek add meg a(z) "+(szamlalo+1) + ". számot: ");
                beker = int.Parse(Console.ReadLine());
                if (beker >= 0)
                {
                    pozitiv++;
                }
                else
                {
                    negativ++;
                }
                szamlalo++;
                if (szamlalo == 10)
                {
                    ciklus = true;
                    Console.WriteLine("Statisztika: " + szamlalo + "-ből " + pozitiv + " alkalommal volt pozitív a bekérés és " + negativ + " alkalommal negatív.");
                }
            }

            // 4. Feladat: 4-es mintafeladat átírása, hogy jelezze azt is, kisebb számra gondolt-e vagy nagyobbra.

            // 5. Feladat: Olvass be egy számot a konzolról egy és tíz között! Ha nullától kisebb, vagy tíztől nagyobb, addig
            // folytassa a bekérést, amíg a felhasználó megfelelő számot nem ad meg.

            bool trn = false;

            while (!trn)
            {
                Console.WriteLine("Adj meg egy számot egy és tíz között!");
                int szam = int.Parse(Console.ReadLine());

                if (szam < 1 || szam > 10) 
                {
                    Console.WriteLine("A megadott érték: " + szam+".");
                    Console.WriteLine("Hiba! 1 és 10 közötti értéket adj meg!");
                }
                else
                {
                    trn = true;
                    Console.WriteLine("A megadott érték: "+szam+".");
                }
            }       
        }
    }
}
