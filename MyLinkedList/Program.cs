using LinkedListLib;
using System;
using System.Threading;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LameTest();
        /**    Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Completeing second test......");
            TestOne();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Completeing third test....");
            TestTwo();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Completeing fourth test....");
            Console.WriteLine("**WARNING : THIS IS A BIG TEST**....");
            Thread.Sleep(3000);
            BigTest(); **/
        }

        static void TestOne()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _2022_Spring_TannerEnsign_MyListLibrary<int> list = new _2022_Spring_TannerEnsign_MyListLibrary<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
                list.Add(i);
            int numbeChosen = rand.Next(20);
            Console.WriteLine($"I chose number {numbeChosen}, it is at the index {list.IndexOf(numbeChosen).ToString()}");
            numbeChosen = rand.Next(100);
            Console.WriteLine($"I chose number {numbeChosen}, is it in the list? {list.Contains(numbeChosen).ToString()}");
        }


        static void TestTwo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _2022_Spring_TannerEnsign_MyListLibrary<string> list = new _2022_Spring_TannerEnsign_MyListLibrary<string>();
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
                list.Add(i.ToString()
                );
            int numbeChosen = rand.Next(200);
            Console.WriteLine($"I chose number {numbeChosen}, it is at the index {list.IndexOf(numbeChosen.ToString()).ToString()}");
            numbeChosen = rand.Next(100);
            Console.WriteLine($"I chose number {numbeChosen}, is it in the list? {list.Contains(numbeChosen.ToString()).ToString()}");
        }


        static void BigTest()
        {
            for (int x = 0; x < 10; x++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                _2022_Spring_TannerEnsign_MyListLibrary<string> list = new _2022_Spring_TannerEnsign_MyListLibrary<string>();
                Random rand = new Random();
                int max = rand.Next(300);
                for (int i = 0; i < max; i++)
                    list.Add(i.ToString()
                    );
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Here is the list ");
                foreach (string str in list)
                    Console.Write($":{str}");
                int numbeChosen = rand.Next(600);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nI chose number {numbeChosen}, it is at the index {list.IndexOf(numbeChosen.ToString()).ToString()}");
                numbeChosen = rand.Next(600);
                Console.WriteLine($"I chose number {numbeChosen}, is it in the list? {list.Contains(numbeChosen.ToString()).ToString()}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Next test.......");
            }

        }


        static void LameTest()
        {
            _2022_Spring_TannerEnsign_MyListLibrary<string> list = new _2022_Spring_TannerEnsign_MyListLibrary<string>();
            list.Add("hello");
            list.Add("whatsup");
            list.Add("How");
            list.IndexOf("How");

            foreach (string str in list)
                Console.WriteLine($":{str}");

            Console.WriteLine("Removing.......");

            list.RemoveAt(1);

            foreach (string str in list)
                Console.WriteLine($":{str}");


            Console.WriteLine("Inserting......");

            list.Insert(1, "whatsup");

            foreach (string str in list)
                Console.WriteLine($":{str}");


            Console.WriteLine("Clearing......");

            list.Clear();


            foreach (string str in list)
                Console.WriteLine($":{str}");

        }
    }

}
