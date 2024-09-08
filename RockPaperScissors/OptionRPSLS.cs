using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class OptionRPSLS
    {
        //Stores the name of the option for use
        private string optStr;
        // Int is better for comparisons
        private int compInt;

        public string getStr() { return optStr; }
        public int getInt() { return compInt; }

        public OptionRPSLS(char type)
        {
            switch (type)
            {
                case 'r':
                    optStr = "Rock";
                    compInt = 0;
                    break;
                case 'p':
                    optStr = "Paper";
                    compInt = 1;
                    break;
                case 's':
                    optStr = "Scissors";
                    compInt = 2;
                    break;
                case 'v':
                    optStr = "Spock";
                    compInt = 3;
                    break;
                case 'l':
                    optStr = "Lizard";
                    compInt = 4;
                    break;
                default:
                    throw new ArgumentException("Invalid constructor input");
            }
        }
        public OptionRPSLS(int type)
        {
            switch (type)
            {
                case 0:
                    optStr = "Rock";
                    break;
                case 1:
                    optStr = "Paper";
                    break;
                case 2:
                    optStr = "Scissors";
                    break;
                case 3:
                    optStr = "Spock";
                    break;
                case 4:
                    optStr = "Lizard";
                    break;
                default:
                    throw new ArgumentException("Invalid constructor input");
            }
            compInt = type;
        }

        public static int compareOption(OptionRPSLS op1, OptionRPSLS op2)
        {
            Console.WriteLine(op1.compInt);
            Console.WriteLine(op2.compInt);
            if (op1.compInt == (op2.compInt + 1) % 5
               || op1.compInt == (op2.compInt + 3) % 5)
            {
                Console.WriteLine("h1");
                return 1;
            }
            // modulus in c# is remainder so +4 works when -1 doesnt as it means the same but does not go negative
            else if (op1.compInt == (op2.compInt + 4) % 5
                || op1.compInt == (op2.compInt + 2) % 5)
            {
                Console.WriteLine("h2");
                return 2;
            }
            //else if (op1.compInt == (op2.compInt + 2) % 5)
            //{
            //    Console.WriteLine("h3");
            //    return 1;
            //}
            //else if (op1.compInt == (op2.compInt + 3) % 5)
            //{
            //    Console.WriteLine("h4");
            //    return 2;
            //}
            else
            {
                // 0 represents a draw
                return 0;
            }
        }
    }
}
