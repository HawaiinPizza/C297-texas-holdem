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
        }
    }
}