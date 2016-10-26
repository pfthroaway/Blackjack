using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Hand
    {
        List<Card> _cardList = new List<Card>();

        internal List<Card> CardList
        {
            get { return _cardList; }
            set { _cardList = value; }
        }

        internal int TotalValue()
        {
            int total = 0;
            foreach (Card card in _cardList)
                total += card.Value;
            return total;
        }
    }
}
