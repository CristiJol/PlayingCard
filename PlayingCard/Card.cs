using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    public class Card
    {
        private string rank;
        private string suit;
        public Card(string Rank ,string Suit)
        {
            this.rank = Rank;
            this.suit = Suit;
        }
        public override string ToString()
        {
            return rank + " of " + suit;
        }
    }
}
