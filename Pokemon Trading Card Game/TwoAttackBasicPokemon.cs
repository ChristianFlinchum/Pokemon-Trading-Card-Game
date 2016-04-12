using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trading_Card_Game
{
    class TwoAttackBasicPokemon: PokemonCard
    {
        //Field
        private bool _play;
        private bool _bench;
        private bool _hand;
        private bool _basic;
        private string _name;
        private string _type;
        private string _weakness;
        private string _resistanceType;
        private int _resistanceAmount;
        private int _hp;
        private int _retreatCost;
        private string _evolvesInto;
        private string _attack1Name;
        private int _attack1Damage;
        private bool _attack1UsesCoin;
        private bool _attack1HasEffect;
        private string _attack1EffectType;
        private string _attack1Description;
        private int _attack1EnergyRequired;
        private string _attack2Name;
        private int _attack2Damage;
        private bool _attack2UsesCoin;
        private bool _attack2HasEffect;
        private string _attack2EffectType;
        private string _attack2Description;
        private int _attack2EnergyRequired;
        
 
        //Constuctor
        public TwoAttackBasicPokemon(string name, string type, string weakness, string resistanceType,
            int resistanceAmount, int hp, int retreatCost, string evolvesInto, string attack1Name,
            int attack1Damage, bool attack1UsesCoin, bool attack1HasEffect, string attack1EffectType,
            string attack1Description, int attack1EnergyRequired, string attack2Name, int attack2Damage, bool attack2UsesCoin, 
            bool attack2HasEffect, string attack2EffectType, string attack2Description, int attack2EnergyRequired)
            : base ()
        {
            _basic = true;
            _play = false;
            _bench = false;
            _hand = false;
            _name = name;
            _type = type;
            _weakness = weakness;
            _resistanceType = resistanceType;
            _resistanceAmount = resistanceAmount;
            _hp = hp;
            _retreatCost = retreatCost;
            _evolvesInto = evolvesInto;
            _attack1Name = attack1Name;
            _attack1Damage = attack1Damage;
            _attack1UsesCoin = attack1UsesCoin;
            _attack1HasEffect = attack1HasEffect;
            _attack1EffectType = attack1EffectType;
            _attack1Description = attack1Description;
            _attack1EnergyRequired = attack1EnergyRequired;
            _attack2Name = attack2Name;
            _attack2Damage = attack2Damage;
            _attack2UsesCoin = attack2UsesCoin;
            _attack2HasEffect = attack2HasEffect;
            _attack2EffectType = attack2EffectType;
            _attack2Description = attack2Description;
            _attack2EnergyRequired = attack2EnergyRequired;
        }


        //Basic Property(Read-only)
        public bool Basic
        {
            get { return _basic; }
        }

        //Play property
        public bool Play
        {
            get { return _play; }
            set { _play = value; }
        }

        //Bench property
        public bool Bench
        {
            get { return _bench; }
            set { _bench = value; }
        }

        //Hand Property
        public bool Hand
        {
            get { return _hand; }
            set { _hand = value; }
        }

        //Name Property(Read-only)
        public string Name
        {
            get { return _name; }
        }

        //Type Property(Read-only)
        public string Type
        {
            get { return _type; }
        }

        //Weakness Property(Read-only)
        public string Weakness
        {
            get { return _weakness; }
        }

        //ResistanceType Property(Read-only)
        public string ResistanceType
        {
            get { return _resistanceType; }
        }

        //ResistanceAmount Property(Read-only)
        public int ResistanceAmount
        {
            get { return _resistanceAmount; }
        }

        //Hit Points Property(Read-only)
        public int HP
        {
            get { return _hp; }
        }

        //RetreatCost Property(Read-only)
        public int RetreatCost
        {
            get { return _retreatCost; }
        }
        
        //EvolvesInto Property(Read-only)
        public string EvolvesInto
        {
            get { return _evolvesInto; }
        }

        //Attack1Name Property(Read-only)
        public string Attack1Name
        {
            get { return _attack1Name; }
        }

        //Attack1Damage Property
        public int Attack1Damage
        {
            get { return _attack1Damage; }
            set { _attack1Damage = value; }
        }

        //Attack1UsesCoin Property(Read-only)
        public bool Attack1UsesCoin
        {
            get { return _attack1UsesCoin; }
        }

        //Attack1HasEffect Property(Read-only)
        public bool Attack1HasEffect
        {
            get { return _attack1HasEffect; }
        }

        //Attack1EffectType Property(Read-Only)
        public string Attack1EffectType
        {
            get { return _attack1EffectType; }
        }

        //Attack1Description Property(Read-only)
        public string Attack1Description
        {
            get { return _attack1Description; }
        }

        //Attack1EnergyRequired Property(Read-only)
        public int Attack1EnergyRequired
        {
            get { return _attack1EnergyRequired; }
        }

        //Attack2Name Property(Read-only)
        public string Attack2Name
        {
            get { return _attack2Name; }
        }

        //Attack2Damage Property
        public int Attack2Damage
        {
            get { return _attack2Damage; }
            set { _attack2Damage = value; }
        }

        //Attack2UsesCoin Property(Read-only)
        public bool Attack2UsesCoin
        {
            get { return _attack2UsesCoin; }
        }

        //Attack2HasEffect Property(Read-only)
        public bool Attack2HasEffect
        {
            get { return _attack2HasEffect; }
        }

        //Attack2EffectType Property(Read-Only)
        public string Attack2EffectType
        {
            get { return _attack2EffectType; }
        }

        //Attack2Description Property(Read-only)
        public string Attack2Description
        {
            get { return _attack2Description; }
        }

        //Attack2EnergyRequired Property(Read-only)
        public int Attack2EnergyRequired
        {
            get { return _attack2EnergyRequired; }
        }
    }
}
