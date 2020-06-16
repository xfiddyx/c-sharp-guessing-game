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




        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Hey, please enter your name");

            string nameInput = Console.ReadLine();

            string reply = askToPlay(nameInput);

            if (reply == "No problem, maybe another time")
            {
                Console.WriteLine(reply);
                Environment.Exit(0);
            }

              while (reply != "Great, let's get playing")
            {
              reply = askToPlay(nameInput);
            }
          
            Console.WriteLine(reply);

            Console.WriteLine("Let me just set up the game");

            var rand = new Random();

            int guessTheNum = rand.Next();

            Console.WriteLine("You have to guess the correct number, it will be between 1 and 20");

            Console.WriteLine("You have 5 attempts, i'll give you a clue after each try");






        }   
     }
    
}
