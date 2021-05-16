using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taki
{
    class Game
    {
        private Player[] players;
        public Deck NewGame()
        {
            Deck gameDeck;
            Console.WriteLine("How many players does the game have?");
            int playersNum = int.Parse(Console.ReadLine());
            players = new Player[playersNum];

            if(playersNum <= 1)
            {
                Console.WriteLine("Ok, Come and play later");
                System.Environment.Exit(-1);
                return null;
            }

            else
            {
                int numOfDecks = playersNum / 4 + Math.Min(playersNum % 4, 1);
                gameDeck = new Deck(numOfDecks);
                gameDeck.ShuffleDeck();
                for(int i = 0; i < players.Length; i++)
                {
                    players[i] = new Player(new Card[numOfDecks * 40 - playersNum * 8], "p" + (i + 1).ToString());
                    for(int j = 0; j < 8; j++)
                    {
                        gameDeck.RemoveCard(gameDeck.GetDeck()[i].GetCardNum(), gameDeck.GetDeck()[i].GetCardColor(), players[i]);
                    }
                }

                return gameDeck;
            }
        }

        public Player[] GetPlayers()
        {
            return players;
        }
    }
}
