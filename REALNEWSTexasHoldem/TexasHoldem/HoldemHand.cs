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

        public PokerHand()
        {
        }
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
        public void set(PokerType Type, List<Card> cards, int val) {
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


        public static PokerHand GetPoker(Card[] Cards)
        {

            var SortedCards=Cards.OrderBy(s => s.Value).ThenBy(s => s.Suite);
            Dictionary<int, List<Card>> temp = new Dictionary<int, List<Card>>();
            PokerHand[] ReturnHand = new PokerHand[9];
            int countVal = 1;
            int countSuit = 1;
            int iterValue = -1;
            int iterSuite = -1;
            PokerHand TEMP = new PokerHand();
            List<Card> tempCards = new List<Card>();
            tempCards.Add(Cards[0]);
            tempCards.Add(Cards[1]);
            tempCards.Add(Cards[2]);
            tempCards.Add(Cards[3]);
            tempCards.Add(Cards[4]);

            int index = 0;
            TEMP.set(PokerType.HighCard, tempCards, SortedCards.ElementAt(4).Value);
            ReturnHand[index] = TEMP;
            index++;
            foreach(Card i in SortedCards) {
                //Straight Checking
                if (iterValue == i.Value) {

                    countVal++;
                    iterValue++;
                }
                else {

                    iterValue = i.Value + 1;
                    countVal = 1;
                }

                if (countVal >= 5) {
                    TEMP.set(PokerType.Straight, tempCards, 49+i.Value);
                    ReturnHand[index] = TEMP;
                    index++;


                }

                //Straight Flush Checking
                if (iterSuite == i.Suite) {

                    countSuit++;
                }
                else {

                    countSuit = 1;
                    iterSuite = i.Suite;
                }

                if (countSuit >= 5) {

                    TEMP.set(PokerType.Straight, tempCards, 61+i.Value);
                    ReturnHand[index] = TEMP;
                    index++;

                    if (countVal >= 5) {
                        TEMP.set(PokerType.StraightFlush, tempCards, 97+i.Value);
                        ReturnHand[index] = TEMP;
                        index++;

                    }
                }

                if (temp.ContainsKey(i.Value))
                {
                    temp[i.Value].Add(i);
                }
                else
                {
                    temp[i.Value] = new List<Card>();
                    temp[i.Value].Add(i);

                }
            }

            bool pair=false;
            bool three=false;
            foreach (var key in temp) {
                switch (key.Value.Count())
                {
                    case 2:
                        if (three)
                        {
                            TEMP.set(PokerType.FullHouse, tempCards, 73);
                            ReturnHand[index] = TEMP;
                            index++;
                        }
                        else if (pair)
                        {
                            TEMP.set(PokerType.TwoPair, tempCards, 25);
                            ReturnHand[index] = TEMP;
                            index++;

                        }
                        else
                        {
                            TEMP.set(PokerType.Pair, tempCards, 13);
                            ReturnHand[index] = TEMP;
                            index++;
                            pair = true;

                        }
                    break;
                    case 3:
                        if (pair)
                        {
                            TEMP.set(PokerType.FullHouse, tempCards, 73);
                            ReturnHand[index] = TEMP;
                            index++;
                        }
                        else
                        {
                            TEMP.set(PokerType.ThreeOfAKind, tempCards, 37);
                            ReturnHand[index] = TEMP;
                            index++;
                            three = true;

                        }
                    break;
                case 4:
                        TEMP.set(PokerType.FourOfAKind, tempCards, 85);
                        ReturnHand[index] = TEMP;
                        index++;
                        three = true;
                        break;

                }
            }

            for(int i=0; i<index; i++)
            {
                if (TEMP < ReturnHand[i])
                    TEMP = ReturnHand[i];
            }
            return TEMP;
               







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
            SetHand();
        }
        public void SetHand()
        {

        }

        public void pushPokerHand(PokerHand pokerHand)
        {
            PokerHands.Add(pokerHand);
        }


        public Comb[] GetCombs(Card[] Cards)
        {
            Comb[] TempComb = new Comb[21];
        int[,] CombinationIndex = new int[,]
                {
                {1, 2, 3, 4, 5},
                {1, 2, 3, 4, 6},
                {1, 2, 3, 4, 7},
                {1, 2, 3, 5, 6},
                {1, 2, 3, 5, 7},

                {1, 2, 3, 6, 7},
                {1, 2, 4, 5, 6},
                {1, 2, 4, 5, 7},
                {1, 2, 4, 6, 7},
                {1, 2, 5, 6, 7},

                {1, 3, 4, 5, 6},
                {1, 3, 4, 5, 7},
                {1, 3, 4, 6, 7},
                {1, 3, 5, 6, 7},
                {1, 4, 5, 6, 7},

                {2, 3, 4, 5, 6},
                {2, 3, 4, 5, 7},
                {2, 3, 4, 6, 7},
                {2, 3, 5, 6, 7},
                {2, 4, 5, 6, 7},

                {3, 4, 5, 6, 7}};

            Card[] Temp = new Card[5];

            for(int i=0; i<21; i++)
            {
                for (int j = 0; j < 5; j++) {
                    Temp[i] = Cards[CombinationIndex[j,i]];
                }
                Comb Te = new Comb(Temp);
                //Te.Se
                TempComb[i] = Te;


            }
            return TempComb;

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
                    (Deck[i] != PlayerCards[0]) &&
                    (Deck[i] != PlayerCards[1]) &&
                    (Deck[i] != Field[0]) &&
                    (Deck[i] != Field[1]) &&
                    (Deck[i] != Field[2]) &&
                    (Deck[i] != Field[3]) &&
                    (Deck[i] != Field[4]))
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

            PokerHand test1 = new PokerHand();

            test1 = PokerHand.GetPoker(Field);
            Console.WriteLine(test1.value);





            for (int i = 0; i < 44; i++)
            {
                for(int j=i; j<44; j++)
                {
                    Card[] PosHands = new Card[7];
                }
            }

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
