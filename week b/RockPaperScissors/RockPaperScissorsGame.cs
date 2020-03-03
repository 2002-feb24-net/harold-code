using System; // fixes the "error" of typing just "Console" and not "System.Console"
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        int PlayerWins;
        int ComputerWins;
        int Ties;

        List<string> WinRecord = new List<string>();

        public string PlayerChoice;
        public string CompChoice;

        public string RandomCompChoice()
        {
            string[] choice = { "rock", "paper", "scissors" };
            Random Random = new Random();

            int index = Random.Next(0, 3);
            return choice[index];
        }

        void SetCompChoice()
        {
            CompChoice = RandomCompChoice();
        }

        public RockPaperScissorsGame()  //constructor
        {
            CompChoice = RandomCompChoice();
        }

        public void PlayRound() // main function
        {
            for (int i = 0; i < 6; i++) //max 6 rounds
            {
                GetInput();
                SetCompChoice();    // new random choice
                OutputCompChoice();
                WinRecord.Add( WhoWon() );
            }
            PrintSummary();

        }

        public void GetInput()
        {
            System.Console.WriteLine("Playing round!"
            + "\n" +
            "Choose rock, paper or scissors <rock/paper/scissors>");
            PlayerChoice = Console.ReadLine(); // can set bad input
        }

        public void OutputCompChoice()
        {
            System.Console.WriteLine("Computer chose to play:");
            System.Console.WriteLine(CompChoice);
            System.Console.WriteLine("--------------------------");
        }

        public void PrintSummary()
        {
            for (int i = 0; i < WinRecord.Count; i++)   // print round by round recap
            {
                System.Console.WriteLine("Round " + (i + 1) + ": ");
                // start at round 1
                System.Console.WriteLine(WinRecord[i]);
            }

            // amount of wins

            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Player won: " + PlayerWins + " times");
            System.Console.WriteLine("Player tied: " + Ties + " times");
            System.Console.WriteLine("Player lost: " + ComputerWins + " times");

            // print final winner (or print tie)

            if (PlayerWins > ComputerWins)
            {
                System.Console.WriteLine("======================");
                System.Console.WriteLine("You won!");
            }
            else if (PlayerWins < ComputerWins)
            {
                System.Console.WriteLine("======================");
                System.Console.WriteLine("Computer won. Better luck next time");
            }
            else
            {
                System.Console.WriteLine("======================");
                System.Console.WriteLine("You tied! Great match.");
            }

        }


        public string WhoWon()
        {
            if (PlayerChoice == "rock")
            {
                if (CompChoice == "paper")
                {
                    ComputerWins++;
                    return "computer won";
                }

                else if (CompChoice == "rock")
                {
                    Ties++;
                    return "tie";
                }
                else    //comp scissors
                {
                    PlayerWins++;
                    return "player won";
                }

            }
            else if (PlayerChoice == "paper")
            {
                if (CompChoice == "scissors")
                {
                    ComputerWins++;
                    return "computer won";
                }

                else if (CompChoice == "paper")
                {
                    Ties++;
                    return "tie";
                }
                else    //comp rock
                {
                    PlayerWins++;
                    return "player won";
                }

            }
            else if (PlayerChoice == "scissors")
            {
                if (CompChoice == "rock")
                {
                    ComputerWins++;
                    return "computer won";
                }

                else if (CompChoice == "scissors")
                {
                    Ties++;
                    return "tie";
                }
                else    //comp paper
                {
                    PlayerWins++;
                    return "player won";
                }

            }
            else
            {
                System.Console.WriteLine("Invalid input");
                return "invalid round";
            }
        }

    }
}
