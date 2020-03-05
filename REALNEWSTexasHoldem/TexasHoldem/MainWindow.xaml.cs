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

            ShowHumanPlayerCards();
        }

        private void ShowHumanPlayerCards() {

            int x = 0;
            while (x < 2) {

                switch (HoldemGame.PlayerHand[x].Value) {

                    case 0:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\2S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\2S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\2C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\2C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\2H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\2H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\2D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\2D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 1:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\3S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\3S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\3C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\3C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\3H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\3H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\3D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\3D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 2:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\4S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\4S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\4C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\4C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\4H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\4H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\4D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\4D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 3:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\5S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\5S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\5C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\5C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\5H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\5H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\5D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\5D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 4:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\6S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\6S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\6C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\6C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\6H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\6H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\6D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\6D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 5:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\7S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\7S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\7C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\7C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\7H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\7H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\7D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\7D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 6:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\8S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\8S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\8C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\8C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\8H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\8H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\8D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\8D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 7:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\9S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\9S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\9C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\9C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\9H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\9H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\9D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\9D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 8:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\10S.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\10S.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\10C.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\10C.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\10H.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\10H.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\10D.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\10D.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 9:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\JS.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\JS.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\JC.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\JC.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\JH.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\JH.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\JD.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\JD.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 10:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\QS.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\QS.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\QC.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\QC.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\QH.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\QH.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\QD.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\QD.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 11:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\KS.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\KS.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\KC.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\KC.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\KH.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\KH.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\KD.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\KD.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 12:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\AS.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\AS.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\AC.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\AC.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\AH.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\AH.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:
                                        imgPlayerFirstCard.Source = new BitmapImage(new Uri(@"\cs\AD.png", UriKind.Relative));
                                        break;

                                    case 1:
                                        imgPlayerSecondCard.Source = new BitmapImage(new Uri(@"\cs\AD.png", UriKind.Relative));
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                x++;
            }
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

            HoldemGame.TheHumanPlayer.IsMyTurn = false;
            HoldemGame.TheComputerPlayer.IsMyTurn = true;

            ComputerTurnIfPlayerNeitherFoldsNorRaises();
        }

        private void ComputerTurnIfPlayerFolds() {



            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;
        }

        private void ComputerTurnIfPlayerRaises() {

            if ((HoldemGame.TheComputerPlayer.PlayerMoney + HoldemGame.TheComputerPlayer.PlayerBetAmount) !< HoldemGame.TheHumanPlayer.PlayerBetAmount) {
                
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

            ShowComputerCardsAndCompare();

            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;
        }

        private void ComputerTurnIfPlayerNeitherFoldsNorRaises() {

            ShowComputerCardsAndCompare();

            HoldemGame.TheHumanPlayer.IsMyTurn = true;
            HoldemGame.TheComputerPlayer.IsMyTurn = false;
        }

        private void ShowComputerCardsAndCompare() {


        }
    }
}
