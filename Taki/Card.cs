using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Card
    {
        private int cardNum;
        private char cardColor;

        public Card(int cardNum, char cardColor)
        {
            this.cardNum = cardNum;
            this.cardColor = cardColor;
        }

        public int GetCardNum()
        {
            return this.cardNum;
        }

        public char GetCardColor()
        {
            return this.cardColor;
        }

        public void PrintCard()
        {
            switch(this.cardColor)
            {   
                case 'R':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 'Y':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 'G':
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 'B':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }

            Console.Write("{0}", this.cardNum);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" ");
        }
    }
}
