using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                baseRPS();
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void baseRPS()
        {
            Random rand = new Random();

            Console.WriteLine("Enter your option");
            char choice = Console.ReadLine().ToCharArray()[0];
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
    }
}