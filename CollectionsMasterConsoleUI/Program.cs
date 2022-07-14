using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var intArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(intArray);

            //TODO: Print the first number of the array
            Console.WriteLine(intArray[0]);

            //TODO: Print the last number of the array
            Console.WriteLine(intArray[intArray.Length - 1]);

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            //Array.Reverse(intArray);
            intArray = ReverseArray(intArray);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            NumberPrinter(intArray);
            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            intArray = ThreeKiller(intArray);
            NumberPrinter(intArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(intArray);


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var intList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {intList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            intList = Populater(intList);

            //TODO: Print the new capacity
            Console.WriteLine($"Capacity: {intList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            bool validInput;
            string input;
            int inputInt = -5;
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                input = Console.ReadLine();
                try
                {
                    inputInt = int.Parse(input);
                    validInput = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("That's not a number!");
                    validInput = false;
                }
            } while (validInput != true);
            Console.WriteLine($"{inputInt} in list: {intList.Contains(inputInt)}");
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(intList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            intList = OddKiller(intList);
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            intList.Sort();
            NumberPrinter(intList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var listToArray = intList.ToArray();

            //TODO: Clear the list
            intList.Clear();

            #endregion
        }

        private static int[] ThreeKiller(int[] numbers)
        {
            var noThrees = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                noThrees[i] = (numbers[i]%3==0)? 0 : numbers[i];
            }
            return noThrees;
        }

        private static List<int> OddKiller(List<int> numberList)
        {
            for (int i = 0; i < numberList.Count; i++)
            {
                while (numberList[i]%2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }
            return numberList;
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            
        }

        private static List<int> Populater(List<int> numberList)
        {
            Random rng = new Random();
            while (numberList.Count < 50)
            {
                numberList.Add(rng.Next(1,50));
            }
            return numberList;
        }

        private static int[] Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(1, 50);
            }
            return numbers;
        }        

        private static int[] ReverseArray(int[] array)
        {
            var reversed = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reversed[array.Length - i - 1] = array[i];
            }
            return reversed;
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
