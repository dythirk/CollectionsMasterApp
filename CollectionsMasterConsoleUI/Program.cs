using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();


            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50


            int[] Array = new int[50];


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            int[] rando50 = new int[50];
            for (int i = 0; i < rando50.Length; i++)
            {
                rando50[i] = rnd.Next(1, 51);
            }


            //TODO: Print the first number of the array

            Console.WriteLine($"First number: {rando50[0]}");

            //TODO: Print the last number of the array            

            Console.WriteLine($"Last number: {rando50[rando50.Length - 1]}");

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            NumberPrinter(rando50);


            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            //Array.Reverse(rando50);


            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(rando50);
            NumberPrinter(rando50);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            for (int i = 0; i < rando50.Length; i++)
            {
                if (rando50[i] % 3 != 0)
                    rando50[i] = rando50[i];
                else
                    rando50[i] = 0;
            }

            NumberPrinter(rando50);


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            //Array.Sort(rando50);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List

            List<int> iList = new List<int>();

            //TODO: Print the capacity of the list to the console

            Console.WriteLine($"List capacity:{iList.Count}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            for (int i = 0; i < 50; i++)

            {
                iList.Add(rnd.Next(1, 51));
            }

            //TODO: Print the new capacity

            Console.WriteLine($"List capacity:{iList.Count}");
            NumberPrinter(iList);


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            string response = Console.ReadLine();

            while (!response.All(char.IsDigit))
            
            { 
            Console.WriteLine("Please enter a number.");
            response = Console.ReadLine();
            }

            int user = int.Parse(response);
            Console.Write($"Does this list contain this user? {iList.Contains(user)}");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            for (int i = 0; i < iList.Count; i++)
            {
                if (iList[i] % 2 != 0)
                {
                    iList.RemoveAt(i);
                }
                else
                {
                    iList[i] = iList[i];

                }
            }


            NumberPrinter(iList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)
        {
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

        }        

        private static void ReverseArray(int[] array)
        {
            int[] revrev = new int[array.Length];
            int decrement = array.Length-1;
            for (int i = 0; i < array.Length; i++)
            {
                revrev[decrement] = array[i];
                decrement--;
            }

            for (int j = 0; j < array.Length; j++)
            {
                array[j] = revrev[j];
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
