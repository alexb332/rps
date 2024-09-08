using System;
using System.Collections.Generic;
using System.Linq;
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

        public Option( char type ) 
        {
            switch (type)
            {
                case 'r':
                    optStr = "rock";
                    compInt = 0;
                    break;
                case 'p':
                    optStr = "paper";
                    compInt = 1;
                    break;
                case 's':
                    optStr = "scissors";
                    compInt = 2;
                    break;
            }
        }

        public static int compareOption(Option op1, Option op2) { 
            if(op1.compInt == (op2.compInt + 1) % 3)
            {
                // if modulo 3, op1 is one more than it wins and vice versa
                return 1;
            }
            else if( op1.compInt == (op2.compInt - 1) % 3)
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
