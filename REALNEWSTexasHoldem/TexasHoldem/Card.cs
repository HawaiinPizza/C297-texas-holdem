using System;
using System.Collections.Generic;
using System.Text;

namespace TexasHoldem {

    public struct Card {

        public int Value;
        public int Suite;

        public Card(int Val, int Suit) {

            Value = Val;
            Suite = Suit;
        }

        public void Set(int Val, int Suit) {

            Value = Val;
            Suite = Suit;
        }
        public static bool operator ==(Card left, Card right) {

            if (left.Value == right.Value && left.Suite == right.Suite)
                return true;

            return false;
        }

        public static bool operator !=(Card left, Card right) {

            if (left.Value != right.Value || left.Suite != right.Suite)
                return true;

            return false;
        }

        public string toString() {

            string temp = ("Value:" + Value + "    \tSuite:" + Suite);
            return temp;
        }

        public override bool Equals(object obj) {

            throw new NotImplementedException();
        }

        public override int GetHashCode() {

            throw new NotImplementedException();
        }
    }
}
