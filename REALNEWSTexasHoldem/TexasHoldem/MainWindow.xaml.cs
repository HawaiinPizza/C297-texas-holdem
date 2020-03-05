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

        int PlayerMoney;
        int CPUMoney;
        double PlayerBet;
        int CPUBet;

        HoldemHand HoldemGame = new HoldemHand();

        public MainWindow() {

            InitializeComponent();
            HoldemGame.ShuffleDeck();
            HoldemGame.TheHumanPlayer.IsMyTurn = true;
        }

        private void BtnRaise_Click(object sender, RoutedEventArgs e){

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

            if (HoldemGame.TheHumanPlayer.IsMyTurn) {

                HoldemGame.TheHumanPlayer.Fold();

                txtbxPlayerBet.Text = HoldemGame.TheHumanPlayer.PlayerBetAmount.ToString();
                txtbxPlayerMoney.Text = HoldemGame.TheHumanPlayer.PlayerMoney.ToString();

                HoldemGame.TheHumanPlayer.IsMyTurn = false;
                HoldemGame.TheComputerPlayer.IsMyTurn = true;
            }    
        }

        private void BtnNeither_Click(object sender, RoutedEventArgs e) {


        }

        private void ComputerTurnIfPlayerFolds() {



            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;

            ShowAndCompareCards();
        }

        private void ComputerTurnIfPlayerRaises() {

            if (HoldemGame.TheComputerPlayer.PlayerMoney + HoldemGame.TheComputerPlayer.PlayerBetAmount !< HoldemGame.TheHumanPlayer.PlayerBetAmount) {
                
                if (HoldemGame.ComputerWinningOdds >= 50.0) {

                    double CurrentPot = Convert.ToDouble(txtbxPot.Text);

                    HoldemGame.TheComputerPlayer.Call(HoldemGame.TheHumanPlayer.PlayerBetAmount, ref CurrentPot);

                    txtbxPot.Text = CurrentPot.ToString();
                }
                else {

                    HoldemGame.TheComputerPlayer.Fold();
                }
            }
            else {

                HoldemGame.TheComputerPlayer.Fold();
            }

            txtbxComputerBet.Text = HoldemGame.TheComputerPlayer.PlayerBetAmount.ToString();
            txtbxComputerMoney.Text = HoldemGame.TheComputerPlayer.PlayerMoney.ToString();

            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;

            ShowAndCompareCards();
        }

        private void ShowAndCompareCards() {


        }
    }
}
