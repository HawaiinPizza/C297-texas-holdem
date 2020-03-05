using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;


namespace TexasHoldem {


    public class HoldemHand {

        ////////////////////////////////// Variables ////////////////////////////////////////////
        HumanPlayer TheHumanPlayer = new HumanPlayer(100.0, 10.0);
        ComputerPlayer TheComputerPlayer = new ComputerPlayer(100.0, 10.0);


        public double HumanWinningOdds { get; set; }
        public double HumanLosingOdds { get; set; }
        public double HumanDrawingOdds { get; set; }

        public double ComputerWinningOdds { get; set; }
        
        public Card[] Deck = new Card[52];
        public Card[] ComputerHand = new Card[2];
        public Card[] PlayerHand = new Card[2];
        public Card[] Field = new Card[5];

        int Point = 0;
        /////////////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////// Constructer //////////////////////////////////////////
        public HoldemHand() {

            ShuffleDeck();
        }
        /////////////////////////////////////////////////////////////////////////////////////////

        /////////////////////////////////// Functions ///////////////////////////////////////////
        // When called it resets the players' money and shuffles the deck
        public void RestartGame() {

            TheHumanPlayer.PlayerBetAmount = 10.0;
            TheHumanPlayer.PlayerMoney = 100.0;

            TheComputerPlayer.PlayerBetAmount = 10.0;
            TheComputerPlayer.PlayerMoney = 100.0;

            ShuffleDeck();
        }

        public void ShuffleDeck() {

            //This is deck geneartion. 
            //There is 13 values, and 4 suits.
            //0-12 goes from 2 to Ace
            for (int i = 0; i < 52; i++) {

                int Suit = i / 13;
                double temp = i % 13;
                double Val = Math.Floor(temp);

                //Now the Value of the card and the suit have been declared, Creating a card 
                Card Temp = new Card {

                    Suite = Suit,
                    Value = (int)Val
                };

                Deck[i] = Temp;
            }


            //Random rand = new Random(05162000);
            Random rand = new Random();

            //This is shuffling a deck, with a seed so we can predict outcomes. BTW seed is my birthdate (Zaki)
            for (int i = 0; i < Deck.Length - 1; i++) {

                int j = rand.Next(i, Deck.Length);

                Card temp = Deck[i];
                Deck[i] = Deck[j];
                Deck[j] = temp;
            }

            //This part is setting the field cards. 
            for (int i = 0; i < 5; i++) {

                Field[i] = Deck[i];
                Point = i;
            }
            for (int i = 0; i < 52; i++) {

                ////Console.WriteLine(Deck[i].Suite + "\t" + Deck[i].Value + "\t");
            }

            //This is setting the players hand
            ////Console.WriteLine("\n");

            ComputerHand[0] = Deck[Point++];
            ComputerHand[1] = Deck[Point++];
            PlayerHand[0] = Deck[Point++];
            PlayerHand[1] = Deck[Point++];

            ////Console.WriteLine(Point);
        }

        public void Test()
        {
            //ShuffleDeck();
            Card broly = new Card(2, 4);
            Card goku = new Card(2, 4);
            Card muaz = new Card(-1, 4);
            Dictionary<int, List<Card>> temp = new Dictionary<int, List<Card>>();
            List<Card> VEGETA = new List<Card>();
            Card[] Cam = new Card[6];
            Cam[0] = broly;
            Cam[1] = goku;
            Cam[2] = muaz;
            Cam[3] = broly;
            Cam[4] = goku;
            Cam[5] = muaz;
            for (int i = 0; i < 3; i++)
            {
                if (temp.ContainsKey(Cam[i].Value))
                {
                    temp[Cam[i].Value].Add(Cam[i]);
                }
                else
                {
                    temp[Cam[i].Value] = new List<Card>();
                    temp[Cam[i].Value].Add(Cam[i]);

                }
                //Console.WriteLine("This is a meem{0}", temp[Cam[i].Value].Count);
            }
            foreach(var keyVal in temp)
            {
                Console.WriteLine("{0} OH SHIT {1}", keyVal.Value.Count, keyVal.Key);
            }

        }
    }
}
