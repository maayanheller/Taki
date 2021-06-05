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
            // Init a Card
            this.cardNum = cardNum;
            this.cardColor = cardColor;
        }

        public int GetCardNum()
        {
            // Return the card's number
            return this.cardNum;
        }

        public char GetCardColor()
        {
            // Return the card's color
            return this.cardColor;
        }

        public void PrintCard()
        {
            // Print the card, based on his color attribute, change the console printing color, print, then change back to regular console color
            ConsoleColor currentForeground = Console.ForegroundColor;
            switch (this.cardColor)
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

            Console.Write("{0} ", this.cardNum);
            Console.ForegroundColor = currentForeground;
        }
    }
}
