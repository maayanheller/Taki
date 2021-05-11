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
        private int decksNum = 0;

        public Deck(int decksNum)
        {
            this.decksNum = decksNum;

            while(this.decksNum > 0)
            {
                for (int i = 0; i < deck.Length; i++)
                {
                    deck[i] = new Card((i % 10) + 1, colors[i / 10]);
                }
                this.decksNum--;
            }
        }

        public void AddCard(int cardNum, char color)
        {
            for(int i = this.deck.Length - 1; i > 0; i--)
            {
                if(this.deck[i - 1] != null && this.deck[i] == null)
                {
                    this.deck[i] = new Card(cardNum, color);
                    break;
                }
            }
        }

        public void RemoveCard(int num, char color)
        {
            for (int i = 0; i < deck.Length; i++)
            {
                try
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

                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(" \n This card isn't in the deck \n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                
            }
        }

        public bool IsEmpty()
        {
            bool empty = false;
            for(int i = 0; i < this.deck.Length; i++)
            {
                if(this.deck[i] == null)
                {
                    empty = true;
                }

                else
                {
                    empty = false;
                    break;
                }
            }
            return empty;
        }

        public void printDeck()
        {
            for (int i = 0; i < deck.Length; i++)
            {
                if (deck[i] != null)
                {
                    deck[i].PrintCard();
                }

                else
                {
                    break;
                }

            }
        }

        public override string ToString()
        {
            string deckInString = "";
            for (int i = 0; i < deck.Length; i++)
            {
                if(deck[i] != null)
                {
                    deckInString += String.Format(" [{0}, {1}] ", deck[i].GetCardNum(), deck[i].GetCardColor());
                }

                else
                {
                    break;
                }
                
            }

            return deckInString;
        }
    }
}
