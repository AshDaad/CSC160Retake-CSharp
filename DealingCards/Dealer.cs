using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC160_ConsoleMenu;

namespace DealingCards
{
    class Dealer
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public Deck DealerDeck                    = new Deck();

        public Dealer(int PlayerAmount)
        {

            for (int i = 0; i < PlayerAmount; i++)
            {
                string temp = CIO.PromptForInput("Please Enter a name", false);
                Player newPlayer = new Player(temp);
                Players.Add(newPlayer);

            }
        }

        public void Deal(Player player)
        {
            if (DealerDeck.Count > 0)
            {
                player.Hand.Add(DealerDeck.Cards.First());
                DealerDeck.Cards.Remove(DealerDeck.Cards.First());
            }

        }

        public void RoundRobin(int x)
        {
            for (int i = 0; i < x; i++)
            {
                foreach (Player player in Players)
                {
                    Deal(player);
                }
            }
        }
    }
}

#region SudoCode
/**

    Dealer Class



*/
#endregion
