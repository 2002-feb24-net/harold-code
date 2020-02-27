using System;

namespace StringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            string input = Console.ReadLine();
            string reversed = ReverseString(input);

            Console.WriteLine("Reversed: " + reversed);
            
        }

        static string ReverseString(string input)
        {
            string process = input;
            string final = ""; //empty

            foreach (char i in process)
            {
                string end = process.Substring( process.Length - 1); //get last character
                //final= final + end;    // place in final at start
                //Console.WriteLine("process start " + process);
                //Console.WriteLine("end is " + end);
                final += end;
                process = process.Remove(process.Length - 1); // remove last char for loop
                //Console.WriteLine("process end " + process);
                //Console.WriteLine("final in progress: " + final);



            }
            return final;
        }
    }
}
