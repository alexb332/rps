using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 0 for random choices or 1 for copycat from the computer opponent");
            int input;
            try { input = Console.ReadLine().ToCharArray()[0] - '0'; }
            catch { input = 2; }

            // Input validation
            while (input != 0 && input != 1)
            {
                Console.WriteLine("Invalid input, please enter 1 or 0");
                try { input = Console.ReadLine().ToCharArray()[0] - '0'; }
                catch { input = 2; }
            }

            Console.WriteLine("And would you like to play with lizard & spock? (Y/N)");
            char addYN;
            try { addYN = Console.ReadLine().ToLower().ToCharArray()[0]; }
            catch { addYN = 'x'; }

            // Input validation
            while (addYN != 'y' && addYN != 'n')
            {
                Console.WriteLine("Invalid input, please enter 'y' or 'n' for the respective game mode");
                try { addYN = Console.ReadLine().ToLower().ToCharArray()[0]; }
                catch { addYN = 'x'; }
            }

            Console.Clear();
            int previous = -1;
            if (addYN == 'y')
            {
                while (previous != -2)
                {
                    previous = rpsls(input, previous);
                }
            }
            else
            {
                while (previous != -2)
                {
                    previous = rps(input, previous);
                }
            }

        }

        static int rps(int compChoice, int prev)
        {
            Random rand = new Random();

            Console.WriteLine("ROCK PAPER SCISSORS");
            Console.WriteLine("Enter your option: ");
            Console.WriteLine("r = rock");
            Console.WriteLine("p = paper");
            Console.WriteLine("s = scissors");
            char choice;
            try { choice = Console.ReadLine().ToLower().ToCharArray()[0]; }
            catch { choice = 'x'; }

            // Input validation
            while (choice != 'r' && choice != 'p' && choice != 's')
            {
                Console.WriteLine("Invalid input, please enter one of r/p/s for your choice");
                try { choice = Console.ReadLine().ToLower().ToCharArray()[0]; }
                catch { choice = 'x'; }
            }


            Option player = new Option(choice);

            // Will get overwritten
            Option computer = new Option(0);

            if (compChoice == 0)
            {
                computer = new Option(rand.Next(3));
            }
            else if (compChoice == 1)
            {
                computer = previousChoiceRPS(prev, rand);
            }

            // Judge winner
            int outcome = Option.compareOption(player, computer);


            Console.WriteLine("You played:          " + player.getStr());
            Console.WriteLine("The computer played: " + computer.getStr());

            switch (outcome)
            {
                case 0:
                    Console.WriteLine("So it's a Draw");
                    break;
                case 1:
                    Console.WriteLine("You Win!");
                    break;
                case 2:
                    Console.WriteLine("You Lose :(");
                    break;
            }
            Console.WriteLine("Press Enter to play again or enter 'x' to quit");
            string leave = Console.ReadLine().ToLower();
            Console.Clear();


            // Return player choice for next round or exit
            if (leave != "x")
            {
                return player.getInt();
            }
            else
            {
                return -2;
            }
        }


        static int rpsls(int compChoice, int prev)
        {
            Random rand = new Random();

            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
            Console.WriteLine("Enter your option: ");
            Console.WriteLine("r = rock");
            Console.WriteLine("p = paper");
            Console.WriteLine("s = scissors");
            Console.WriteLine("l = lizard");
            Console.WriteLine("v = spock");
            char choice = Console.ReadLine().ToLower().ToCharArray()[0];

            // Input validation
            while (choice != 'r' && choice != 'p' && choice != 's' && choice != 'l' && choice != 'v')
            {
                Console.WriteLine("Invalid input, please enter one of r/p/s/l/v for your choice");
                try { choice = Console.ReadLine().ToLower().ToCharArray()[0]; }
                catch { choice = 'x';  }
            }


            OptionRPSLS player = new OptionRPSLS(choice);

            // Will get overwritten
            OptionRPSLS computer = new OptionRPSLS(0);

            if (compChoice == 0)
            {
                computer = new OptionRPSLS(rand.Next(5));
            }
            else if (compChoice == 1)
            {
                computer = previousChoiceRPSLS(prev, rand);
            }

            // Judge winner
            int outcome = OptionRPSLS.compareOption(player, computer);


            Console.WriteLine("You played:          " + player.getStr());
            Console.WriteLine("The computer played: " + computer.getStr());

            switch (outcome)
            {
                case 0:
                    Console.WriteLine("So it's a Draw");
                    break;
                case 1:
                    Console.WriteLine("You Win!");
                    break;
                case 2:
                    Console.WriteLine("You Lose :(");
                    break;
            }
            Console.WriteLine("Press Enter to play again or enter 'x' to quit");
            string leave = Console.ReadLine().ToLower();
            Console.Clear();


            // Return player choice for next round or exit
            if (leave != "x")
            {
                return player.getInt();
            }
            else
            {
                return -2;
            }
        }


        private static Option previousChoiceRPS(int prev, Random rand)
        {
            Option output;
            if (prev == -1)
            {
                // Random if first rotation
                output = new Option(rand.Next(3));
            }
            else
            {
                output = new Option(prev);
            }
            return output;
        }

        private static OptionRPSLS previousChoiceRPSLS(int prev, Random rand)
        {
            OptionRPSLS output;
            if (prev == -1)
            {
                // Random if first rotation
                output = new OptionRPSLS(rand.Next(5));
            }
            else
            {
                output = new OptionRPSLS(prev);
            }
            return output;
        }
    }
}