using System;

namespace GyakorlóProgram
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Tájékoztatás és adatbekérés:
            Console.WriteLine("Helló, kérlek add meg a nevedet:");
            string name = Console.ReadLine();
            Console.WriteLine("Kérlek add meg a születési dátumodat az alábbi formában:");
            Console.WriteLine("[ÉÉÉÉ.HH.NN]");

            /* Eltároljuk a születési időt egy DateTime metódussal.
             * Mivel minden amit a konzolon keresztül beírunk String típusú, ezért át kell alakítani Dátum típusúvá a beírt adatot.
             */
            DateTime szuletes = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Köszönöm!");

            /* Ahhoz, hogy megállapítsd, mennyi idő telt el a születési ideje óta, ki kell vonni a mai dátumot a születésnapéból.
             * A mai nap a DateTime.Now-on keresztül érhető el. Ebből a .Substract(szuletes) művelettel kivonhatod a születésnap
             * időpontját, és a .Days segítségével kiolvashatod az azóta eltelt napok számát. Ha az eredményt elosztod 365.25-tel
             * (azért 365.25, mert figyelembe vesszük a szökőéveket is), megkapod az eltelt évek számát tizedes tört formában.
             */
            double kor = DateTime.Now.Subtract(szuletes).Days / 365.25;

            /* A String.format() metódust szövegkezelésre használjuk. A változók helyét ezzel a metódussal ki lehet hagyni és a kapcsos
             * zárójelek között megjelölöd, hogy melyik argumentumot kell az adott helyen megjeleníteni. Az első (nulladik!) indexen a 
             * name változó foglal helyet, ennek értékét fogja megjeleníteni. Tehát: {0} egyenlő név, {1} egyenlő kor.
             * (int)kor: Integer típusúvá alakítja át a kor változó értékét, mivel alapból double típusban tároltuk el a pontos érték
             * kiszámítása érdekében. Így olvasható formátumúvá válik (egész szám).
             */
            Console.WriteLine(String.Format("Szia {0}, te {1} éves vagy.", name, (int)kor));
            Console.ReadLine();

            //Ez a program azt dönti el, hogy a felhasználó által beírt érték nagyobb e mint nulla vagy sem.
            Console.WriteLine("Kérlek adj meg egy számot, hogy eldöntsem nagyobb-e mint nulla.");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Ez a szám pozitív.");
            }
            else
            {
                Console.WriteLine("Ez a szám kisebb mint nulla.");
            }
            Console.WriteLine("Nyomj entert a folytatáshoz!");
            Console.ReadLine();

            //Ez a program összeadja két szám értékét a felhasználó által beírt értékek alapján.
            Console.WriteLine("Ez a program összeadja két szám értékét.");
            Console.WriteLine("Kérlek, adj meg egy számot:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérlek, adj meg még egy számot:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("A beírt számok összege: " + (a+b));
            Console.WriteLine("Nyomj entert a folytatáshoz!");
            Console.ReadLine();

            //Lényegében két külön változóban tároljuk el az értéket majd azzal dolgozunk.
            //Ha az if-re igaz a benne lévő feltétel (feltetel = y > 0), akkor az értéke igaz.
            Console.WriteLine("Kérem, adjon meg egy számot:");
            int y = int.Parse(Console.ReadLine());
            bool feltetel = y > 0;
            if (feltetel)
            {
                Console.WriteLine("A szám nagyobb mint nulla.");
            }
            else
            {
                Console.WriteLine("A szám kisebb mint nulla.");
            }
            Console.WriteLine("Nyomj entert a folytatáshoz!");
            Console.ReadLine();

            //Logikai ÉS/VAGY/NEGÁLÁS(INVERTÁLÁS):
            //Biztonsági őr kontextusban való tesztelés:
            //Értékek eltárolása:
            bool smellsDrunk = false;
            bool movesUnsecure = false;
            bool hasAGun = false;

            bool risky = smellsDrunk && movesUnsecure;
            bool dangerous = smellsDrunk && movesUnsecure && hasAGun;

            Console.WriteLine("Körbenézel. Látsz valakit aki egyértelműen részeg? (igen/nem)");
            string igen = Console.ReadLine();
            if (igen.Equals("igen"))
            {
                smellsDrunk = true;
                Console.WriteLine("Megnézed közelebbről. Furcsán mozog az illető?");
                igen = Console.ReadLine();

                if (igen.Equals("igen"))
                {
                    movesUnsecure = true;
                    Console.WriteLine("Van fegyvere?");
                    igen = Console.ReadLine();

                    if (igen.Equals("igen"))
                    {
                        hasAGun = true;
                        Console.WriteLine("Az illető veszélyes, hívd a rendőröket.");
                    }
                    else if (igen.Equals("nem"))
                    {
                        Console.WriteLine("Nincs probléma, az illető be van baszva.");
                    }
                }
                else if (igen.Equals("nem"))
                {
                    Console.WriteLine("Nincs probléma, az illető csak sokat ivott.");
                    Console.WriteLine("Látsz bárkit aki furcsán mozog?");
                    igen = Console.ReadLine();

                    if (igen.Equals("igen"))
                    {
                        movesUnsecure = true;
                        Console.WriteLine("Odamész és megkérdezed jól van -e. Mit válaszol? (igen/nem)");
                        igen = Console.ReadLine();
                        if (igen.Equals("igen"))
                        {
                            Console.WriteLine("Őrködsz tovább.");
                        }

                        else if (igen.Equals("nem"))
                        {
                            Console.WriteLine("Hívod a mentőket.");   
                        }
                    }

                    else if (igen.Equals("nem")) 
                    {
                        Console.WriteLine("Látsz bárkinél fegyvert?");
                        igen = Console.ReadLine();

                        if (igen.Equals("igen"))
                        {
                            hasAGun = true;
                            Console.WriteLine("Hívod a rendőröket.");
                        }

                        else if (igen.Equals("nem"))
                        {
                            Console.WriteLine("Őrködsz tovább.");
                        }
                    }
                }
            }


            if (risky)
            {
                Console.WriteLine("Ez az alak kockázatos, mert részeg és furcsán mozog. Dobd ki.");
            }

            else if (dangerous)
            {
                Console.WriteLine("Ez az alak veszélyes, mert fegyvere van. Hívd a rendőrséget.");
            }

            else if (smellsDrunk == false && movesUnsecure == false && hasAGun == false)
            {
                Console.WriteLine("Nincs mit tenni, mindenki jól érzi magát.");
            }
        }
    }
}