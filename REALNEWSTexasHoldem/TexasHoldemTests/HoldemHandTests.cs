using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexasHoldem;
using System;
using System.Collections.Generic;
using System.Text;

namespace TexasHoldem.Tests
{
    [TestClass()]
    public class HoldemHandTests
    {
        [TestMethod()]
        public void GetHandTest()
        {

            HoldemHand holdemHand = new HoldemHand();
            holdemHand.ShuffleDeck();

            Card[] cards = new Card[5];
            Card[] cards1 = new Card[5];

            cards[0].Set(6, 1);
            cards[1].Set(6, 3);
            cards[2].Set(7, 2);
            cards[3].Set(6, 2);
            cards[4].Set(6, 0);

            cards1[0].Set(2, 3);
            cards1[1].Set(1, 0);
            cards1[2].Set(7, 2);
            cards1[3].Set(6, 2);
            cards1[4].Set(6, 0);

        }
    }
}