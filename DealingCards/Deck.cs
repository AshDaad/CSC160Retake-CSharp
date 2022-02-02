using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingCards
{

    class Deck : IEnumerable<Card>
    {
        public List<Card> Cards { get; private set; }

        public Deck()
        {
            Cards = new List<Card>();
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank r in Enum.GetValues(typeof(Rank)))
                {
                    Cards.Add(new Card(s, r));
                }


            }
        }

        public void Shuffle()
        {
            var rnd = new Random();
            Cards = Cards.OrderBy(order => rnd.Next()).ToList();
        }

        public override string ToString()
        {
            string temp = "";
            foreach (Card c in Cards)
            {
                temp += c.ToString() + "\n";
            }
            return temp;
        }

        public int Count => Cards.Count;

        public Card Deal()
        {
            Card temp = Cards[0];
            Cards.Remove(Cards[0]);
            return Cards[0];
        }


        public IEnumerator<Card> GetEnumerator()
        {
            return ((IEnumerable<Card>)Cards).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Card>)Cards).GetEnumerator();
        }
    }
}