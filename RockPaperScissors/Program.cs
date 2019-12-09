using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main(string[] args)
        {

            string playerInput;
            Random rnd = new Random();
            bool playAgainTrue = true;

            while (playAgainTrue)
            {



                int cpuScore = 0;
                int playerScore = 0;
                int rockCount = 0;
                int paperCount = 0;
                int scissorsCount = 0;
                

                

                while (cpuScore < 3 && playerScore < 3)
                {

                    Console.Write("Please choose either Rock, Paper or Scissors: ");
                    playerInput = Console.ReadLine();
                    int randomInt = rnd.Next(1, 4);

                    //case will depend on which random integer is generated
                    switch (randomInt)
                    {
                        case 1:
                            //Case 1 is if the computer chooses ROCK
                            Console.WriteLine("Opponent has chosen Rock!");
                            rockCount++;
                            if (playerInput.ToLower() == "rock")
                            {
                                Console.WriteLine("It's a draw!");
                                rockCount++;
                            }
                            else if (playerInput.ToLower() == "paper")
                            {
                                Console.WriteLine("You have won! :)");
                                playerScore++;
                                paperCount++;
                            }
                            else if (playerInput.ToLower() == "scissors")
                            {
                                Console.WriteLine("You have lost! :(");
                                cpuScore++;
                                scissorsCount++;
                            }
                            break;
                        case 2:
                            //Case 2 is for the computer choosing PAPER
                            Console.WriteLine("Opponent has chosen Paper!");
                            paperCount++;
                            if (playerInput.ToLower() == "paper")
                            {
                                Console.WriteLine("It's a draw!");
                                paperCount++;

                            }
                            else if (playerInput.ToLower() == "rock")
                            {
                                Console.WriteLine("You have won! :)");
                                playerScore++;
                                rockCount++;
                            }
                            else if (playerInput.ToLower() == "scissors")
                            {
                                Console.WriteLine("You have lost! :(");
                                cpuScore++;
                                scissorsCount++;
                            }
                            break;
                        case 3:
                            //Case 3 is for the computer choosing SCISSORS
                            Console.WriteLine("Opponent has chosen Scissors!");
                            scissorsCount++;
                            if (playerInput.ToLower() == "scissors")
                            {
                                Console.WriteLine("It's a draw!");
                                scissorsCount++;

                            }
                            else if (playerInput.ToLower() == "rock")
                            {
                                Console.WriteLine("You have won this round! :)");
                                playerScore++;
                                rockCount++;
                            }
                            else if (playerInput.ToLower() == "paper")
                            {
                                Console.WriteLine("You have lost this round. :(");
                                cpuScore++;
                                paperCount++;
                            }
                            break;
                        default:
                            //if this shows then something is wrong with the Random
                            Console.WriteLine("Invalid input");
                            break;
                    }

                }
                //to make screen less cluttered and make it clear game has ended
                Console.Clear();

                //game will play until someone reaches score 3 then declare a winner

                Console.WriteLine(ScoreDisplay(playerScore, cpuScore, rockCount, paperCount, scissorsCount));
                

                //asks user if they want to play again, resets scores and counts if yes, closes if no

                Console.Write("Play again? (y/n) : ");
                string doYouWannaPlayAGame = Console.ReadLine();
                if (doYouWannaPlayAGame == "n")
                {
                    playAgainTrue = false;
                    Console.WriteLine("Thanks for playing! Press any key to exit.");
                    Console.ReadLine(); 
                }
                Console.Clear();


                                                                                                                   
            }
        }
        public static string ScoreDisplay(int pScore, int cScore, int rCount, int pCount, int sCount)
        {
            List<string> scoreOutput = new List<string>();

            if (pScore == 3)
            {
                scoreOutput.Add("You won the game!/n");

            }
            else if (cScore == 3)
            {
                scoreOutput.Add("Opponent has won this game!/n");

            }
            scoreOutput.Add("SCORES: Opponent {cScore} , YOU {pScore}/n Rock was used {rCOunt} times./n Paper was used {0} times./n Scissors was used {0} times.");
            return scoreOutput.ToString();
        }


    }
}
