using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trading_Card_Game
{
    class OneAttackBasicPokemon: PokemonCard
    {
        //Field
        private bool _basic;
        private bool _play;
        private bool _bench;
        private bool _hand;
        private string _name;
        private string _type;
        private string _weakness;
        private string _resistanceType;
        private int _resistanceAmount;
        private int _hp;
        private int _retreatCost;
        private string _evolvesInto;
        private string _attackName;
        private int _attackDamage;
        private bool _attackUsesCoin;
        private bool _attackHasEffect;
        private string _attackEffectType;
        private string _attackDescription;
        private int _attackEnergyRequired;
        
 
        //Constuctor
        public OneAttackBasicPokemon(string name, string type, string weakness, string resistanceType,
            int resistanceAmount, int hp, int retreatCost, string evolvesInto, string attackName,
            int attackDamage, bool attackUsesCoin, bool attackHasEffect, string attackEffectType,
            string attackDescription, int attackEnergyRequired)
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
            _attackName = attackName;
            _attackDamage = attackDamage;
            _attackUsesCoin = attackUsesCoin;
            _attackHasEffect = attackHasEffect;
            _attackEffectType = attackEffectType;
            _attackDescription = attackDescription;
            _attackEnergyRequired = attackEnergyRequired;
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

        //AttackName Property(Read-only)
        public string AttackName
        {
            get { return _attackName; }
        }

        //AttackDamage Property
        public int AttackDamage
        {
            get { return _attackDamage; }
            set { _attackDamage = value; }
        }

        //AttackUsesCoin Property(Read-only)
        public bool AttackUsesCoin
        {
            get { return _attackUsesCoin; }
        }

        //AttackHasEffect Property(Read-only)
        public bool AttackHasEffect
        {
            get { return _attackHasEffect; }
        }

        //AttackEffectType Property(Read-Only)
        public string AttackEffectType
        {
            get { return _attackEffectType; }
        }

        //AttackDescription Property(Read-only)
        public string AttackDescription
        {
            get { return _attackDescription; }
        }

        //AttackEnergyRequired Property(Read-only)
        public int AttackEnergyRequired
        {
            get { return _attackEnergyRequired; }
        }
    }
}
