using System;
namespace C_Sharp_Crash_Couese
{
    internal class RockPaperScissors
    {
        public void Show()
        {
            Random random = new Random();
            bool playAgain = true;
            String playerChoice;
            String computerChoice;
            String answer;

            while (playAgain)
            {
                playerChoice = "";
                computerChoice = "";
                answer = "";

                while (playerChoice != "ROCK" && playerChoice != "PAPER" && playerChoice != "SCISSORS")
                {
                Console.Write("Enter: ROCK, PAPER, SCISSORS: ");
                playerChoice = Console.ReadLine();
                playerChoice = playerChoice.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1: 
                        computerChoice = "ROCK";
                        break;

                    case 2:
                        computerChoice = "PAPER";
                        break;
                    case 3:
                        computerChoice = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + playerChoice);
                Console.WriteLine("Computer: " + computerChoice);

                switch (playerChoice) {
                    case "ROCK":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("Its a Draw!");
                        } 
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else
                        {
                            Console.WriteLine("You Won!");
                        }
                        break;
                    case "PAPER":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You Won!");
                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("Its a Draw!");
                        }
                        else
                        {
                            Console.WriteLine("You Lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computerChoice == "ROCK")
                        {
                            Console.WriteLine("You Lose!");

                        }
                        else if (computerChoice == "PAPER")
                        {
                            Console.WriteLine("You Won!");
                        }
                        else
                        {
                            Console.WriteLine("Its a Draw!!");
                        }
                        break;
                }

                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y") 
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
