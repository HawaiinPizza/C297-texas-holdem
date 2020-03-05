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
        public void CombinationComparisonTest()
        {
            // Arrange
            Card[] cards = new Card[5];
            Card[] cards1 = new Card[5];
            Card[] cards2 = new Card[5];
            Card[] cards3 = new Card[5];

            // Act
            cards[0].Set(2, 3);
            cards[1].Set(1, 0);
            cards[2].Set(7, 2);
            cards[3].Set(6, 2);
            cards[4].Set(6, 0);

            cards1[0].Set(2, 3);
            cards1[1].Set(1, 0);
            cards1[2].Set(7, 2);
            cards1[3].Set(6, 2);
            cards1[4].Set(6, 0);

            cards2[0].Set(1, 3);
            cards2[1].Set(9, 0);
            cards2[2].Set(7, 2);
            cards2[3].Set(6, 2);
            cards2[4].Set(6, 1);

            cards3[0].Set(1, 3);
            cards3[1].Set(1, 0);
            cards3[2].Set(7, 2);
            cards3[4].Set(9, 2);
            cards3[3].Set(6, 1);

            Comb combinationOne = new Comb(cards);
            Comb combinationTwo = new Comb(cards1);
            Comb combination2 = new Comb(cards2);
            Comb combination3 = new Comb(cards3);

            Console.WriteLine(combinationOne.ToString());

            // Assert
            Assert.IsTrue(combinationOne == combinationTwo);
            Assert.IsTrue(combination2 == combination3);
        }
    }
}