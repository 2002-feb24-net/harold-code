using System; // fixes the "error" of typing just "Console" and not "System.Console"

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        int PlayerWins;
        int ComputerWins;
        int Ties;

        public string[] WinRecord = new string[5];
        // max 5 rounds

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
            for (int i = 0; i < WinRecord.Length; i++)
            {
                System.Console.WriteLine("Round " + (i + 1) + ": ");
                // start at round 1
                System.Console.WriteLine(WinRecord[i]);
            }
            System.Console.WriteLine("--------------------------");
            System.Console.WriteLine("Player won: " + PlayerWins + " times");
            System.Console.WriteLine("Player tied: " + Ties + " times");
            System.Console.WriteLine("Player lost: " + ComputerWins + " times");
        }

        public void PlayRound()
        {
            for (int i = 0; i < WinRecord.Length; i++)
            {
                GetInput();
                SetCompChoice();    // new random choice
                OutputCompChoice();
                WinRecord[i] = WhoWon();
            }
            PrintSummary();

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
