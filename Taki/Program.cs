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

            /// TODO: Take the first card of the deck for top card
            Card topCard = new Card(3, 'R');

            ShowGameStatus(deck, players, topCard, "");

            //Manage the game
            while(deck.GetDeckLength() >= 0)
            {
                ///TODO: Make the game stop without using System.Exit 
                for(int i = 0; i < players.Length; i++)
                {
                    Card doesHaveCard = players[i].SearchForCardToPutInTheStack(topCard);
                    if (doesHaveCard != null && deck.GetDeckLength() > 0)
                    {
                        topCard = doesHaveCard;
                        if (players[i].GetAmountOfCards() == 0)
                        { 
                            ShowGameStatus(deck, players, topCard, players[i].GetPlayerName());
                            Console.WriteLine("{0} won the game!", players[i].GetPlayerName());
                            System.Environment.Exit(-1);
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
                            Console.WriteLine("Deck is over!");
                            System.Environment.Exit(-1);
                            break;
                        }
                    }   
                    ShowGameStatus(deck, players, topCard, players[i].GetPlayerName());
                }
            }
        }

        static void ShowGameStatus(Deck deck, Player[] players, Card topCard, string playersTurn)
        {
            deck.PrintDeck();
            
            if(playersTurn != "")
            {
                Console.WriteLine("{0} turn", playersTurn);
            }

            else
            {
                Console.WriteLine("Start of game!");
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
