using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Player
    {
        // Member variables
        string name;
        bool isHuman;
        int currentScore = 0;

        // Constructor
        public Player (string name, bool isHuman)
        {
            this.name = name;
            this.isHuman = isHuman;
            int currentScore = 0;            
        }

        // Functions
        public void humanOrAI ()
        {
            string response = "0";            

            while (response != "1" && response != "2")
            {
                Console.WriteLine("Is this player human (1) or AI (2)?");
                response = Console.ReadLine();
                if (response == "1")
                {
                    this.isHuman = true;
                }
                else if (response == "2")
                {
                    this.isHuman = false;
                }
                else
                {
                    Console.WriteLine("Oops, you entered an invalid response! Please enter 1 for Human and 2 for AI.");
                }                         
            }
        }        
    }
}
