using Microsoft.VisualStudio.TestTools.UnitTesting;
using TexasHoldem;
using System;
using System.Collections.Generic;
using System.Text;

namespace TexasHoldem.Tests {

    [TestClass()]
    public class HoldemHandTests {

        [TestMethod()]
        public void CombinationEqualsTest() {

            // Arrange
            Card[] cards1 = new Card[5];
            Card[] cards2 = new Card[5];
            Card[] cards3 = new Card[5];
            Card[] cards4 = new Card[5];

            // Act
            cards1[0].Set(1, 3);
            cards1[1].Set(2, 0);
            cards1[2].Set(3, 2);
            cards1[3].Set(4, 2);
            cards1[4].Set(5, 0);

            cards2[0].Set(1, 3);
            cards2[1].Set(2, 0);
            cards2[2].Set(3, 2);
            cards2[3].Set(4, 2);
            cards2[4].Set(5, 0);

            cards3[0].Set(6, 3);
            cards3[1].Set(6, 0);
            cards3[2].Set(9, 2);
            cards3[3].Set(9, 2);
            cards3[4].Set(1, 1);

            cards4[0].Set(1, 3);
            cards4[1].Set(1, 0);
            cards4[2].Set(2, 2);
            cards4[3].Set(2, 1);
            cards4[4].Set(2, 2);

            Comb combination1 = new Comb(cards1);
            Comb combination2 = new Comb(cards2);
            Comb combination3 = new Comb(cards3);
            Comb combination4 = new Comb(cards4);

            // Assert
            Console.WriteLine("\n1\n{0}\n", combination1.ToString());
            Console.WriteLine("\n2\n{0}\n", combination2.ToString());
            Console.WriteLine("\n3\n{0}\n", combination3.ToString());
            Console.WriteLine("\n4\n{0}\n", combination4.ToString());

            Assert.IsFalse(combination1 > combination4);
            Assert.IsFalse(combination2 > combination4);
            Assert.IsFalse(combination3 > combination2);
            Assert.IsFalse(combination3 > combination4);
            Assert.IsTrue(combination1 > combination3);
        }

        [TestMethod()]
        public void CombinationLessTest() {

            // Arrange
            Card[] cards1 = new Card[5];
            Card[] cards2 = new Card[5];
            Card[] cards3 = new Card[5];
            Card[] cards4 = new Card[5];

            // Act
            cards1[0].Set(1, 3);
            cards1[1].Set(2, 0);
            cards1[2].Set(3, 2);
            cards1[3].Set(4, 2);
            cards1[4].Set(5, 0);

            cards2[0].Set(1, 3);
            cards2[1].Set(2, 0);
            cards2[2].Set(3, 2);
            cards2[3].Set(4, 2);
            cards2[4].Set(5, 0);

            cards3[0].Set(6, 3);
            cards3[1].Set(6, 0);
            cards3[2].Set(9, 2);
            cards3[3].Set(9, 2);
            cards3[4].Set(1, 1);

            cards4[0].Set(1, 3);
            cards4[1].Set(1, 0);
            cards4[2].Set(2, 2);
            cards4[3].Set(2, 1);
            cards4[4].Set(2, 2);

            Comb combination1 = new Comb(cards1);
            Comb combination2 = new Comb(cards2);
            Comb combination3 = new Comb(cards3);
            Comb combination4 = new Comb(cards4);

            // Assert
            Console.WriteLine("\n1\n{0}\n", combination1.ToString());
            Console.WriteLine("\n2\n{0}\n", combination2.ToString());
            Console.WriteLine("\n3\n{0}\n", combination3.ToString());
            Console.WriteLine("\n4\n{0}\n", combination4.ToString());

            Assert.IsFalse(combination1 == combination3);
            Assert.IsFalse(combination1 == combination4);
            Assert.IsFalse(combination2 == combination3);
            Assert.IsFalse(combination2 == combination4);
            Assert.IsFalse(combination3 == combination1);
            Assert.IsFalse(combination3 == combination2);
            Assert.IsFalse(combination3 == combination4);
            Assert.IsFalse(combination4 == combination1);
            Assert.IsFalse(combination4 == combination2);
            Assert.IsFalse(combination4 == combination3);
            Assert.IsTrue(combination1 == combination1);
            Assert.IsTrue(combination1 == combination2);
            Assert.IsTrue(combination2 == combination1);
            Assert.IsTrue(combination2 == combination2);
            Assert.IsTrue(combination3 == combination3);
            Assert.IsTrue(combination4 == combination4);
        }

        [TestMethod()]
        public void CombinationGreaterTest() {

            // Arrange
            Card[] cards1 = new Card[5];
            Card[] cards2 = new Card[5];
            Card[] cards3 = new Card[5];
            Card[] cards4 = new Card[5];

            // Act
            cards1[0].Set(1, 3);
            cards1[1].Set(2, 0);
            cards1[2].Set(3, 2);
            cards1[3].Set(4, 2);
            cards1[4].Set(5, 0);

            cards2[0].Set(1, 3);
            cards2[1].Set(2, 0);
            cards2[2].Set(3, 2);
            cards2[3].Set(4, 2);
            cards2[4].Set(5, 0);

            cards3[0].Set(6, 3);
            cards3[1].Set(6, 0);
            cards3[2].Set(9, 2);
            cards3[3].Set(9, 2);
            cards3[4].Set(1, 1);

            cards4[0].Set(1, 3);
            cards4[1].Set(1, 0);
            cards4[2].Set(2, 2);
            cards4[3].Set(2, 1);
            cards4[4].Set(2, 2);

            Comb combination1 = new Comb(cards1);
            Comb combination2 = new Comb(cards2);
            Comb combination3 = new Comb(cards3);
            Comb combination4 = new Comb(cards4);

            // Assert
            Console.WriteLine("\n1\n{0}\n", combination1.ToString());
            Console.WriteLine("\n2\n{0}\n", combination2.ToString());
            Console.WriteLine("\n3\n{0}\n", combination3.ToString());
            Console.WriteLine("\n4\n{0}\n", combination4.ToString());

            Assert.IsFalse(combination1 < combination1);
            Assert.IsFalse(combination1 < combination2);
            Assert.IsFalse(combination1 < combination3);
            Assert.IsFalse(combination2 < combination1);
            Assert.IsFalse(combination2 < combination2);
            Assert.IsFalse(combination2 < combination3);
            Assert.IsFalse(combination3 < combination3);
            Assert.IsFalse(combination4 < combination1);
            Assert.IsFalse(combination4 < combination2);
            Assert.IsFalse(combination4 < combination3);
            Assert.IsFalse(combination4 < combination4);
            Assert.IsTrue(combination1 < combination4);
            Assert.IsTrue(combination2 < combination4);
            Assert.IsTrue(combination3 < combination1);
        }
    }
}