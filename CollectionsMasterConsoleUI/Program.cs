using System;
using System.Collections.Generic;
using System.Linq;

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
            int[] myArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(myArray);
            Console.WriteLine("Random numbers 1-50");
            foreach (int number in myArray)
            {
                Console.Write(number + " ");
            }


            //TODO: Print the first number of the array
            Console.WriteLine(myArray[0]);

            //TODO: Print the last number of the array            
            Console.WriteLine(myArray[49]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(myArray);

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(myArray);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(myArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> myList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine("Capaacity: ");
            Console.WriteLine(myList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(myList);

            //TODO: Print the new capacity
            foreach (int number in myList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int inputNum;
            Console.WriteLine("Pick a number to see if it's in the list");
            string userInput = Console.ReadLine();
            bool canParse = int.TryParse(userInput, out inputNum);

            if (canParse)
            {
                NumberChecker(myList, inputNum);
            }
            else
            {
                Console.WriteLine("Please try again with a number.");
                Console.ReadLine();
            }        
    

    NumberChecker(myList, inputNum);


            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(myArray);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(myList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            myList.Sort();
            foreach (int numbbb in myList)
            {
                Console.WriteLine($"{numbbb} ");
            }
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newestArray = myList.ToArray();

            //TODO: Clear the list
            myList.Clear();

            #endregion
        }
        public static void NumbersOneThruFifty(int[] arr)
        {
        Random rand = new Random();
             for (int i = 0; i < arr.Length; i++)

            {
                arr[i] = rand.Next(51);
            }
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
                Console.WriteLine(numbers[i]);
            } 
        }

        private static void OddKiller(List<int> numberList)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int i in numberList)
                if (i % 2 == 0)
                {
                    evenNumbers.Add(i);
                }
            foreach (int numbs in evenNumbers)
                {
                Console.Write($"{numbs}, ");
                }
   
        }
    
    

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool off = false;
            {
                foreach (int number in numberList)
                {
                    if (off ==true)
                    {
                        break;
                    }
                    if (searchNumber == number)
                    {
                        Console.WriteLine("Your Number is in the list.");
                        off = true;
                    }
                    else
                    {
                        ;
                    }
                }
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < 51; i++)
            {
                numberList.Add(rng.Next(51));
            }
        }

        private static void Populater(int[] numbers)
        { 
        Random rand = new Random();
             for (int i = 0; i< numbers.Length; i++)

            {
                numbers[i] = rand.Next(51);
            }
}

private static void ReverseArray(int[] array)
        {
           Array.Reverse(array);
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
