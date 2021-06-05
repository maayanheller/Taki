using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the game
            Deck deck;
            Player[] players;
            Game game1 = new Game();


            deck = game1.NewGame();

            players = game1.GetPlayers();

            Card topCard = deck.TakeTopCard();

            ShowGameStatus(deck, players, topCard, "", topCard, "Start");

            //Manage the game
            //While shouldRun = true, scan each player for a card that matches the current top card
            //If found set it as top card and continue, else take a card from deck
            //If deck is over or a player finished his card, break the game
            bool shouldRun = true;
            while(shouldRun)
            {
                for(int i = 0; i < players.Length; i++)
                {
                    Card doesHaveCard = players[i].SearchForCardToPutInTheStack(topCard);
                    if (doesHaveCard != null && deck.GetDeckLength() > 0)
                    {
                        topCard = doesHaveCard;
                        players[i].SetLastCardUsed(doesHaveCard);
                        if (players[i].GetAmountOfCards() == 0)
                        {
                            ShowGameStatus(deck, players, topCard, "", null, "End");
                            Console.WriteLine("{0} won the game!", players[i].GetPlayerName());
                            shouldRun = false;
                            break;
                        }
                    }
                    else
                    {
                        if (deck.GetDeckLength() > 0)
                        {
                            Random rnd = new Random();
                            int indexInDeck = rnd.Next(0, deck.GetDeckLength());
                            deck.GiveCardToPlayer(deck.GetDeck()[indexInDeck], players[i]);
                        }
                        else
                        {
                            Console.WriteLine("Deck is over, End of Game!");
                            shouldRun = false;
                            break;
                        }
                    }   
                    ShowGameStatus(deck, players, topCard, players[i].GetPlayerName(), players[i].GetLastCardUsed(), "");
                }
            }
        }

        static void ShowGameStatus(Deck deck, Player[] players, Card topCard, string playersTurn, Card lastCardUsed, string gameStatus)
        {
            // Print the status of the game 
            deck.PrintDeck();
            
            if(playersTurn != "")
            {
                Console.Write("{0} did the last turn", playersTurn);
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("{0} of game!", gameStatus);
            }

            if(lastCardUsed != null)
            {
                Console.Write("last card used is ");
                lastCardUsed.PrintCard();
                Console.WriteLine();
            }

            Console.Write("Top card: ");

            topCard.PrintCard();

            Console.WriteLine();

            for (int i = 0; i < players.Length; i++)
            {
                players[i].PrintPlayerCards();
            }

            Console.WriteLine();
        }
    }
}
