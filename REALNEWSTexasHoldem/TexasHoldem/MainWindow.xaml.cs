using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TexasHoldem {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        double PlayerBet;

        string[] cardNumbers = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] cardSuites = new string[4] { "S", "C", "H", "D" };

        HoldemHand HoldemGame = new HoldemHand();

        public MainWindow() {

            InitializeComponent();
            HoldemGame.ShuffleDeck();
            HoldemGame.Odds();

            txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
            txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
            txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();

            HoldemGame.TheHumanPlayer.IsMyTurn = true;

            ShowHumanPlayerCards();
            ShowFieldCards();
            ShowComputerPlayerCards();
        }

        private void ShowHumanPlayerCards() {

            FirstPlayerCard.Content = $"{cardNumbers[HoldemGame.PlayerHand[0].Value]}{cardSuites[HoldemGame.PlayerHand[0].Suite]}";
            SecondPlayerCard.Content = $"{cardNumbers[HoldemGame.PlayerHand[1].Value]}{cardSuites[HoldemGame.PlayerHand[1].Suite]}";
        }

        private void ShowComputerPlayerCards() {

            FirstComputerCard.Content = $"{cardNumbers[HoldemGame.ComputerHand[0].Value]}{cardSuites[HoldemGame.ComputerHand[0].Suite]}";
            SecondComputerCard.Content = $"{cardNumbers[HoldemGame.ComputerHand[1].Value]}{cardSuites[HoldemGame.ComputerHand[1].Suite]}";
        }

        private void ShowFieldCards() {

            FirstFieldCard.Content = $"{cardNumbers[HoldemGame.Field[0].Value]}{cardSuites[HoldemGame.Field[0].Suite]}";
            SecondFieldCard.Content = $"{cardNumbers[HoldemGame.Field[1].Value]}{cardSuites[HoldemGame.Field[1].Suite]}";
            ThirdFieldCard.Content = $"{cardNumbers[HoldemGame.Field[2].Value]}{cardSuites[HoldemGame.Field[2].Suite]}";
            FourthFieldCard.Content = $"{cardNumbers[HoldemGame.Field[3].Value]}{cardSuites[HoldemGame.Field[3].Suite]}";
            FifthFieldCard.Content = $"{cardNumbers[HoldemGame.Field[4].Value]}{cardSuites[HoldemGame.Field[4].Suite]}";
        }

        private void BtnRaise_Click(object sender, RoutedEventArgs e) {

            if (HoldemGame.TheHumanPlayer.IsMyTurn && HoldemGame.TheHumanPlayer.PlayerBetAmount == HoldemGame.TheComputerPlayer.PlayerBetAmount) {

                double CurrentPot = Convert.ToDouble(txtbxPot.Text);
                PlayerBet = HoldemGame.TheHumanPlayer.PlayerBetAmount;

                HoldemGame.TheHumanPlayer.Raise(ref PlayerBet, ref CurrentPot);

                HoldemGame.TheHumanPlayer.PlayerBetAmount = PlayerBet;
                txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();
                txtbxPlayerMoney.Text = HoldemGame.TheHumanPlayer.PlayerMoney.ToString();
                txtbxPot.Text = CurrentPot.ToString();

                HoldemGame.TheHumanPlayer.IsMyTurn = false;
                HoldemGame.TheComputerPlayer.IsMyTurn = true;

                ComputerTurnIfPlayerRaises();
            }
        }

        private void BtnFold_Click(object sender, RoutedEventArgs e) {

            if (HoldemGame.TheHumanPlayer.IsMyTurn && ((HoldemGame.TheHumanPlayer.PlayerMoney + HoldemGame.TheHumanPlayer.PlayerBetAmount) != 0)) {

                HoldemGame.TheHumanPlayer.Fold();

                txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();
                txtbxPlayerMoney.Text = HoldemGame.TheHumanPlayer.PlayerMoney.ToString();

                HoldemGame.TheHumanPlayer.IsMyTurn = false;
                HoldemGame.TheComputerPlayer.IsMyTurn = true;

                ComputerTurnIfPlayerFolds();
            }
        }


        private void PlayerWins() {

            HoldemGame.TheHumanPlayer.PlayerMoney += Convert.ToDouble(txtbxPot.Text) - 10;
            HoldemGame.TheHumanPlayer.PlayerBetAmount = 10.0;

            HoldemGame.TheComputerPlayer.PlayerBetAmount = 10.0;

            txtbxComputerMoney.Text = HoldemGame.TheComputerPlayer.PlayerMoney.ToString();
            txtbxComputerBet.Text = HoldemGame.TheComputerPlayer.PlayerBetAmount.ToString();

            txtbxPlayerMoney.Text = HoldemGame.TheHumanPlayer.PlayerMoney.ToString();
            txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();

            txtbxPot.Text = Convert.ToString(HoldemGame.TheComputerPlayer.PlayerBetAmount + HoldemGame.TheHumanPlayer.PlayerBetAmount);

            HoldemGame.ShuffleDeck();
            HoldemGame.Odds();

            ShowHumanPlayerCards();
            ShowFieldCards();
            ShowComputerPlayerCards();

            txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
            txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
            txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
        }

        private void PlayerDraws() {

            if (HoldemGame.TheComputerPlayer.PlayerBetAmount > 10) {

                HoldemGame.TheComputerPlayer.PlayerMoney += 10.0;
                HoldemGame.TheComputerPlayer.PlayerBetAmount = 10.0;
            }

            if (HoldemGame.TheHumanPlayer.PlayerBetAmount > 10) {

                HoldemGame.TheHumanPlayer.PlayerMoney += 10.0;
                HoldemGame.TheHumanPlayer.PlayerBetAmount = 10.0;
            }

            txtbxPot.Text = Convert.ToString(HoldemGame.TheComputerPlayer.PlayerBetAmount + HoldemGame.TheHumanPlayer.PlayerBetAmount);

            HoldemGame.ShuffleDeck();
            HoldemGame.Odds();

            ShowHumanPlayerCards();
            ShowFieldCards();
            ShowComputerPlayerCards();

            txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
            txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
            txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
        }

        private void ComputerTurnIfPlayerFolds() {

            HoldemGame.TheComputerPlayer.PlayerMoney += Convert.ToDouble(txtbxPot.Text) - 10;
            HoldemGame.TheComputerPlayer.PlayerBetAmount = 10.0;

            txtbxComputerMoney.Text = HoldemGame.TheComputerPlayer.PlayerMoney.ToString();
            txtbxComputerBet.Text = HoldemGame.TheComputerPlayer.PlayerBetAmount.ToString();

            txtbxPot.Text = Convert.ToString(HoldemGame.TheComputerPlayer.PlayerBetAmount + HoldemGame.TheHumanPlayer.PlayerBetAmount);

            HoldemGame.ShuffleDeck();
            HoldemGame.Odds();

            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;

            ShowHumanPlayerCards();
            ShowFieldCards();
            ShowComputerPlayerCards();

            txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
            txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
            txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
        }

        private void PlayerLoses() {

            HoldemGame.TheComputerPlayer.PlayerMoney += Convert.ToDouble(txtbxPot.Text) - 10;
            HoldemGame.TheComputerPlayer.PlayerBetAmount = 10.0;

            txtbxComputerMoney.Text = HoldemGame.TheComputerPlayer.PlayerMoney.ToString();
            txtbxComputerBet.Text = HoldemGame.TheComputerPlayer.PlayerBetAmount.ToString();

            HoldemGame.TheHumanPlayer.Fold();

            txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();

            txtbxPot.Text = Convert.ToString(HoldemGame.TheComputerPlayer.PlayerBetAmount + HoldemGame.TheHumanPlayer.PlayerBetAmount);

            HoldemGame.ShuffleDeck();
            HoldemGame.Odds();

            ShowHumanPlayerCards();
            ShowFieldCards();
            ShowComputerPlayerCards();

            txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
            txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
            txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
        }

        private void ComputerTurnIfPlayerRaises() {


            Console.WriteLine("Total Moeny {0}", HoldemGame.TheComputerPlayer.PlayerMoney + HoldemGame.TheComputerPlayer.PlayerBetAmount);
            Console.WriteLine("Bet amount{0}", HoldemGame.TheHumanPlayer.PlayerBetAmount);
            if ((HoldemGame.TheComputerPlayer.PlayerMoney + HoldemGame.TheComputerPlayer.PlayerBetAmount) >= HoldemGame.TheHumanPlayer.PlayerBetAmount) {

                if (HoldemGame.ComputerWinningOdds >= 0) {

                    double CurrentPot = Convert.ToDouble(txtbxPot.Text);

                    HoldemGame.TheComputerPlayer.Call(HoldemGame.TheHumanPlayer.PlayerBetAmount, ref CurrentPot);

                    txtbxPot.Text = CurrentPot.ToString();

                    ShowComputerCardsAndCompare();
                }
                else {
                    MessageBox.Show("CPU odds" + HoldemGame.ComputerWinningOdds);

                    HoldemGame.TheComputerPlayer.Fold();

                    HoldemGame.TheHumanPlayer.PlayerMoney += Convert.ToDouble(txtbxPot.Text) - 10;
                    HoldemGame.TheHumanPlayer.PlayerBetAmount = 10.0;

                    txtbxPlayerMoney.Text = HoldemGame.TheHumanPlayer.PlayerMoney.ToString();
                    txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();
                    txtbxPot.Text = Convert.ToString(HoldemGame.TheComputerPlayer.PlayerBetAmount + HoldemGame.TheHumanPlayer.PlayerBetAmount);

                    HoldemGame.ShuffleDeck();
                    HoldemGame.Odds();

                    ShowHumanPlayerCards();
                    ShowFieldCards();
                    ShowComputerPlayerCards();

                    txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
                    txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
                    txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
                }
            }
            else {

                MessageBox.Show("Worse");
                HoldemGame.TheComputerPlayer.Fold();

                HoldemGame.TheHumanPlayer.PlayerMoney += Convert.ToDouble(txtbxPot.Text) - 10;
                HoldemGame.TheHumanPlayer.PlayerBetAmount = 10.0;

                txtbxPlayerMoney.Text = HoldemGame.TheHumanPlayer.PlayerMoney.ToString();
                txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();
                txtbxPot.Text = Convert.ToString(HoldemGame.TheComputerPlayer.PlayerBetAmount + HoldemGame.TheHumanPlayer.PlayerBetAmount);

                HoldemGame.ShuffleDeck();
                HoldemGame.Odds();

                ShowHumanPlayerCards();
                ShowFieldCards();
                ShowComputerPlayerCards();

                txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
                txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
                txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
            }

            HoldemGame.TheHumanPlayer.PlayerBetAmount = 10;
            txtbxComputerBet.Text = HoldemGame.TheComputerPlayer.PlayerBetAmount.ToString();
            txtbxComputerMoney.Text = HoldemGame.TheComputerPlayer.PlayerMoney.ToString();

            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;
        }


        private void ShowComputerCardsAndCompare() {


            Card[] Intro = new Card[7];
            Intro[0] =HoldemGame.Field[0];
            Intro[1] =HoldemGame.Field[1];
            Intro[2] =HoldemGame.Field[2];
            Intro[3] =HoldemGame.Field[3];
            Intro[4] =HoldemGame.Field[4];
            Intro[5] =HoldemGame.PlayerHand[0];
            Intro[6] =HoldemGame.PlayerHand[1];


            Comb[] PlayerCombs = new Comb[21];
            PlayerCombs = HoldemGame.GetCombs(Intro);
            Comb PlayerComb = new Comb();
            PlayerComb = PlayerCombs[0];
            for (int i = 0; i < 21; i++)
            {
                if (PlayerComb < PlayerCombs[i])
                    PlayerComb = PlayerCombs[i];

            }

            Intro[5] =HoldemGame.ComputerHand[0];
            Intro[6] =HoldemGame.ComputerHand[1];
            Comb[] ComputerCombs = new Comb[21];
            ComputerCombs = HoldemGame.GetCombs(Intro);
            Comb ComputerComb = new Comb();
            ComputerComb = ComputerCombs[0];
            for (int i = 0; i < 21; i++)
            {
                if (ComputerComb < ComputerCombs[i])
                    ComputerComb = ComputerCombs[i];
            }

            if (PlayerComb > ComputerComb) {
                PlayerWins();
            }
            else if(PlayerComb == ComputerComb)
            {
                PlayerDraws();

            }
            else
            {
                PlayerLoses();
                MessageBox.Show("WH");
            }
                
            HoldemGame.ShuffleDeck();
            HoldemGame.Odds();
            ShowHumanPlayerCards();
            ShowFieldCards();
            ShowComputerPlayerCards();
            txtbxPlayerOddsOfWinning.Text = HoldemGame.HumanWinningOdds.ToString();
            txtbxPlayerOddsOfLosing.Text = HoldemGame.HumanLosingOdds.ToString();
            txtbxPlayerOddsDraw.Text = HoldemGame.HumanDrawingOdds.ToString();
        }
    }
}
