using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC160_ConsoleMenu;

namespace DealingCards
{
    class Ingition
    {
        public static void Start()
        {
            bool play = true;

            int PlayerAmount = CIO.PromptForInt("How many players would you like ?\nYou can have up to 5", 1, 5);
            Dealer dealer = new Dealer(PlayerAmount);
            Deck deck = new Deck();


            do
            {
                Console.WriteLine();
                List<string> MenuOP = new List<string>() { "Print the Deck","Shuffle the Deck","Deal Cards",
                    "Deal one Card to a Player","Print the Players", "Set new Players" };
                int MenuChoice = CIO.PromptForMenuSelection(MenuOP, true);

                switch (MenuChoice)
                {
                    case 0:
                        play = false;
                        break;
                    case 1:
                        Console.WriteLine(dealer.DealerDeck.ToString());
                        break;
                    case 2:
                        dealer.DealerDeck.Shuffle();
                        break;
                    case 3:
                        int x = CIO.PromptForInt("How many cards do you want to deal? (max is {1}) ", 1, 6);
                        dealer.RoundRobin(x);
                        break;
                    case 4:
                        string name = CIO.PromptForInput("Who do you want to deal to?\n> ", false);
                        var player = dealer.Players.Single(y => y.Name.Equals(name));
                            dealer.Deal(player);
                        break;
                    case 5:
                        for (int i = 0; i < dealer.Players.Count; i++)
                        {
                            Console.WriteLine(dealer.Players[i].ToString());
                        }
                        break;
                    case 6:
                        PlayerAmount = CIO.PromptForInt("How many players would you like ?\nYou can have up to 5", 1, 5);
                        dealer = new Dealer(PlayerAmount);
                        break;
                    default:
                        break;
                }
            } while (play);

        }

    }
}