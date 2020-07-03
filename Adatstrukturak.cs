using System;
using System.Collections.Generic;

namespace Adatstruktúrák
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Verem
            Stack<KeyValuePair<int, string>> browserHistory = new Stack<KeyValuePair<int, string>>();
            string[] urls = { "google.com", "facebook.com", "gmail.com", "stackowerflow.com" };

            for (int i = 0; i < urls.Length; i++)
            {
                KeyValuePair<int, string> current = new KeyValuePair<int, string>(i, urls[i]);
                browserHistory.Push(current);
                Console.WriteLine(string.Format("{0} was pushed to stack with id {1}", current.Value, current.Key));
            }

            for (int i = 0; i < urls.Length; i++)
            {
                KeyValuePair<int, string> current = browserHistory.Pop();
                Console.WriteLine(string.Format("Reading: url: {0}, stack id: {1}", current.Value, current.Key));
            }

            Stack<string> szovegek = new Stack<string>();
            
            Console.WriteLine("Szia, kérlek add meg a böngészési előzményeid méretét!");
            
            int size = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Kérlek, add meg a böngészési előzményeid:");
            
            for (int i = 0; i < size; i++)
            {
                string str = Console.ReadLine();
                szovegek.Push(item: str);
            }

            Console.WriteLine("A beolvasott előzmények: ");

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(szovegek.Pop());
            }

            */
            // Stack manually
            Stack<KeyValuePair<int, string>> StackHistory = new Stack<KeyValuePair<int, string>>();

            System.Console.Write("Please give the size of the stack:");

            int sizeOfStack = int.Parse(Console.ReadLine());

            Console.WriteLine("Please, give me the links, what you opened:");

            string[] stackItems = new string[sizeOfStack];

            for (int i = 0; i < sizeOfStack; i++)
            {
                stackItems[i] = System.Console.ReadLine();
            }

            // Stack feltöltése:

            for (int i = 0; i < sizeOfStack; i++)
            {
                KeyValuePair<int, string> temp = new KeyValuePair<int, string>(i, stackItems[i]);
                StackHistory.Push(item: temp);
                Console.WriteLine(string.Format("{0} was pushed into stack with id {1}", temp.Value, temp.Key));
            }

            // Stack kiolvasása:

            for (int i = 0; i < sizeOfStack; i++)
            {
                KeyValuePair<int, string> temp = StackHistory.Pop();
                Console.WriteLine(string.Format("{0} was popped out from the stack with id {1}", temp.Value, temp.Key));
            }
        }
    }
}
