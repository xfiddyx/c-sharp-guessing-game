using System;
using System.Collections.Generic;

namespace guessinggame
{
    class Program
    {

        public static string playGameAnswer(char answerInput)
        {
            if (char.ToLower(answerInput) == 'y')
            {
                return "Great, let's get playing";
            }
            else if (char.ToLower(answerInput) == 'n')
            {
                return "No problem, maybe another time";
            }
            else return "that's not an answer i can ";

        }

        private static string askToPlay(string nameInput)
        {
            Console.WriteLine($"Hey, {nameInput}, do you want to play a game?");

            Console.WriteLine("Y/N");

            char answerInput = Console.ReadKey().KeyChar;
            return playGameAnswer(answerInput);
        }

        public static bool guessChecker(int setNum, int guessedNum)
        {
            return guessedNum != setNum ? false : true;

        }

        public static string howCloseSum(int setNum, int guessedNum)
        {

            return setNum < guessedNum ? "lower" : "higher";
        }

        public static string guessTheNumberInput()
        {
            return Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Hey, please enter your name");

            string nameInput = Console.ReadLine();

            string reply = askToPlay(nameInput);

            if (reply == "No problem, maybe another time")
            {
                Console.WriteLine(" ");
                Console.WriteLine(reply);
                Environment.Exit(0);
            }

            while (reply != "Great, let's get playing")
            {
                reply = askToPlay(nameInput);
            }

            Console.WriteLine(reply);

            Console.WriteLine("Let me just set up the game");

            while (true)
            {

                var rand = new Random();

                int guessTheNum = rand.Next(20);

                Console.WriteLine("You have to guess the correct number, it will be between 1 and 20");

                Console.WriteLine("You have 5 attempts, i'll give you a clue after each try");

                Console.WriteLine("Let's start, have a guess...");


                string inputGuess = guessTheNumberInput();


                int attempts = 5;


                bool guess = guessChecker(guessTheNum, int.Parse(inputGuess));


                while (guess == false && attempts > 0)
                {
                    string howClose = howCloseSum(guessTheNum, int.Parse(inputGuess));
                    attempts--;
                    Console.WriteLine("You need to go {0}, you have {1} attemps left", howClose, attempts);
                    inputGuess = guessTheNumberInput();
                    guess = guessChecker(guessTheNum, int.Parse(inputGuess));
                }

                if (attempts == 0)
                {
                    Console.WriteLine("You lose");
                }
                else if (guess == true)
                {
                    Console.WriteLine("You Win");
                }

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
    }

}
