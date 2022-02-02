using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingCards
{

    struct Card 
    {
        public Suit Suit { get; private set; }
        public Rank Rank { get; private set; }


        public Card(Suit suit, Rank rank) : this()
        {
            Suit = suit;
            Rank = rank;
        }

        public int CompareTo(Card other)
        {
            return Rank.CompareTo(other.Rank);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Suit, Rank);
        }
    }
}



#region SudoCode
/**
    enums: Suit and Rank
    suit => 4 (heart, club, diamond, spades)
    Rank => 13

    

    Card class
        - Each card should have a Rank and a Suit
            - Immutable
            - Get and Set
            - Overrides ToString





*/

/**What is an enum?
 * https://msdn.microsoft.com/en-us/library/cc138362.aspx
 * https://msdn.microsoft.com/en-us/library/sbbt4032.aspx
 * https://www.tutorialspoint.com/csharp/csharp_enums.htm
 * https://www.dotnetperls.com/enum
 */

#endregion

