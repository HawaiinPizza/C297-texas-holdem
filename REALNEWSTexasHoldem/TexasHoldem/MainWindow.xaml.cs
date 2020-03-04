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
        int PlayerBet;
        int CPUBet;

        public MainWindow() {

            InitializeComponent();
            HoldemHand TellMe = new HoldemHand();
            TellMe.Test();
        }

        private void BtnRaise_Click(object sender, RoutedEventArgs e){
            PlayerMoney = Convert.ToInt32(txtbxPlayerMoney.Text);
            PlayerBet = Convert.ToInt32(txtbxPlayerBet.Text);
            CPUMoney = Convert.ToInt32(txtbxComputerMoney.Text);
            CPUBet = Convert.ToInt32(txtbxComputerBet.Text);

            if(PlayerBet > CPUBet)
                {
                PlayerBet = PlayerBet + CPUBet;
                txtbxPlayerBet.Text = PlayerBet.ToString();
            }
            else if (PlayerBet == CPUBet)
            {
                PlayerBet = PlayerBet + CPUBet;
                txtbxPlayerBet.Text = PlayerBet.ToString();
            }

        }

        private void BtnFold_Click(object sender, RoutedEventArgs e) {


        }

        private void txtbxPlayerOddsDraw_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
