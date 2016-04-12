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
    public partial class frmChooseDeck : Form
    {
        private string deck;
        
        public frmChooseDeck()
        {
            InitializeComponent();
        }
      
        private void btnSquirtle_Click(object sender, EventArgs e)
        {
            deck = "Water";
                  
            frmBattle1Intro frmBattle1Water = new frmBattle1Intro(deck);
                       
            this.Hide();

            frmBattle1Water.ShowDialog();

            this.Close();
        }

        private void btnBulbasuar_Click(object sender, EventArgs e)
        {
            deck = "Grass";
            
            frmBattle1Intro frmBattle1Grass = new frmBattle1Intro(deck);

            this.Hide();

            frmBattle1Grass.ShowDialog();

            this.Close();
        }

        private void btnCharmandar_Click(object sender, EventArgs e)
        {
            deck = "Fire";
            
            frmBattle1Intro frmBattle1Fire = new frmBattle1Intro(deck);
                        
            this.Hide();

            frmBattle1Fire.ShowDialog();

            this.Close();
        }
    }
}
