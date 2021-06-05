using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Player
    {
        private Card[] cardsInPossesion;
        private string playerName;
        private int cardsInPossesionLength;
        private Card lastCardUsed;

        public Player(Card[] cards, string name)
        {
            // Init a Player
            this.cardsInPossesion = cards;
            this.playerName = name;
            this.cardsInPossesionLength = 0;
        }

        public int GetAmountOfCards()
        {
            return this.cardsInPossesionLength;
        }

        public string GetPlayerName()
        {
            return this.playerName;
        }

        public Card GetLastCardUsed()
        {
            return this.lastCardUsed;
        }

        public void SetLastCardUsed(Card newCard)
        {
            this.lastCardUsed = newCard;
        }

        public void AddCardToPlayersPossesion(Card newCard)
        {
            // Scan cardInPossesion until you hit a null sopt
            // And then insert to it the specified card and break the loop.
            for(int i = 0; i < this.cardsInPossesion.Length; i++)
            {
                if(this.cardsInPossesion[i] != null)
                {
                    // Do nothing
                }

                else
                {
                    this.cardsInPossesion[i] = newCard;
                    this.cardsInPossesionLength++;
                    break;
                }
            }
        }

        public Card SearchForCardToPutInTheStack(Card cardToSearch)
        {
            // Try to scan cardsInPossesion for the specified card to remove,
            // If not found then take a card from the deck and add it to the player's possesion.
            
            for(int i = 0; i < this.cardsInPossesionLength; i++)
            {
                if (this.cardsInPossesion[i] != null)
                {
                    if (this.cardsInPossesion[i].GetCardColor() == cardToSearch.GetCardColor() || this.cardsInPossesion[i].GetCardNum() == cardToSearch.GetCardNum())
                    {
                        Card removedCard = this.cardsInPossesion[i];
                        for (int j = i; j < this.cardsInPossesion.Length - 1; j++)
                        {
                            if (this.cardsInPossesion[j] != null)
                            {
                                this.cardsInPossesion[j] = this.cardsInPossesion[j + 1];
                            }
                            else
                            {
                                break;
                            }
                        
                        }

                        this.cardsInPossesionLength--;
                        return removedCard;
                    }
                }
            }

            return null;
        }
        
        public void PrintPlayerCards()
        {
            // Use the PrintCard function on each element until value is null (or none is)
            // If element's value is null, break the loop
            Console.WriteLine("{0} cards: ", this.playerName);
            for (int i = 0; i < this.cardsInPossesionLength; i++)
            {
                if (this.cardsInPossesion[i] != null)
                {
                    cardsInPossesion[i].PrintCard();
                }

                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
