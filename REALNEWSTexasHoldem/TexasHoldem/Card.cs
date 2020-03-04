using System;
using System.Collections.Generic;
using System.Text;

namespace TexasHoldem {

    public struct Card {

        public int Value;
        public int Suite;
        public string toString()
        {

            string temp = ("Value:" + Value + "    \tSuite:" + Suite);
            return temp;
        }
    }
}
