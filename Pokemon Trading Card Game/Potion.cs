using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trading_Card_Game
{
    class Potion: PokemonCard
    {
        //Field
        private int _potionHeal;

        //Consrtuctor
        public Potion()
        {
            _potionHeal = 20;
        }

        public int ApplyPotion(int currentHP, int maxHP)
        {
            if ((currentHP + _potionHeal) <= maxHP)
            {
                currentHP += _potionHeal;
            }
            else if ((currentHP + (_potionHeal/2)) == maxHP)
            {
                currentHP += (_potionHeal / 2);
            }
            else
            {
                currentHP += 0;
            }

            return currentHP;
        }
    }
}
