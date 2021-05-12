using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Deck
    {
        private Card[] deck;
        private static char[] colors = new char[4] { 'R', 'Y', 'G', 'B' };
        private int decksNum = 0;

        public Deck(int decksNum)
        {
            // Calculate deck length And enter all cards to the deck.
            this.decksNum = decksNum;

            this.deck = new Card[this.decksNum * 40];

            while(this.decksNum > 0)
            {
                for (int i = 0; i < this.deck.Length; i++)
                {
                    this.deck[i] = new Card((i % 10) + 1, colors[i / 10]);
                }
                this.decksNum--;
            }
        }

        public void AddCard(int cardNum, char color)
        {
            // Add card to the end of "Card[] deck".
            /// Note: this function isn't used during the project but is requested to implement
            for(int i = this.deck.Length - 1; i > 0; i--)
            {
                if(this.deck[i - 1] != null && this.deck[i] == null)
                {
                    this.deck[i] = new Card(cardNum, color);
                    break;
                }
            }
        }

        public void RemoveCard(int num, char color, Player player)
        {
            // Try to scan the deck for the card with the specified properties, if found, add to specified player's possesion and remove from this deck
            // If isn't found, return a message.
            for (int i = 0; i < this.deck.Length; i++)
            {
                try
                {
                    if (this.deck[i].GetCardColor() == color && this.deck[i].GetCardNum() == num)
                    {
                        player.AddCardToPlayersPossesion(this.deck[i]);
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
                    Card toShow = new Card(num, color);
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(" \n The card ");
                    toShow.PrintCard();
                    Console.Write("isn't in the deck \n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                
            }
        }

        public bool IsEmpty()
        {
            // Check if deck contains cards
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

        public void PrintDeck()
        {
            // Print all cards on deck
            for (int i = 0; i < this.deck.Length; i++)
            {
                if (this.deck[i] != null)
                {
                    this.deck[i].PrintCard();
                }

                else
                {
                    break;
                }

            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            // Turn all deck to one big string
            /// Note: this function isn't used during the project but is requested to implement
            string deckInString = "";
            for (int i = 0; i < this.deck.Length; i++)
            {
                if(this.deck[i] != null)
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
