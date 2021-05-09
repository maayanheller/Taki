using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Deck
    {
        private Card[] deck = new Card[40];
        private static char[] colors = new char[4] { 'R', 'Y', 'G', 'B' };

        public Deck()
        {
            for(int i = 0; i < deck.Length; i++)
            {
                deck[i] = new Card((i % 10) + 1, colors[i / 10]);
            }
        }
    }
}
