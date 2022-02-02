using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class GuessingGame
    {
        static Random r = new Random();
        private const int maxGuesses = 5;
        private static int maxBound;
        private static int guesses;
        private static int randNum;
        private static List<int> numsGuessed;
        private static bool keepPlaying = true;
        private static bool isWinner;
        private static bool valid;


        public static void PlayGame()
        {
            #region The Sudo Code

            //DO LOOP (GAME LOOP)
                /** Difficulty Method
                //prompt user for game difficulty
                //set max bound of the random num range based on difficulty selected
                    // IfF Diff is Easy 
                        //maxBound = 1-10
                    // ELSE IF diff is Medium
                        //maxBound = 50
                    // ELSE Hard 
                        //maxBound = 100
                //Select a random number using the maxBound
                **/

                /** GameTurn Method
                //Set Guesses to 0 (Reset Game State)
                //Initialize the numsGuesses collection

                //DO LOOP (TURN LOOP)
                    //Print current game state (num of attempts left, list of nums guessed)

                    //prompt the user for a valid guess
                        //IF not valid, re-prompt

                    //Reduce number of attempts by 1
                    //record the guess to the guessedNums array
                    //Compair the users guess to the random number
                        //IF the input equals the random num
                            //SET isWinner to true
                        //ELSE IF input is less that random num
                            //Inform user too low
                        //ELSE 
                            //Inform user is too high
                //WHILE guesses greater that 5 and isWinner is false 

                //Inform the user of the outcome, (Win or Loss; reveal the answer)
                //Prompt for "Play again?"
                **/

            //WHILE keepPlaying is true
            #endregion

            do
            {
                Difficulty();
                ResetGuesses();
                GameTurn();
            } while (keepPlaying == true);
        }


        public static void Difficulty()
        {
            bool getInput = false;
            int userInput = 0;


            //CHOICES:
            Console.WriteLine("Select your difficulty: ");
            Console.WriteLine("1. Easy – range = 1-10, max attempts = 5");
            Console.WriteLine("2. Medium – range = 1 - 50, max attempts = 5");
            Console.WriteLine("3. Hard – range = 1 - 100, max attempts = 5");
            Console.WriteLine();

            while (!getInput)
            {
                Console.Write("Please pick a number between 1 and 3: ");
                getInput = int.TryParse(Console.ReadLine(), out userInput);
                if (userInput <= 0 || userInput >= 4)
                {
                    getInput = false;
                }
            }

            if (getInput)
            {
                if (userInput == 1)
                {
                    maxBound = 10;
                    randNum = r.Next(maxBound) + 1;
                }
                else if (userInput == 2)
                {
                    maxBound = 50;
                    randNum = r.Next(maxBound)+1;
                }
                else
                {
                    maxBound = 100;
                    randNum = r.Next(maxBound)+1;
                }
            }

        }

        public static void ResetGuesses()
        {
            numsGuessed = new List<int>();
            guesses = 0;
            isWinner = false;
        }

        public static void Validate(int guess)
        {
            valid = true;
            foreach (int g in numsGuessed)
            {
                if (g == guess)
                {
                    valid = false;
                    Console.WriteLine("Number already used");
                    break;
                }
            }
        }

        public static void End()
        {
            int contineu;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("would you like to play again?");
                Console.WriteLine("");
                Console.Write("1. Yes or 2. No : ");


            } while (!int.TryParse(Console.ReadLine(), out contineu));

            if (contineu == 1)
            {
                keepPlaying = true;
            }
            else
            {
                keepPlaying = false;
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void GameTurn()
        {
            do //Turn Loop
            {
                
                int guess = 0;
                Console.WriteLine("");
                Console.WriteLine("Number of guesses: " + guesses);
                Console.Write("Numbers already used: ");
                Console.WriteLine(String.Join(",", numsGuessed));
                Console.WriteLine();

                Console.WriteLine("Plase enter in a number between 1 and " + maxBound);
                
                
                valid = false;
                do
                {

                    Console.WriteLine();
                    Console.Write("> ");
                    if (int.TryParse(Console.ReadLine(), out guess))
                    {
                        Validate(guess);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                    
                } while (!valid); // Valid Input Loop

                Console.WriteLine();
                numsGuessed.Add(guess);
                guesses++;
                if (guess == randNum)
                {
                    isWinner = true;
                }
                else if (guess < randNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("Lower");
                }

            } while (guesses < 5 && !isWinner);

            if (isWinner)
            {
                Console.WriteLine("");
                Console.WriteLine("You got it! It took you " + guesses + " guess(es)");
                End();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("game over, you ran out of guesses");
                End();
            }
        }

    }





}
