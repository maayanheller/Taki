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
        private string cardColor;

        public Card(int cardNum, string cardColor)
        {
            this.cardNum = cardNum;
            this.cardColor = cardColor;
        }

        public int GetCardNum()
        {
            return this.cardNum;
        }

        public string GetCardColor()
        {
            return this.cardColor;
        }
    }
}
