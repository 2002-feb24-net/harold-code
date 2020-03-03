using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;
            while (!readyToQuit)
            {
                System.Console.WriteLine("Do you want to play a round? (y/n)");
                string input = Console.ReadLine();

                if (input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    game.PlayRound();
                }
            }

            game.PrintSummary();
            // how many wins, how many losses
        }
    }
}
