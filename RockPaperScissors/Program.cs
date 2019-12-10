using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class Program
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

                Console.WriteLine(WinnerDisplay(playerScore, cpuScore));
                Console.WriteLine(ScoreDisplay(playerScore, cpuScore));
                Console.WriteLine(MovesDisplay(rockCount, paperCount, scissorsCount));
                

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
        public static string WinnerDisplay(int pScore, int cScore)
        {
            List<string> winnerOutputList = new List<string>();

            if (pScore == 3)
            {
                winnerOutputList.Add("You won the game!");

            }
            else if (cScore == 3)
            {
                winnerOutputList.Add("Opponent has won this game!");

            }
            
            string scoreOutput = string.Join("", winnerOutputList);
                         
            return scoreOutput;
        }

        public static string ScoreDisplay(int pScore, int cScore)
        {
            List<string> scoreOutputList = new List<string>();

            scoreOutputList.Add("SCORES: Opponent: " + cScore);  ;
            scoreOutputList.Add("YOU: " + pScore);
            

            string scoreOutput = string.Join(Environment.NewLine, scoreOutputList);

            return scoreOutput;
        }

        public static string MovesDisplay(int rCount, int pCount, int sCount)
        {
            List<string> movesOutputList = new List<string>();

            movesOutputList.Add("Rock was used: " + rCount + " times.");
            movesOutputList.Add("Paper was used: " + pCount + " times.");
            movesOutputList.Add("Scissors was used: " + sCount + " times.");

            string movesOutput = string.Join(Environment.NewLine, movesOutputList);

            return movesOutput;

        }


    }
}
