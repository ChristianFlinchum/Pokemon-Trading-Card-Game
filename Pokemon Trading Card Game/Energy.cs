using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trading_Card_Game
{
    class Energy: PokemonCard
    {
        //Fields
        private string _energyType;
        private int _energyAmount;
        private bool _energyAttached;
        private string _attachedTo;

        //Constructor
        public Energy(string energyType)
        {
            _energyType = energyType;
            _energyAmount = 1;
            _energyAttached = false;
            _attachedTo = "";
        }

        //EnergyType Property(Read-only)
        public string EnergyType
        {
            get { return _energyType; }
        }

        //EnergyAmount Property(Read-only)
        public int EnergyAmount
        {
            get { return _energyAmount; }
        }

        //EnergyAttached Property
        public bool EnergyAttached
        {
            get { return _energyAttached; }
            set { _energyAttached = value; }
        }

        //AttachedTo Property
        public string AttachedTo
        {
            get { return _attachedTo; }
            set { _attachedTo = value; }
        }
    }
}
