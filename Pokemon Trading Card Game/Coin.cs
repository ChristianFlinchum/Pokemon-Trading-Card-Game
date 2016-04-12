using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trading_Card_Game
{
    class Coin
    {
        private string sideUp;
        Random rand = new Random();

        //Constructor
        public Coin()
        {
            sideUp = "Heads";
        }

        public void Toss()
        {
            if (rand.Next(2) == 0)
            {
                sideUp = "Heads";
            }
            else
            {
                sideUp = "Tails";
            }
        }

        public string GetSideUp()
        {
            return sideUp;
        }
    }
}
