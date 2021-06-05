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
            int num = 0;
            Console.WriteLine("How many players does the game have?");
            string playersNumString = Console.ReadLine();
            int playersNum = 0;
            bool isPlayersNumInt = int.TryParse(playersNumString, out num);
            if(isPlayersNumInt == false || int.Parse(playersNumString) <= 1)
            {
                
                Console.WriteLine("Sorry, Input is invalid, Come and play later");
                System.Environment.Exit(-1);
                return null;
            }

            else
            {
                playersNum = int.Parse(playersNumString);
                players = new Player[playersNum];
                int numOfDecks = playersNum / 4 + Math.Min(playersNum % 4, 1);
                gameDeck = new Deck(numOfDecks);
                gameDeck.ShuffleDeck();
                for(int i = 0; i < players.Length; i++)
                {
                    players[i] = new Player(new Card[numOfDecks * 40 - playersNum * 8 + 8], "p" + (i + 1).ToString());
                    for(int j = 0; j < 8; j++)
                    {
                        gameDeck.GiveCardToPlayer(gameDeck.GetDeck()[i], players[i]);
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
