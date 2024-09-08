using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 0 for random choices or 1 for copycat from the computer opponent");
            int input = Console.ReadLine().ToCharArray()[0] - '0';
            int previous = -1;
            while (true)
            {
                Console.WriteLine(previous);
                previous = baseRPS(input, previous);
                Console.ReadLine();
                Console.Clear();
            }


        }

        static int baseRPS(int compChoice, int prev)
        {
            Random rand = new Random();

            Console.WriteLine("Enter your option (r/p/s)");
            char choice = Console.ReadLine().ToLower().ToCharArray()[0];
            Option player = new Option(choice);

            // Will get overwritten
            Option computer = new Option(0);

            if (compChoice == 0)
            {
                computer = new Option(rand.Next(3));
            }
            else if (compChoice == 1)
            {
                computer = previousChoice(prev, rand);
            }

            // Judge winner
            int outcome = Option.compareOption(player, computer);


            Console.WriteLine("You played:          " + player.getStr());
            Console.WriteLine("And computer player: " + computer.getStr());

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
            Console.WriteLine("Press Enter to play again");

            // Return player choice for next round
            return player.getInt();
        }

        private static Option previousChoice(int prev, Random rand)
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
    }
}