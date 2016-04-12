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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnEnterTournament_Click(object sender, EventArgs e)
        {
            frmChooseDeck frmIChooseYou = new frmChooseDeck();

            this.Hide();

            frmIChooseYou.ShowDialog();

            this.Close();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
