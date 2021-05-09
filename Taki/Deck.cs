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

        public void AddCard(int cardNum, char color)
        {
            for(int i = this.deck.Length; i > 0; i--)
            {
                if(this.deck[i] == null)
                {

                }

                else
                {
                    this.deck[i + 1] = new Card(cardNum, color);
                    break;
                }
            }
        }

        public void Remove(int num, char color)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                if (this.deck[i].GetCardColor() == color && this.deck[i].GetCardNum() == num)
                {
                    for (int j = i; j < this.deck.Length - 1; j++)
                    {
                        this.deck[j] = this.deck[j + 1];
                    }
                    this.deck[this.deck.Length - 1] = null;
                    break;
                }
            }
        }

        public bool IsEmpty()
        {
            return this.deck.Length == 0;
        }

        public override string ToString()
        {
            string deckInString = "";
            for (int i = 0; i < deck.Length; i++)
            {
                deckInString += String.Format(" [{0}, {1}] ", deck[i].GetCardNum(), deck[i].GetCardColor());
            }

            return deckInString;
        }
    }
}
