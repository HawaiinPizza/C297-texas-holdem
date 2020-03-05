using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace TexasHoldem {

    public class Player {

        public double PlayerMoney { get; set; }
        public double PlayerBetAmount { get; set; }

        public bool IsMyTurn = false;

        public void Fold() {

            if (PlayerMoney <= 0) {

                PlayerBetAmount = 0;
            }
            else {

                PlayerMoney -= 10;
                PlayerBetAmount = 10;
            }
        }
    }

    public class HumanPlayer : Player {

        public HumanPlayer(double StartingMoney, double StartingBet) {

            PlayerMoney = StartingMoney;
            PlayerBetAmount = StartingBet;
        }

        public void Raise(ref double ThisPlayerCurrentBet, ref double CurrentPot) {

            if (PlayerMoney < ThisPlayerCurrentBet) {

                MessageBox.Show("You Do NOT Have Enough Money To Raise");
            }
            else {

                CurrentPot += ThisPlayerCurrentBet;
                PlayerMoney -= ThisPlayerCurrentBet;
                ThisPlayerCurrentBet *= 2;
            }
        }
    }

    public class ComputerPlayer : Player {

        public ComputerPlayer(double StartingMoney, double StartingBet) {

            PlayerMoney = StartingMoney;
            PlayerBetAmount = StartingBet;
        }

        public void Call(double OtherPlayerCurrentBet, ref double CurrentPot) {

            double CurretBetDifference = OtherPlayerCurrentBet - PlayerBetAmount;

            PlayerBetAmount += CurretBetDifference;
            PlayerMoney -= CurretBetDifference;
            CurrentPot += CurretBetDifference;
        }
    }
}
