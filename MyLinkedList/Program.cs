using LinkedListLib;
using System;
using System.Threading;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /**LameTest();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Completeing second test...");

            TestOne();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Completeing third test...");

            TestTwo();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Completeing fourth test...");
            Console.WriteLine("**WARNING : THIS IS A BIG TEST**...");
            Thread.Sleep(3000);


            BigTest(); **/


            intSortingTest();
            stringTest();


        }


        /// <summary>
        /// Calls insertionSort on a linked list of integers
        /// </summary>
        static void intSortingTest()
        {
            _2022_Spring_TannerEnsign_MyListLibrary<int> arr = new _2022_Spring_TannerEnsign_MyListLibrary<int>();

              Random rand = new Random();

              for (int i = 0; i < 10; i++)
             {
                 arr.Add(rand.Next(100));
             }

            Console.WriteLine(arr.ToString());

            arr.insertionSort();

            Console.WriteLine(arr.ToString());

        }

        /// <summary>
        /// Calls insertionSort on a linked list of strings
        /// </summary>
        static void stringTest()
        {
            _2022_Spring_TannerEnsign_MyListLibrary<string> arr = new _2022_Spring_TannerEnsign_MyListLibrary<string>();


            arr.Add("hello");
            arr.Add("Tanner");
            arr.Add("A");

            Console.WriteLine(arr.ToString());

            arr.insertionSort();

            Console.WriteLine(arr.ToString());
        }

        /// <summary>
        /// Adds 20 ints to the list, then finds the index of a random int
        /// </summary>
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

        /// <summary>
        /// Inserts 100 strings and checks the count, along with index and contains.
        /// </summary>
        static void TestTwo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            _2022_Spring_TannerEnsign_MyListLibrary<string> list = new _2022_Spring_TannerEnsign_MyListLibrary<string>();
            Random rand = new Random();

            for (int i = 0; i < 100; i++)
                list.Add(i.ToString());

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
                    list.Add(i.ToString());

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Here is the list ");

                foreach (string str in list)
                    Console.Write($":{str}");

                int numbeChosen = rand.Next(600);


                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nI chose number {numbeChosen}, it is at the index {list.IndexOf(numbeChosen.ToString()).ToString()}");

                numbeChosen = rand.Next(600);

                Console.WriteLine($"I chose number {numbeChosen}, is it in the list? {list.Contains(numbeChosen.ToString()).ToString()}");


                if (list.Contains(numbeChosen.ToString()))
                {
                    Console.WriteLine($"I will now remove the item at {numbeChosen}");
                    list.RemoveAt(numbeChosen);
                }
                else
                {
                    Console.WriteLine($"I will now add the item at {numbeChosen} and it will be the number {numbeChosen}");
                    list.Insert(numbeChosen, numbeChosen.ToString());
                }

                foreach (string str in list)
                    Console.Write($":{str}");

                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Printing whole list as string.........................");

                Console.WriteLine(list.ToString());

                Console.WriteLine("Next test.........................");

            }

        }

        /// <summary>
        /// Small test to test adding and index of.
        /// </summary>
        static void LameTest()
        {
            _2022_Spring_TannerEnsign_MyListLibrary<string> list = new _2022_Spring_TannerEnsign_MyListLibrary<string>();

            list.Add("hello");
            list.Add("whatsup");
            list.Add("How");

            foreach (string str in list)
                Console.WriteLine($"{str}");


            list.Insert(1, "hello");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Inserted an item");

            Console.ResetColor();

            foreach (string str in list)
                Console.WriteLine($"{str}");


            list.RemoveAt(1);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Removed an item");

            Console.ResetColor();

            foreach (string str in list)
                Console.WriteLine($"{str}");

        }
    }

}
