using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter r for random choices or c for copycat from the computer opponent");
            char input = Console.ReadLine().ToLower().ToCharArray()[0];
            if (input == 'r')
            {
                while (true)
                {
                    randRPS();
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else if(input == 'c')
            {
                int previous = -1;
                while (true)
                {
                    previous = copyRPS(previous);
                    Console.ReadLine();
                    Console.Clear();
                }
            }



        }

        static void randRPS()
        {
            Random rand = new Random();

            Console.WriteLine("Enter your option (r/p/s)");
            char choice = Console.ReadLine().ToLower().ToCharArray()[0];
            Option player = new Option(choice);

            Option computer = new Option(rand.Next(3));

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

        }

        static int copyRPS(int prev)
        {
            Random rand = new Random();

            Console.WriteLine("Enter your option (r/p/s)");
            char choice = Console.ReadLine().ToLower().ToCharArray()[0];
            Option player = new Option(choice);

            //---------------------------
            Option computer;
            if (prev == -1)
            {
                // Random if first rotation
                computer = new Option(rand.Next(3));
            }
            else
            {
                computer = new Option(prev);
            }
            //---------------------------

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

            return player.getInt();
        }
    }
}