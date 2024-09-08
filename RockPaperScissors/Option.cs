using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    internal class Option
    {
        //Stores the name of the option for use
        private string optStr;
        // Int is better for comparisons
        private int compInt;

        public string getStr() { return optStr; }
        public int getInt() { return compInt; }

        public Option( char type ) 
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
            }
        }
        public Option(int type)
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
            }
            compInt = type;
        }

        public static int compareOption(Option op1, Option op2) {
            if (op1.compInt == (op2.compInt + 1) % 3)
            {
                // if modulo 3, op1 is one more than it wins and vice versa
                return 1;
            }
            // modulus in c# is remainder so +2 works when -1 doesnt as it means the same but does not go negative
            else if( op1.compInt == (op2.compInt + 2) % 3)
            {
                return 2;
            }
            else
            {
                // 0 represents a draw
                return 0;
            }
        }

    }
}
