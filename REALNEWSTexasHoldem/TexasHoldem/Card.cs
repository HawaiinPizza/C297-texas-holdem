using System;
using System.Collections.Generic;
using System.Text;

namespace TexasHoldem {

    public struct Card {

        public int Value;
        public int Suite;

        public Card(int Val, int Suit)
        {
            Value = Val;
            Suite = Suit;
        }
        public string toString()
        {

            string temp = ("Value:" + Value + "    \tSuite:" + Suite);
            return temp;
        }
    }
}
