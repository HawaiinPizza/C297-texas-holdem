/*
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TexasHoldem {

    public class PokerHand : IComparable<PokerHand> {


        public double Wins { get; set; }
        public double Loses { get; set; }
        public double Draws { get; set; }

        public PokerHand() {

            Wins = 0;
            Loses = 0;
            Draws = 0;

            PlayerHandValues = new HandValue[21];

        }


        public int CompareTo(PokerHand other) {

            if (this == other) {

                Draws++;
            }
            if (this > other) {
                
                Wins++;
            }
            else if (this < other) {

                Loses++;
            }

            return 0;
        }

        public static bool operator ==(PokerHand left, PokerHand right) {


            for (int i = 0; i < 21; i++)
            {
                return false;
            }

            //Console.WriteLine("Fuck it they are equal");
            return true;

        }

        public static bool operator <(PokerHand left, PokerHand right)
        {

            for (int i = 0; i < 21; i++)
            {
                if (left.PlayerHandValues[i].WhichHand < right.PlayerHandValues[i].WhichHand)
                {

                    //Console.WriteLine("Less than");
                    return true;
                }
                else if (left.PlayerHandValues[i].Value < right.PlayerHandValues[i].Value)
                {

                    //Console.WriteLine("Less than");
                    return true;
                }

            }
                //Console.WriteLine("Greater than");
                return false;
        }

        public static bool operator >(PokerHand left, PokerHand right) {


            for (int i = 0; i < 21; i++)
            {
                if (left.PlayerHandValues[i].WhichHand > right.PlayerHandValues[i].WhichHand)
                {

                    //Console.WriteLine("Greater than");
                    return true;
                }
                else if (left.PlayerHandValues[i].Value > right.PlayerHandValues[i].Value)
                {
                    //Console.WriteLine("Greater than");

                    return true;
                }

            }
                //Console.WriteLine("Less than");
                return false;
        }

        public static bool operator !=(PokerHand left, PokerHand right) {
            return !(left == right);
        }

        public override int GetHashCode() {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj) {

            if (ReferenceEquals(this, obj)) {
                return true;
            }

            if (ReferenceEquals(obj, null)) {
                return false;
            }

            throw new NotImplementedException();
        }
    }
}
*/
