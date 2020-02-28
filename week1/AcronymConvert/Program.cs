using System;

namespace AcronymConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;
            input = GetInput();
            output = GenerateAcronym(input);
            Console.WriteLine("Acronym: " + "\n" +
            output);
        }

        static string GetInput()
        {
            System.Console.WriteLine("Enter a word to turn into an acronym:" + "\n" +
            "ex: central processing unit");
            return Console.ReadLine();
        }

        static string GenerateAcronym(string fullWord)
        {
            string [] splitWords = fullWord.Split(' ');
            string finalAcronym = "";   //empty string for operation
            for (int i = 0; i < splitWords.Length; i++)
            {
                string letter = splitWords[i].Substring(0, 1);  //get first char of each letter
                letter = letter.ToUpper();  // capitalize each letter for acronym
                finalAcronym += letter;

            }
            return finalAcronym;
        }
    }
}
