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
    public partial class frmBattle1Intro : Form
    {
        private string deckType;
        
        public frmBattle1Intro(string _deckType)
        {
            InitializeComponent();

            deckType = _deckType;
        }

        private void btnBattle1_Click(object sender, EventArgs e)
        {
            frmGameBoard frmGameboard = new frmGameBoard(deckType);

            this.Hide();

            frmGameboard.ShowDialog();

            this.Close();
        }
    }
}
