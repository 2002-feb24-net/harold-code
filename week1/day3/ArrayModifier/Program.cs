using System;

namespace ArrayModifier
{
    class Program
    {
        // accept input from user, list of numbers separated by spaces
        // interpret that as an int array
        // print the array's values back to the user
        // ask the user for some operation
        // print the array's new values to the user.
        static void Main(string[] args)
        {
            string input = GetInput();
            int[] array = InterpretStringAsArray(input);
            PrintArray(array);
            UserWhichOperation();

        }

        static void PrintArray(int[] a)
        {
            Console.WriteLine("Array Contents: ");
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static int[] InterpretStringAsArray(string str)
        {
            string[] stringArray = str.Split(' ');
            /*Console.WriteLine("string array = ");
            foreach (var item in stringArray)
            {
                Console.Write(stringArray[item] + " ");
            }
            Console.WriteLine();*/



            //int[] numArray = Array.ConvertAll(stringArray, int.Parse);
            int[] numArray = new int[stringArray.Length];

            for (int item = 0; item < stringArray.Length; item++)
            {
                numArray[item] = int.Parse(stringArray[item]);
                //Console.WriteLine("item is " + item);
                //Console.WriteLine("numarray[]" + numArray[item]);
            }

            /*foreach (var item in numArray)
            {
                numArray[item] = int.Parse(stringArray[item]);
                Console.WriteLine("item is " + item);
                Console.WriteLine("numarray[]" + numArray[item]);
            }*/


            /*Console.WriteLine("int array = ");
            foreach (var item in numArray)
            {
                Console.Write(item.ToString() + " ");
            }*/

            
            return numArray;
        }

        // any method is going to have
        // 1. a name
        // 2. a return value: either nothing (void), or some type e.g. int
            // what result does the method need to send back to the code that uses this method.
        // 3. a list of parameters (maybe empty)
            // does the method need any input from the code that uses it to do its job.
        static string GetInput()
        {
            Console.WriteLine("Give a list of numbers separated by spaces");
            return Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            int result = a + b;
            return result;
            // you use "return" to send the return value back to the
            // code that calls this method.
        }

        static void GetInputAdd()
        {
            Console.WriteLine("Enter two whole numbers to add together");
        }

        static void UserWhichOperation()
        {
            Console.WriteLine("Would you like to turn all numbers negative?" +
            "\n" +
            "OR do you want to delete all odd numbers?");
            string input = Console.ReadLine();

            if (input == "negative")
            {
                // TurnNegative();
                Console.WriteLine("Array is negative: # # # #");
                // for loop for each element
            }
            else if (input == "odd")
            {
                // TurnOdd();
                  Console.WriteLine("Array is odd: # # # #");
                // for loop for each element
            }
            
            else
            {
            Console.WriteLine("Command not found. Exiting...");
            }
        }
    }
}