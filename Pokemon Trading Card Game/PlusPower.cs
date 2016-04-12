using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trading_Card_Game
{
    class PlusPower: PokemonCard
    {
        //Fields
        private int _plusPower;

        //Consrtuctor
        public PlusPower()
        {
            _plusPower = 10;
        }

        public int ApplyPlusPower(int damage)
        {
            damage += _plusPower;
            return damage;
        }
    }
}
