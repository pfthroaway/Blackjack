using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        string _name;
        string _suit;
        int _value;

        internal string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        internal string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        internal int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        internal Card()
        {

        }

        public override string ToString()
        {
            return _name + " of " + _suit;
        }

        internal Card(string name, string suit, int value)
        {
            _name = name;
            _suit = suit;
            _value = value;
        }

        internal Card(Card otherCard)
        {
            _name = otherCard.Name;
            _suit = otherCard.Suit;
            _value = otherCard.Value;
        }
    }
}
