using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;


namespace TexasHoldem {
    enum PokerType
    {
        HighCard,
        Pair,
        TwoPair,
        ThreeOfAKind,
        FourOfAKind,
        Straight,
        Flush,
        StraightFlush,
        FullHouse
    }
    class PokerHand
    {
        public PokerType Type;
        public List<Card> cards = new List<Card>();
        public int value = -1;

        public PokerHand(PokerType Type, List<Card> cards)
        {
            this.Type = Type;
            this.cards = cards;
        }
        public PokerHand(PokerType Type, List<Card> cards, int val)
        {
            this.Type = Type;
            this.cards = cards;
            value = val;

        }
        public string ToString()
        {

            String temp = ("Type " + Type + ":      \t Value:" + value);
            foreach(Card i in cards)
            {
                temp += "\n";
                temp += i.toString();
            }

            return temp;
        }

        public void setValue(int Val)
        {
            value = Val;
        }

        public static bool operator<(PokerHand left, PokerHand right)
        {
            return left.value < right.value;
        }

        public static bool operator>(PokerHand left, PokerHand right)
        {
            return left.value > right.value;
        }

        // Assume 
        public static bool operator==(PokerHand left, PokerHand right)
        {


            if (left.Type == right.Type)
            {
                var Left=left.cards.OrderBy(s => s.Value).ThenBy(s => s.Suite);
                var Right=right.cards.OrderBy(s => s.Value).ThenBy(s => s.Suite);
                // ASSUME POKERHANDS FOR LEFT AND RIGHT ARE SORTED
                for (int i = 0; i < Left.Count(); i++)
                {
                    if (Left.ElementAt(i) != Right.ElementAt(i))
                        return false;
                }
            return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator!=(PokerHand left, PokerHand right)
        {
            if (left.Type == right.Type)
            {
                var Left=left.cards.OrderBy(s => s.Value).ThenBy(s => s.Suite);
                var Right=right.cards.OrderBy(s => s.Value).ThenBy(s => s.Suite);
                // ASSUME POKERHANDS FOR LEFT AND RIGHT ARE SORTED
                for (int i = 0; i < Left.Count(); i++)
                {
                    if (Left.ElementAt(i) != Right.ElementAt(i))
                        return true;
                }
            return false;
            }
            else
            {
                return true;
            }
        }

    }

    class Comb
    {
        public List<PokerHand> PokerHands = new List<PokerHand>();
        public Card[] PosComb = new Card[5];

        public Comb(Card[] Cards)
        {
            PosComb = Cards;
        }

        public void pushPokerHand(PokerHand pokerHand)
        {
            PokerHands.Add(pokerHand);
        }



        public static bool operator==(Comb left, Comb right)
        {
            List<PokerHand> NuLeft = new List<PokerHand>();
            List<PokerHand> NuRight = new List<PokerHand>();
            NuLeft = left.PokerHands;
            NuRight = right.PokerHands;
            int size = 0;
            for(int i=0; i<NuLeft.Count(); i++)
            {
                for (int j = 0; j < NuRight.Count(); j++)
                {
                    if (NuLeft[i] == NuRight[j])
                    {
                        NuLeft.RemoveAt(i);
                        NuRight.RemoveAt(j);
                        size++;
                    }
                }
            }

            if (size == 0)
            {
                return true;
            }
            else
                return false;

        }
        public static bool operator!=(Comb left, Comb right)
        {
            List<PokerHand> NuLeft = new List<PokerHand>();
            List<PokerHand> NuRight = new List<PokerHand>();
            NuLeft = left.PokerHands;
            NuRight = right.PokerHands;
            int size = 0;
            for(int i=0; i<NuLeft.Count(); i++)
            {
                for (int j = 0; j < NuRight.Count(); j++)
                {
                    if (NuLeft[i] == NuRight[j])
                    {
                        NuLeft.RemoveAt(i);
                        NuRight.RemoveAt(j);
                        size++;
                    }
                }
            }

            if (size == 0)
            {
                return false;
            }
            else
                return true;
        }
        public PokerHand GetBest()
        {
            return GetBestStatic(PokerHands);
        }
        public static PokerHand GetBestStatic(List<PokerHand> Hands)
        {
            List<Card> cards = new List<Card>();
            Card TEMPMUAZ=new Card(-1,-1);
            cards.Add(TEMPMUAZ);
            PokerHand temp = new PokerHand(PokerType.HighCard, cards);
            foreach (PokerHand Hand in Hands)
            {
                if (temp.value < Hand.value)
                {
                    temp = Hand;
                }
            }
            return temp;
        }

        public static bool operator<(Comb left, Comb right)
        {
            List<PokerHand> NuLeft = new List<PokerHand>();
            List<PokerHand> NuRight = new List<PokerHand>();
            NuLeft = left.PokerHands;
            NuRight = right.PokerHands;
            int size = 0;
            for(int i=0; i<NuLeft.Count(); i++)
            {
                for (int j = 0; j < NuRight.Count(); j++)
                {
                    if (NuLeft[i] == NuRight[j])
                    {
                        NuLeft.RemoveAt(i);
                        NuRight.RemoveAt(j);
                        size++;
                    }
                }
            }

            if (NuLeft.Count() == 0 && NuRight.Count() == 0 || NuLeft.Count() == 0)
                return false;
            else if (NuRight.Count == 0)
                return true;
            else
            {

                PokerHand Left = GetBestStatic(NuLeft);
                PokerHand Right = GetBestStatic(NuLeft);

                return Left > Right;
            }
        }
        public static bool operator >(Comb left, Comb right)
        {
            List<PokerHand> NuLeft = new List<PokerHand>();
            List<PokerHand> NuRight = new List<PokerHand>();
            NuLeft = left.PokerHands;
            NuRight = right.PokerHands;
            int size = 0;
            for (int i = 0; i < NuLeft.Count(); i++)
            {
                for (int j = 0; j < NuRight.Count(); j++)
                {
                    if (NuLeft[i] == NuRight[j])
                    {
                        NuLeft.RemoveAt(i);
                        NuRight.RemoveAt(j);
                        size++;
                    }
                }
            }

            if (NuLeft.Count() == 0 && NuRight.Count() == 0 || NuRight.Count()==0)
                return false;
            else if (NuLeft.Count == 0)
                return true;
            else
            {

                PokerHand Left = GetBestStatic(NuLeft);
                PokerHand Right = GetBestStatic(NuLeft);

                return Left > Right;
            }
        }

    }


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


            Random rand = new Random(05162000);
            //Random rand = new Random();

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

        public Card[] GetPossipleCards(Card[] Field, Card[] PlayerCards)
        {
            Card[] PosCards = new Card[45];
            int index = 0;
            for (int i = 0; i < 52; i++)
            {


                if (
                    (Deck[i]!=PlayerCards[0]) && 
                    (Deck[i]!=PlayerCards[1]) &&
                    (Deck[i]!=Field[0]) &&
                    (Deck[i]!=Field[1]) &&
                    (Deck[i]!=Field[2]) &&
                    (Deck[i]!=Field[3]) &&
                    (Deck[i]!=Field[4]))
                {
                    PosCards[index] = Deck[i];
                    index++;
                }

            }



            return PosCards;


            
        }

        public void Test()
        {
            Card[] Temp = new Card[45];
            Card[] Field = new Card[5];
            Field[0].Set(0, 0);
            Field[1].Set(1, 0);
            Field[2].Set(2, 0);
            Field[3].Set(3, 0);
            Field[4].Set(4, 0);
            Card[] Player = new Card[2];
            Player[0].Set(0, 1);
            Player[1].Set(0, 2);
            GetPossipleCards(Field, Player);
            Temp = GetPossipleCards(Field, Player);
            foreach (Card temp in Temp)
            {
                Console.WriteLine("Vlaue is {0} and suite is {1}", temp.Value, temp.Suite);
            }

            List<Card> A1 = new List<Card>();
            List<Card> A2 = new List<Card>();
            A1.Add(Field[0]);
            A1.Add(Field[1]);
            A1.Add(Field[2]);
            A1.Add(Field[3]);
            A1.Add(Field[4]);
            A2.Add(Field[0]);
            A2.Add(Field[1]);
            A2.Add(Field[2]);
            A2.Add(Field[3]);
            A2.Add(Field[4]);

            PokerHand poker1= new PokerHand(PokerType.Pair,A1, 2);
            PokerHand poker2= new PokerHand(PokerType.Pair, A2, 4 );
            A2[2] = Player[0];
            PokerHand poker3= new PokerHand(PokerType.Pair, A2, 1 );

            Comb Comb1 = new Comb(Field);
            Comb Comb2 = new Comb(Field);
            Comb1.pushPokerHand(poker1);
            Comb2.pushPokerHand(poker2);

            Console.WriteLine("EYA\t");

            Console.WriteLine(Comb1.GetBest().ToString());
            Console.WriteLine(Comb1 == Comb2);
            Console.WriteLine(Comb1 < Comb2);
            Console.WriteLine(Comb1 > Comb2);

            Comb1.pushPokerHand(poker3);
            Console.WriteLine("NO\t");
            Console.WriteLine(Comb1 == Comb2);
            Console.WriteLine(Comb1 < Comb2);
            Console.WriteLine(Comb1 > Comb2);


            //PokerType Type;
            //List<Card> cards = new List<Card>();
            

            //ShuffleDeck();
            /*
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

        */
        }
    }
}
