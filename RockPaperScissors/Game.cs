using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        // Member variables
        List<string> moves;
        Player player1;
        Player player2;

        // Constructor
        public Game()
        {     
            // moves.Add("Rock");
            // moves.Add("Paper");
            // moves.Add("Scissors");
            // moves.Add("Lizard");
            // moves.Add("Spock");
        }

        // Functions
        public bool checkWinnerOfRound(string player1Move, string player2Move)
        {
            return true;
        }

        public string checkWinnerOfMatch(int player1Score, int player2Score)
        {
            return "";
        }

        public void gameSetup()
        {
            Console.WriteLine("Welcome to Rock, Paper, Stuff!");
            Console.WriteLine("You know the rules so we won't go over those.");
            Console.WriteLine("You'll be Player 1, please enter your name!");
            string player1Name = Console.ReadLine();
            player1 = new Player(player1Name, true);
            Console.WriteLine("Great! Your name is " + player1Name + ".");

            initializePlayer2();

            Console.WriteLine("It's time to start playing Rock, Paper, Stuff!");
        }

        public void initializePlayer2()
        {
            bool isP2Human = player2HumanOrAI();
           
            Console.WriteLine("Now let's enter a name for player 2!");
            string name = Console.ReadLine();
            player2 = new Player(name, isP2Human);
            Console.WriteLine("Great! Player 2's name is " + name + ".");
        }

        private bool player2HumanOrAI ()
        {
            string response = "0";
            Console.WriteLine("Now on to player 2. Are they human or AI?");
            while (response != "1" && response != "2")
            {
                Console.WriteLine("For human enter 1, and for AI enter 2.");
                response = Console.ReadLine();
                if (response != "1" && response != "2")
                {
                    Console.WriteLine("Oops! You've entered an invalid value.");
                }
            }
            return response == "1";
        }

    }
}
