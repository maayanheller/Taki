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
    }
}
