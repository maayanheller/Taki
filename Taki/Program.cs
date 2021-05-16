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
            Deck deck;
            Player[] players;
            Game game1 = new Game();


            deck = game1.NewGame();

            deck.PrintDeck();

            players = game1.GetPlayers();

            for(int i = 0; i < players.Length; i++)
            {
                players[i].PrintPlayerCards();
            }


        }
    }
}
