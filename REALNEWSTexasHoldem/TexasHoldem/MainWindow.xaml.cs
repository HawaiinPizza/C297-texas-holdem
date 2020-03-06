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

            int x = 0;
            while (x < 2) {

                switch (HoldemGame.PlayerHand[x].Value) {

                    case 0:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "2S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "2S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "2C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "2C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "2H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "2H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "2D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "2D";
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

                                        FirstPlayerCard.Content = "3S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "3S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "3C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "3C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "3H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "3H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "3D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "3D";
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

                                        FirstPlayerCard.Content = "4S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "4S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "4C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "4C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "4H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "4H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "4D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "4D";
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

                                        FirstPlayerCard.Content = "5S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "5S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "5C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "5C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "5H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "5H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "5D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "5D";
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

                                        FirstPlayerCard.Content = "6S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "6S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "6C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "6C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "6H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "6H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "6D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "6D";
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

                                        FirstPlayerCard.Content = "7S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "7S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "7C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "7C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "7H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "7H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "7D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "7D";
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

                                        FirstPlayerCard.Content = "8S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "8S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "8C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "8C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "8H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "8H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "8D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "8D";
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

                                        FirstPlayerCard.Content = "9S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "9S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "9C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "9C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "9H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "9H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "9D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "9D";
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

                                        FirstPlayerCard.Content = "10S";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "10S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "10C";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "10C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "10H";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "10H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "10D";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "10D";
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

                                        FirstPlayerCard.Content = "JS";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "JS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "JC";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "JC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "JH";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "JH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "JD";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "JD";
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

                                        FirstPlayerCard.Content = "QS";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "QS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "QC";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "QC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "QH";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "QH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "QD";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "QD";
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

                                        FirstPlayerCard.Content = "KS";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "KS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "KC";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "KC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "KH";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "KH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "KD";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "KD";
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

                                        FirstPlayerCard.Content = "AS";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "AS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "AC";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "AC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "AH";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "AH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstPlayerCard.Content = "AD";
                                        break;

                                    case 1:

                                        SecondPlayerCard.Content = "AD";
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

        private void ShowComputerPlayerCards() {

            int x = 0;
            while (x < 2) {

                switch (HoldemGame.ComputerHand[x].Value) {

                    case 0:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "2S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "2S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "2C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "2C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "2H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "2H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "2D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "2D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 1:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "3S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "3S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "3C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "3C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "3H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "3H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "3D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "3D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 2:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "4S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "4S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "4C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "4C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "4H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "4H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "4D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "4D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 3:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "5S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "5S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "5C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "5C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "5H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "5H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "5D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "5D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 4:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "6S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "6S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "6C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "6C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "6H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "6H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "6D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "6D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 5:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "7S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "7S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "7C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "7C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "7H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "7H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "7D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "7D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 6:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "8S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "8S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "8C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "8C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "8H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "8H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "8D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "8D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 7:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "9S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "9S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "9C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "9C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "9H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "9H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "9D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "9D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 8:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "10S";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "10S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "10C";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "10C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "10H";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "10H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "10D";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "10D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 9:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "JS";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "JS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "JC";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "JC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "JH";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "JH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "JD";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "JD";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 10:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "QS";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "QS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "QC";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "QC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "QH";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "QH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "QD";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "QD";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 11:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "KS";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "KS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "KC";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "KC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "KH";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "KH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "KD";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "KD";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 12:
                        switch (HoldemGame.ComputerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "AS";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "AS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "AC";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "AC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "AH";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "AH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstComputerCard.Content = "AD";
                                        break;

                                    case 1:

                                        SecondComputerCard.Content = "AD";
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

        private void ShowFieldCards() {

            int x = 0;
            while (x < 5) {

                switch (HoldemGame.Field[x].Value) {

                    case 0:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "2S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "2S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "2S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "2S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "2S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "2C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "2C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "2C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "2C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "2C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "2H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "2H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "2H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "2H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "2H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "2D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "2D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "2D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "2D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "2D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 1:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "3S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "3S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "3S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "3S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "3S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "3C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "3C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "3C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "3C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "3C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "3H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "3H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "3H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "3H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "3H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "3D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "3D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "3D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "3D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "3D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 2:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "4S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "4S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "4S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "4S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "4S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "4C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "4C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "4C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "4C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "4C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "4H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "4H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "4H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "4H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "4H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "4D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "4D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "4D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "4D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "4D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 3:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "5S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "5S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "5S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "5S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "5S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "5C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "5C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "5C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "5C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "5C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "5H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "5H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "5H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "5H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "5H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "5D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "5D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "5D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "5D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "5D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 4:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "6S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "6S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "6S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "6S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "6S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "6C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "6C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "6C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "6C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "6C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "6H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "6H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "6H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "6H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "6H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "6D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "6D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "6D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "6D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "6D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 5:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "7S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "7S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "7S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "7S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "7S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "7C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "7C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "7C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "7C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "7C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "7H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "7H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "7H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "7H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "7H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "7D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "7D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "7D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "7D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "7D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 6:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "8S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "8S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "8S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "8S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "8S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "8C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "8C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "8C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "8C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "8C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "8H";
                                        break;


                                    case 1:

                                        SecondFieldCard.Content = "8H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "8H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "8H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "8H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "8D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "8D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "8D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "8D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "8D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 7:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "9S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "9S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "9S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "9S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "9S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "9C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "9C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "9C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "9C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "9C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "9H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "9H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "9H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "9H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "9H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "9D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "9D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "9D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "9D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "9D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 8:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "10S";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "10S";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "10S";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "10S";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "10S";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "10C";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "10C";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "10C";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "10C";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "10C";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "10H";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "10H";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "10H";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "10H";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "10H";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "10D";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "10D";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "10D";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "10D";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "10D";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 9:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "JS";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "JS";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "JS";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "JS";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "JS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "JC";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "JC";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "JC";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "JC";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "JC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "JH";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "JH";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "JH";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "JH";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "JH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "JD";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "JD";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "JD";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "JD";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "JD";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 10:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "QS";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "QS";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "QS";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "QS";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "QS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "QC";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "QC";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "QC";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "QC";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "QC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "QH";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "QH";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "QH";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "QH";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "QH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "QD";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "QD";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "QD";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "QD";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "QD";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 11:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "KS";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "KS";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "KS";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "KS";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "KS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "KC";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "KC";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "KC";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "KC";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "KC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "KH";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "KH";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "KH";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "KH";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "KH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "KD";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "KD";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "KD";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "KD";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "KD";
                                        break;
                                }
                                break;

                            default:
                                break;
                        }
                        break;

                    case 12:
                        switch (HoldemGame.Field[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "AS";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "AS";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "AS";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "AS";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "AS";
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "AC";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "AC";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "AC";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "AC";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "AC";
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "AH";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "AH";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "AH";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "AH";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "AH";
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        FirstFieldCard.Content = "AD";
                                        break;

                                    case 1:

                                        SecondFieldCard.Content = "AD";
                                        break;

                                    case 2:

                                        ThirdFieldCard.Content = "AD";
                                        break;

                                    case 3:

                                        FourthFieldCard.Content = "AD";
                                        break;

                                    case 4:

                                        FifthFieldCard.Content = "AD";
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
