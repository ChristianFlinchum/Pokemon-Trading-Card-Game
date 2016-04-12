using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Trading_Card_Game
{
    public partial class frmCoinToss : Form
    {
        public frmCoinToss()
        {
            InitializeComponent();
        }

        private void DisplayCoin1(string firstCoinSide)
        {
            if (firstCoinSide == "Heads")
            {
                pbxCoin1.Image = imlCoins.Images[0];
            }
            else
            {
                pbxCoin1.Image = imlCoins.Images[1];
            }
        }

        private void DisplayCoin2(string secondCoinSide)
        {
            if (secondCoinSide == "Heads")
            {
                pbxCoin2.Image = imlCoins.Images[0];
            }
            else
            {
                pbxCoin2.Image = imlCoins.Images[1];
            }
        }

        public void btnCoin1_Click(object sender, EventArgs e)
        {
            string firstCoin;

            Coin coin1 = new Coin();

            coin1.Toss();

            firstCoin = coin1.GetSideUp();

            DisplayCoin1(firstCoin);
        }

        public void btnCoin2_Click(object sender, EventArgs e)
        {
            string secondCoin;

            Coin coin2 = new Coin();

            coin2.Toss();

            secondCoin = coin2.GetSideUp();

            DisplayCoin2(secondCoin);
        }
    }
}
