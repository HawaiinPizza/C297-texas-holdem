using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Linq;


namespace TexasHoldem {

    // This is the tuple of the hand, and it's value
    public struct HandValue {

        public int Value;
        public int WhichHand;
        public bool Works;
    }

    // This is a bitmap of the possiple hands, given cards
    public class PossibleHands {

        public HandValue HighCard;
        public HandValue Pair;
        public HandValue TwoPair;
        public HandValue Threeofakind;
        public HandValue Straight;
        public HandValue Flush;
        public HandValue FullHouse;
        public HandValue FourofaKind;
        public HandValue StraightFlush;

        public PossibleHands() {

            HighCard.Works = false;
            Pair.Works = false;
            TwoPair.Works = false;
            Threeofakind.Works = false;
            Straight.Works = false;
            Flush.Works = false;
            FullHouse.Works = false;
            FourofaKind.Works = false;
            StraightFlush.Works = false;

            HighCard.WhichHand = 0;
            Pair.WhichHand = 1;
            TwoPair.WhichHand = 2;
            Threeofakind.WhichHand = 3;
            Straight.WhichHand = 4;
            Flush.WhichHand = 5;
            FullHouse.WhichHand = 6;
            FourofaKind.WhichHand = 7;
            StraightFlush.WhichHand = 9;

            HighCard.Value = -1;
            Pair.Value = -1;
            TwoPair.Value = -1;
            Threeofakind.Value = -1;
            Straight.Value = -1;
            Flush.Value = -1;
            FullHouse.Value = -1;
            FourofaKind.Value = -1;
            StraightFlush.Value = -1;
        }

    };

    public class HoldemHand {

        ////////////////////////////////// Variables ////////////////////////////////////////////
        HumanPlayer TheHumanPlayer = new HumanPlayer(100.0, 10.0);
        ComputerPlayer TheComputerPlayer = new ComputerPlayer(100.0, 10.0);

        PokerHand HumanPlayerHand = new PokerHand();
        PokerHand ComputerPlayerHand = new PokerHand();

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

        // Get all possiple cards, that are not in either the field and the playres hands
        // This assumes Field has 5 cards, and each Player's Hand has 2 cards
        public static Card[] GetPossibleCards(Card[] Field, Card[] PlayerHand) {

            int Count = 0;
            int Occur = 0;

            Card[] PossibleCard = new Card[46];

            for (int i = 0; i < 52; i++) {

                //This is deck geneartion. 
                //There is 12 values, and 4 suits.
                //0-12 goes from Ace to King
                Card Temp = new Card {

                    Suite = i / 13,
                    Value = (int)Math.Floor((double)(i % 13))
                };

                // Sorry for how ugly this looks
                if (   (PlayerHand[0].Value == Temp.Value && PlayerHand[0].Suite == Temp.Suite)
                    || (PlayerHand[1].Value == Temp.Value && PlayerHand[1].Suite == Temp.Suite)
                    ||      (Field[0].Value == Temp.Value &&      Field[0].Suite == Temp.Suite)
                    ||      (Field[1].Value == Temp.Value &&      Field[1].Suite == Temp.Suite)
                    ||      (Field[2].Value == Temp.Value &&      Field[2].Suite == Temp.Suite)
                    ||      (Field[3].Value == Temp.Value &&      Field[3].Suite == Temp.Suite)
                    ||      (Field[4].Value == Temp.Value &&      Field[4].Suite == Temp.Suite)
                    ) {

                    Occur++;
                    ////Console.WriteLine("Card {0} {1} ALready there, with {2}", Temp.Value, Temp.Suite, Occur);
                }
                else {

                    ////Console.WriteLine("Card {0} {1} Joins the fight with {2} others", Temp.Value, Temp.Suite, Count);

                    //Now the Value of the card and the suit have been declared, Creating a card 
                    Count++;
                    PossibleCard[Count] = Temp;
                }
            }

            ////Console.WriteLine("Deck has {0} Cards, even though it should have {1}", PossibleCard.Length, Count);

            return PossibleCard;
        }

        // Find odds of win/draw/lose
        public void FindWinsDrawsAndLosses(Card[] Field, Card[] PlayerHand, Card[] CompHand) {

            //Getting all the possiple combinations part
            Card[] CheckForComb = new Card[7];

            CheckForComb[0] = Field[0];
            CheckForComb[1] = Field[1];
            CheckForComb[2] = Field[2];
            CheckForComb[3] = Field[3];
            CheckForComb[4] = Field[4];

            CheckForComb[5] = PlayerHand[0];
            CheckForComb[6] = PlayerHand[1];

            //Set the player Hand
            // Damn it Zaki
            //HumanPlayerHand.SetHandValue(GetHand(CheckForComb));
            HumanPlayerHand.SetHandValue(GetHand(CheckForComb, true));
            //Console.WriteLine("{0} {1}", PlayerHand[0].Value, PlayerHand[0].Suite  );
            //Console.WriteLine("{0} {1}", PlayerHand[1].Value, PlayerHand[1].Suite  );


            //Console.WriteLine("{0} {1}", Field[0].Value, Field[0].Suite  );
            //Console.WriteLine("{0} {1}", Field[1].Value, Field[1].Suite  );
            //Console.WriteLine("{0} {1}", Field[2].Value, Field[2].Suite  );
            //Console.WriteLine("{0} {1}", Field[3].Value, Field[3].Suite  );
            //Console.WriteLine("{0} {1}", Field[4].Value, Field[4].Suite  );


            CheckForComb[5] = CompHand[0];
            CheckForComb[6] = CompHand[1];

            // Set the CPU hands

             // Damn it Zaki
            ComputerPlayerHand.SetHandValue(GetHand(CheckForComb));

            Card[] PossibleCards = GetPossibleCards(Field, PlayerHand);

            PokerHand[] PossibleOpposingPokerHands = new PokerHand[990];

            int IncrementedValueToKeepTrackOfPossibleOpposingPokerHands = 0;

            //Get all possiple hands
            int Size = 44;
            for (int x = 0; x < Size; x++) {
                //Console.WriteLine("NEW LINE");
                for (int y = x; y < Size; y++) {

                    PossibleOpposingPokerHands[IncrementedValueToKeepTrackOfPossibleOpposingPokerHands] = new PokerHand();
                    CheckForComb[5] = PossibleCards[x];
                    CheckForComb[6] = PossibleCards[y];
                   PossibleOpposingPokerHands[IncrementedValueToKeepTrackOfPossibleOpposingPokerHands].SetHandValue(GetHand(CheckForComb));
                    IncrementedValueToKeepTrackOfPossibleOpposingPokerHands++;
                }
            }

            //Compare results
            for (int z = 0; z < 990; z++) {

                HumanPlayerHand.CompareTo(PossibleOpposingPokerHands[z]);
                //ComputerPlayerHand.CompareTo(PossibleOpposingPokerHands[z]);
            }



            CalculateOdds();
            //Console.WriteLine("FUCK YOUZAKI\n");
        }

        // Calculate the odds of win/draw/lose
        public void CalculateOdds() {

            HumanWinningOdds = Convert.ToDouble((HumanPlayerHand.Wins / 990) * 100);
            HumanLosingOdds = Convert.ToDouble((HumanPlayerHand.Loses / 990) * 100);
            HumanDrawingOdds = Convert.ToDouble((HumanPlayerHand.Draws / 990) * 100);
            ComputerWinningOdds = Convert.ToDouble((ComputerPlayerHand.Wins / 990) * 100);
            //ComputerWinningOdds = HumanLosingOdds;
            Console.WriteLine("The odds, ladies and zaki are \nwins\t{0}\ndraws\t{1}\nloses\t{2}", HumanWinningOdds
                , HumanDrawingOdds, HumanLosingOdds );
        }

        // This is used to get the Hand Value
        // Card values go from 2 to Ace
        // Each value score is from 10-90, as listed below
        //This goes in increments of 12:
        //So a highcard of jake will have a value of 10, while a pair of jake will have a value of 22.
        //If you guys don't wanna do it like that, tahn for hand comparision, we can compare who has the higher value combiantion
        //And if they both have the same one, we go by the combiantion's hand.
        
        /*
        | Score Multipler (multply by 12) | Multipler       | Total Score |
        |---------------------------------+-----------------+-------------|
        |                               0 | HighCard        |        0-12 |
        |                               1 | Pair            |       13-24 |
        |                               2 | TwoPair         |       25-36 |
        |                               3 | Three of a kind |       37-48 |
        |                               4 | Straight        |       49-60 |
        |                               5 | Flush           |       61-72 |
        |                               6 | FullHouse       |       73-84 |
        |                               7 | Four of a kind  |       85-96 |
        |                               8 | Straight  flush |      97-108 |
        |---------------------------------+-----------------+-------------|

         */
         //

//        public static HandValue[] GetHand(Card[] Arr, int wow) {
//
//             
//            //10 11 12 13 14 15 16 17 Field + PlayerHand
//            int Size = 20;
//            HandValue[] HandComb = new HandValue[Size];
//            int[,] CombinationIndex = new int[,]
//                //{{1, 2, 3, 4, 5},
//                {{1, 2, 3, 4, 6},
//                {1, 2, 3, 4, 7},
//                {1, 2, 3, 5, 6},
//                {1, 2, 3, 5, 7},
//
//                {1, 2, 3, 6, 7},
//                {1, 2, 4, 5, 6},
//                {1, 2, 4, 5, 7},
//                {1, 2, 4, 6, 7},
//                {1, 2, 5, 6, 7},
//
//                {1, 3, 4, 5, 6},
//                {1, 3, 4, 5, 7},
//                {1, 3, 4, 6, 7},
//                {1, 3, 5, 6, 7},
//                {1, 4, 5, 6, 7},
//
//                {2, 3, 4, 5, 6},
//                {2, 3, 4, 5, 7},
//                {2, 3, 4, 6, 7},
//                {2, 3, 5, 6, 7},
//                {2, 4, 5, 6, 7},
//
//                {3, 4, 5, 6, 7}};
//
//
//            for (int PosComb = 0; PosComb < 21; PosComb++)
//            {
//                Card[] TempCardComb = new Card[5];
//                for (int i = 0; i < 5; i++)
//                {
//                   //Console.WriteLine(i + "\t" + PosComb + "\t" + CombinationIndex[ PosComb,i]);
//                   TempCardComb[i] = Arr[CombinationIndex[PosComb,i]-1];
//                    Arr[CombinationIndex[PosComb, i] - 1].toString();
//                }
//                Console.WriteLine("");
//
//
//
//
//
//                // Copied form this https://youtu.be/2aEqFJWwXUE
//                // Order the array, than count the number of occurences of each suit, value.
//                IEnumerable<Card> OrderedTempCardComb = TempCardComb.OrderBy(x => x.Value);
//                Dictionary<int, int> Value = new Dictionary<int, int>();
//                Dictionary<int, int> Suite = new Dictionary<int, int>();
//
//                // Used to calcuate score
//                PossibleHands Score = new PossibleHands();
//
//                CheckForStraightAndStraightFlush(OrderedTempCardComb, Score, Value, Suite);
//
//                //Console.WriteLine();
//
//                CheckForFourAndThreeOfAKindAndFullHouseAndTwoPairAndHighcard(Value, Score);
//
//                //Console.WriteLine();
//
//                CheckForFlush(Suite, Score);
//
//                //Console.WriteLine();
//
//                HandComb[PosComb] = GetBestHand(Score);
//
//                //Console.WriteLine(Score.HighCard.Works + " For  HighCard " + Score.HighCard.Value);
//                //Console.WriteLine(Score.Pair.Works + " For  Pair " + Score.Pair.Value);
//                //Console.WriteLine(Score.TwoPair.Works + " For  TwoPair " + Score.TwoPair.Value);
//                //Console.WriteLine(Score.Threeofakind.Works + " For  Threeofakind " + Score.Threeofakind.Value);
//                //Console.WriteLine(Score.Straight.Works + " For  Straight " + Score.Straight.Value);
//                //Console.WriteLine(Score.Flush.Works + " For  Flush " + Score.Flush.Value);
//                //Console.WriteLine(Score.FullHouse.Works + " For  FullHouse " + Score.FullHouse.Value);
//                //Console.WriteLine(Score.FourofaKind.Works + " For  FourofaKind " + Score.FourofaKind.Value);
//                //Console.WriteLine(Score.StraightFlush.Works + " For  StraightFlush " + Score.StraightFlush.Value);
//                //Console.WriteLine();
//
//
//            }
//            return HandComb; ;
//        }



        public static HandValue[] GetHand(Card[] Arr, bool PrintCrap=false) {


            int Size = 21;
            HandValue[] HandComb = new HandValue[Size];
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



            for(int i=0; i<7 && PrintCrap; i++)
            {
                if (i < 5)
                    Console.WriteLine("Field Card is {0}", Arr[i].toString());
                else
                    Console.WriteLine("Player Card is {0}", Arr[i].toString());
            }
            for (int PosComb = 1; PosComb < Size; PosComb++)
            {
                Card[] TempCardComb = new Card[5];
                for (int i = 0; i < 5; i++)
                {
                   //Console.WriteLine(i + "\t" + PosComb + "\t" + CombinationIndex[ PosComb,i]);
                   TempCardComb[i] = Arr[CombinationIndex[PosComb,i]-1];
                    if (PrintCrap)
                    {
                        Console.WriteLine("{2} Index Comb Testing are {0} with value {1}", i,  Arr[CombinationIndex[PosComb, i] - 1].toString(), PosComb);
                    }
                }



                // Used to calcuate score
                PossibleHands Score = new PossibleHands();
                Score = GetScore(ref Score, TempCardComb);



                HandComb[PosComb] = GetBestHand(Score);

                if (PrintCrap)
                {
                    if (Score.HighCard.Works)
                        Console.Write(Score.HighCard.Works + " For  HighCard " + Score.HighCard.Value);
                    if (Score.Pair.Works)
                        Console.Write("\t" + Score.Pair.Works + " For  Pair " + Score.Pair.Value);
                    if (Score.TwoPair.Works)
                        Console.Write("\t" + Score.TwoPair.Works + " For  TwoPair " + Score.TwoPair.Value);
                    if (Score.Threeofakind.Works)
                        Console.Write("\t" + Score.Threeofakind.Works + " For  Threeofakind " + Score.Threeofakind.Value);
                    if (Score.Straight.Works)
                        Console.Write("\t" + Score.Straight.Works + " For  Straight " + Score.Straight.Value);
                    if (Score.Flush.Works)
                        Console.Write("\t" + Score.Flush.Works + " For  Flush " + Score.Flush.Value);
                    if (Score.FullHouse.Works)
                        Console.Write("\t" + Score.FullHouse.Works + " For  FullHouse " + Score.FullHouse.Value);
                    if (Score.FourofaKind.Works)
                        Console.Write("\t" + Score.FourofaKind.Works + " For  FourofaKind " + Score.FourofaKind.Value);
                    if (Score.StraightFlush.Works)
                        Console.Write("\t" + Score.StraightFlush.Works + " For  StraightFlush " + Score.StraightFlush.Value);
                    Console.WriteLine();
                }


            }
            return HandComb; ;
        }

        public static PossibleHands GetScore(ref PossibleHands Score, Card[] TempCardComb)
        {
                // Copied form this https://youtu.be/2aEqFJWwXUE
                // Order the array, than count the number of occurences of each suit, value.
                IEnumerable<Card> OrderedTempCardComb = TempCardComb.OrderBy(x => x.Value);
                Dictionary<int, int> Value = new Dictionary<int, int>();
                Dictionary<int, int> Suite = new Dictionary<int, int>();


                CheckForStraightAndStraightFlush(OrderedTempCardComb, Score, Value, Suite);

                //Console.WriteLine();

                CheckForFourAndThreeOfAKindAndFullHouseAndTwoPairAndHighcard(Value, Score);

                //Console.WriteLine();

                CheckForFlush(Suite, Score);

            //Console.WriteLine();
            return Score;

        }



        public void Test()
        {
            //public static Card[] GetPossibleCards(Card[] Field, Card[] PlayerHand) {
            GetPossibleCards(Field, PlayerHand);

            Card[] Temp = new Card[7];
            Temp[0] = Field[0];
            Temp[1] = Field[1];
            Temp[2] = Field[2];
            Temp[3] = Field[3];
            Temp[4] = Field[4];
            Temp[5] = PlayerHand[0];
            Temp[6] = PlayerHand[1];
            //GetHand(Temp);


            


            
            //public void FindWinsDrawsAndLosses(Card[] Field, Card[] PlayerHand, Card[] CompHand) {
            FindWinsDrawsAndLosses(Field, PlayerHand, ComputerHand);

        }
        // Get the Best hand out of all given scores
        public static HandValue GetBestHand(PossibleHands HandScores) {

            HandValue BestHand = new HandValue {

                Works = true
            };

            if (HandScores.StraightFlush.Works) {

                BestHand.Value = HandScores.StraightFlush.Value;
                BestHand.WhichHand = HandScores.StraightFlush.WhichHand;
            }
            else if (HandScores.FourofaKind.Works) {

                BestHand.Value = HandScores.FourofaKind.Value;
                BestHand.WhichHand = HandScores.FourofaKind.WhichHand;
            }
            else if (HandScores.FullHouse.Works) {

                BestHand.Value = HandScores.FullHouse.Value;
                BestHand.WhichHand = HandScores.FullHouse.WhichHand;
            }
            else if (HandScores.Flush.Works) {

                BestHand.Value = HandScores.Flush.Value;
                BestHand.WhichHand = HandScores.Flush.WhichHand;
            }
            else if (HandScores.Straight.Works) {

                BestHand.Value = HandScores.Straight.Value;
                BestHand.WhichHand = HandScores.Straight.WhichHand;
            }
            else if (HandScores.Threeofakind.Works) {

                BestHand.Value = HandScores.Threeofakind.Value;
                BestHand.WhichHand = HandScores.Threeofakind.WhichHand;
            }
            else if (HandScores.TwoPair.Works) {

                BestHand.Value = HandScores.TwoPair.Value;
                BestHand.WhichHand = HandScores.TwoPair.WhichHand;
            }
            else if (HandScores.Pair.Works) {

                BestHand.Value = HandScores.Pair.Value;
                BestHand.WhichHand = HandScores.Pair.WhichHand;
            }
            else if (HandScores.HighCard.Works) {

                BestHand.Value = HandScores.HighCard.Value;
                BestHand.WhichHand = HandScores.HighCard.WhichHand;
            }

            return BestHand;
        }

        public static void CheckForStraightAndStraightFlush(IEnumerable<Card> OrderedArr, PossibleHands Score, Dictionary<int, int> Value, Dictionary<int, int> Suite) {

            // Score checking. THIS EXPECTS 5 cards.
            //Pair and straight check
            int countVal = 1;
            int countSuit = 1;
            int iterValue = -1;
            int iterSuite = -1;

            foreach (Card i in OrderedArr) {

                //Console.Write("Card {0} {1} {2} {3}\t", i.Value, i.Suite, countVal, countSuit);

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

                    Score.Straight.Works = true;
                    Score.Straight.Value = i.Value;
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

                    Score.Flush.Works = true;
                    Score.Flush.Value = i.Value;

                    if (countVal >= 5) {
                        Score.StraightFlush.Works = true;
                        Score.StraightFlush.Value = i.Value;

                    }
                }

                if (Value.ContainsKey(i.Value))
                    Value[i.Value]++;
                else
                    Value[i.Value] = 1;

                if (Suite.ContainsKey(i.Suite))
                    Suite[i.Suite]++;
                else
                    Suite[i.Suite] = 1;

                //Console.WriteLine();
            }
        }

        public static void CheckForFourAndThreeOfAKindAndFullHouseAndTwoPairAndHighcard(Dictionary<int, int> Value, PossibleHands Score) {

            //Four-Three of a Kind, Full House, Two Pair, and Highcard CHecking
            foreach (var pair in Value) {

                //Console.WriteLine("Value {0} with {1} number", pair.Key, pair.Value);

                Score.HighCard.Value = pair.Key;
                Score.HighCard.Works = true;

                // Pair Checking
                if (pair.Value >= 2) {

                    if (pair.Value >= 4) {

                        Score.FourofaKind.Value = pair.Key;
                        Score.FourofaKind.Works = true;
                        Score.Threeofakind.Value = pair.Key;
                        Score.Threeofakind.Works = true;
                    }

                    if (pair.Value == 3) {

                        Score.Threeofakind.Value = pair.Key;
                        Score.Threeofakind.Works = true;

                        if (Score.Pair.Works) {

                            Score.FullHouse.Value = pair.Key;
                            Score.FullHouse.Works = true;
                        }
                    }

                    if (Score.Threeofakind.Works) {

                        Score.FullHouse.Value = pair.Key;
                        Score.FullHouse.Works = true;
                    }

                    if (Score.Pair.Works) {

                        Score.TwoPair.Value = pair.Key;
                        Score.TwoPair.Works = true;
                    }

                    Score.Pair.Value = pair.Key;
                    Score.Pair.Works = true;
                }
            }
        }

        public static void CheckForFlush(Dictionary<int, int> Suite, PossibleHands Score) {

            // Flush Checking
            foreach (var pair in Suite) {

                //Console.WriteLine("Suite is {0} of {1}", pair.Key, pair.Value);

                if (pair.Value >= 5) {

                    Score.Flush.Works = true;
                    Score.Flush.Value = pair.Value;
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////
    }
}
