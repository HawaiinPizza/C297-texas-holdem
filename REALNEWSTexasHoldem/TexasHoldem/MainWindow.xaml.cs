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

        private void ShowHumanPlayerCards() {

            int x = 0;
            while (x < 2) {

                switch (HoldemGame.PlayerHand[x].Value) {

                    case 0:
                        switch (HoldemGame.PlayerHand[x].Suite) {

                            case 0:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2S.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 1:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2C.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 2:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2H.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
                                        break;
                                }
                                break;

                            case 3:
                                switch (x) {

                                    case 0:

                                        BitmapImage CardFirstFace = new BitmapImage();
                                        CardFirstFace.BeginInit();
                                        CardFirstFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardFirstFace.EndInit();

                                        imgPlayerFirstCard.Stretch = Stretch.Fill;
                                        imgPlayerFirstCard.Source = CardFirstFace;
                                        break;

                                    case 1:

                                        BitmapImage CardSecondFace = new BitmapImage();
                                        CardSecondFace.BeginInit();
                                        CardSecondFace.UriSource = new Uri(@"\cs\2D.png", UriKind.Relative);
                                        CardSecondFace.EndInit();

                                        imgPlayerSecondCard.Stretch = Stretch.Fill;
                                        imgPlayerSecondCard.Source = CardSecondFace;
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
