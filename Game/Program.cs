using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {       
       public static void Main(string[] args)
        {
            int round = 1;
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            bool playAgain = true;
            

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Rock");
            dict.Add(2, "Paper");
            dict.Add(3, "Scisors");


            while (playAgain && round <= 100)
            {
                Console.WriteLine("Player one has selected 1-Rock! Press enter for random selection of player two");
                Console.ReadLine();
                Random rand = new Random();
                int randomSelect = rand.Next(1, dict.Count + 1); 

                Console.WriteLine("Random selection is " + randomSelect + "-" + dict.GetValueOrDefault(randomSelect));
                Console.WriteLine("\n" + getResult(randomSelect));


                string playInp;
                Console.WriteLine("\n Do you want to play again? Please enter  \"y\" or \"n\" ");
                playInp = Console.ReadLine();

                if (playInp == "y")
                {
                    playAgain = (true);
                    round++;
                }
                else 
                {
                    playAgain = (false);
                }
            }


            Console.WriteLine("You have played " + round + " times \nWins: " + win + "\nLose: " + lose + "\nTie: " + tie);


            Console.ReadLine();
        }
        public static int win = 0, lose = 0, tie = 0;
        private static string getResult(int selection)
        {
            string result = string.Empty;
            if (selection == 1)
            {
                result = "It is a tie";
                tie++;
            }
            if (selection == 2)
            {
                result = "It is a lose";
                lose++;
            }
            if (selection == 3)
            {
                result = "It is a win";
                win++;
            }
            return result;
        }        
    }   
}
