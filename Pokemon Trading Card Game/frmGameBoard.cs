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
    public partial class frmGameBoard : Form
    {
        const int DECK_SIZE = 60;
        const int HAND_SIZE = 19;
        const int PRIZE_NUMBER = 6;
        const int DRAW_SEVEN = 7;
        private string deckType;
        private int gameStage = 0;

        PokemonCard[] PlayerDeck = new PokemonCard[DECK_SIZE];
        PokemonCard[] PlayersHand = new PokemonCard[HAND_SIZE];
        PokemonCard[] Prizes = new PokemonCard[PRIZE_NUMBER];
        object[] SquirtleAndFriendsDeck = new object[DECK_SIZE];
        PokemonCard[] BulbasaurAndFriendsDeck = new PokemonCard[DECK_SIZE];
        PokemonCard[] CharmanderAndFriendsDeck = new PokemonCard[DECK_SIZE];
       
        //Squirtle and Friends Deck objects
        TwoAttackBasicPokemon Squirtle1 = new TwoAttackBasicPokemon("Squirtle", "Water", "Electric", "None", 0, 40, 1,
            "Wartortle", "Bubble", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now" +
            " Paralyzed.", 1, "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage done to" +
            " Squirtle during your opponent's next turn. (Any other effects of attacks still happen.)", 2);
        TwoAttackBasicPokemon Squirtle2 = new TwoAttackBasicPokemon("Squirtle", "Water", "Electric", "None", 0, 40, 1,
            "Wartortle", "Bubble", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now" +
            " Paralyzed.", 1, "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage done to" +
            " Squirtle during your opponent's next turn. (Any other effects of attacks still happen.)", 2);
        TwoAttackBasicPokemon Squirtle3 = new TwoAttackBasicPokemon("Squirtle", "Water", "Electric", "None", 0, 40, 1,
            "Wartortle", "Bubble", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now" +
            " Paralyzed.", 1, "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage done to" +
            " Squirtle during your opponent's next turn. (Any other effects of attacks still happen.)", 2);
        TwoAttackBasicPokemon Squirtle4 = new TwoAttackBasicPokemon("Squirtle", "Water", "Electric", "None", 0, 40, 1,
            "Wartortle", "Bubble", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now" +
            " Paralyzed.", 1, "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage done to" +
            " Squirtle during your opponent's next turn. (Any other effects of attacks still happen.)", 2);
        TwoAttackEvolutionaryPokemon Wartortle1 = new TwoAttackEvolutionaryPokemon("Wartortle", "Water", "Electric", "None",
            0, 70, 1, "None", "Squirtle", "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage" +
            " done to Wartortle during your opponent's next turn. (Any other effects of attacks still happen.)", 2, "Bite",
            40, false, false, "None", "None", 3);
        TwoAttackEvolutionaryPokemon Wartortle2 = new TwoAttackEvolutionaryPokemon("Wartortle", "Water", "Electric", "None",
            0, 70, 1, "None", "Squirtle", "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage" +
            " done to Wartortle during your opponent's next turn. (Any other effects of attacks still happen.)", 2, "Bite",
            40, false, false, "None", "None", 3);
        TwoAttackEvolutionaryPokemon Wartortle3 = new TwoAttackEvolutionaryPokemon("Wartortle", "Water", "Electric", "None",
            0, 70, 1, "None", "Squirtle", "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage" +
            " done to Wartortle during your opponent's next turn. (Any other effects of attacks still happen.)", 2, "Bite",
            40, false, false, "None", "None", 3);
        TwoAttackEvolutionaryPokemon Wartortle4 = new TwoAttackEvolutionaryPokemon("Wartortle", "Water", "Electric", "None",
            0, 70, 1, "None", "Squirtle", "Withdraw", 0, true, false, "None", "Flip a coin. If heads, prevent all damage" +
            " done to Wartortle during your opponent's next turn. (Any other effects of attacks still happen.)", 2, "Bite",
            40, false, false, "None", "None", 3);
        OneAttackBasicPokemon SquirtleRocket1 = new OneAttackBasicPokemon("Squirtle(Rocket)", "Water", "Electric", "None", 0,
            50, 1, "None", "Shell Attack", 20, false, false, "None", "None", 2);
        OneAttackBasicPokemon SquirtleRocket2 = new OneAttackBasicPokemon("Squirtle(Rocket)", "Water", "Electric", "None", 0,
            50, 1, "None", "Shell Attack", 20, false, false, "None", "None", 2);
        OneAttackBasicPokemon SquirtleRocket3 = new OneAttackBasicPokemon("Squirtle(Rocket)", "Water", "Electric", "None", 0,
            50, 1, "None", "Shell Attack", 20, false, false, "None", "None", 2);
        OneAttackBasicPokemon SquirtleRocket4 = new OneAttackBasicPokemon("Squirtle(Rocket)", "Water", "Electric", "None", 0,
            50, 1, "None", "Shell Attack", 20, false, false, "None", "None", 2);
        TwoAttackBasicPokemon Magikarp1 = new TwoAttackBasicPokemon("Magikarp", "Water", "Electric", "None", 0, 30, 1,
            "Gyarados", "Tackle", 10, false, false, "None", "None", 1, "Flail", 10, false, false, "None", "Does 10" +
            " damage times the number of damage counters on Magikarp.", 1);
        TwoAttackBasicPokemon Magikarp2 = new TwoAttackBasicPokemon("Magikarp", "Water", "Electric", "None", 0, 30, 1,
            "Gyarados", "Tackle", 10, false, false, "None", "None", 1, "Flail", 10, false, false, "None", "Does 10" +
            " damage times the number of damage counters on Magikarp.", 1);
        TwoAttackBasicPokemon Magikarp3 = new TwoAttackBasicPokemon("Magikarp", "Water", "Electric", "None", 0, 30, 1,
            "Gyarados", "Tackle", 10, false, false, "None", "None", 1, "Flail", 10, false, false, "None", "Does 10" +
            " damage times the number of damage counters on Magikarp.", 1);
        TwoAttackBasicPokemon Magikarp4 = new TwoAttackBasicPokemon("Magikarp", "Water", "Electric", "None", 0, 30, 1,
            "Gyarados", "Tackle", 10, false, false, "None", "None", 1, "Flail", 10, false, false, "None", "Does 10" +
            " damage times the number of damage counters on Magikarp.", 1);
        TwoAttackEvolutionaryPokemon Gyarados1 = new TwoAttackEvolutionaryPokemon("Gyarados", "Water", "Grass",
            "Fighting", 30, 100, 3, "None", "Magikarp", "Dragon Rage", 50, false, false, "None", "None", 3, "Bubblebeam",
            40, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        TwoAttackEvolutionaryPokemon Gyarados2 = new TwoAttackEvolutionaryPokemon("Gyarados", "Water", "Grass",
            "Fighting", 30, 100, 3, "None", "Magikarp", "Dragon Rage", 50, false, false, "None", "None", 3, "Bubblebeam",
            40, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        TwoAttackEvolutionaryPokemon Gyarados3 = new TwoAttackEvolutionaryPokemon("Gyarados", "Water", "Grass",
            "Fighting", 30, 100, 3, "None", "Magikarp", "Dragon Rage", 50, false, false, "None", "None", 3, "Bubblebeam",
            40, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        TwoAttackEvolutionaryPokemon Gyarados4 = new TwoAttackEvolutionaryPokemon("Gyarados", "Water", "Grass",
            "Fighting", 30, 100, 3, "None", "Magikarp", "Dragon Rage", 50, false, false, "None", "None", 3, "Bubblebeam",
            40, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        OneAttackBasicPokemon Seel1 = new OneAttackBasicPokemon("Seel", "Water", "Electric", "None", 0, 60, 1, "Dewgong",
            "Headbutt", 10, false, false, "None", "None", 1);
        OneAttackBasicPokemon Seel2 = new OneAttackBasicPokemon("Seel", "Water", "Electric", "None", 0, 60, 1, "Dewgong",
            "Headbutt", 10, false, false, "None", "None", 1);
        OneAttackBasicPokemon Seel3 = new OneAttackBasicPokemon("Seel", "Water", "Electric", "None", 0, 60, 1, "Dewgong",
            "Headbutt", 10, false, false, "None", "None", 1);
        OneAttackBasicPokemon Seel4 = new OneAttackBasicPokemon("Seel", "Water", "Electric", "None", 0, 60, 1, "Dewgong",
            "Headbutt", 10, false, false, "None", "None", 1);
        TwoAttackEvolutionaryPokemon Dewgong1 = new TwoAttackEvolutionaryPokemon("Dewgong", "Water", "Electric", "None", 0,
            80, 3, "None", "Seel", "Aurora Beam", 50, false, false, "None", "None", 3, "Ice Beam", 30, true, true, "Paralyze",
            "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        TwoAttackEvolutionaryPokemon Dewgong2 = new TwoAttackEvolutionaryPokemon("Dewgong", "Water", "Electric", "None", 0,
            80, 3, "None", "Seel", "Aurora Beam", 50, false, false, "None", "None", 3, "Ice Beam", 30, true, true, "Paralyze",
            "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        TwoAttackEvolutionaryPokemon Dewgong3 = new TwoAttackEvolutionaryPokemon("Dewgong", "Water", "Electric", "None", 0,
            80, 3, "None", "Seel", "Aurora Beam", 50, false, false, "None", "None", 3, "Ice Beam", 30, true, true, "Paralyze",
            "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        TwoAttackEvolutionaryPokemon Dewgong4 = new TwoAttackEvolutionaryPokemon("Dewgong", "Water", "Electric", "None", 0,
            80, 3, "None", "Seel", "Aurora Beam", 50, false, false, "None", "None", 3, "Ice Beam", 30, true, true, "Paralyze",
            "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 4);
        OneAttackBasicPokemon Meowth1 = new OneAttackBasicPokemon("Meowth", "Normal", "Fighting", "Psychic", 30, 50, 1,
            "Persian", "Pay Day", 10, true, false, "None", "Flip a coin. If heads, draw a card.", 2);
        OneAttackBasicPokemon Meowth2 = new OneAttackBasicPokemon("Meowth", "Normal", "Fighting", "Psychic", 30, 50, 1,
            "Persian", "Pay Day", 10, true, false, "None", "Flip a coin. If heads, draw a card.", 2);
        OneAttackBasicPokemon Meowth3 = new OneAttackBasicPokemon("Meowth", "Normal", "Fighting", "Psychic", 30, 50, 1,
            "Persian", "Pay Day", 10, true, false, "None", "Flip a coin. If heads, draw a card.", 2);
        OneAttackBasicPokemon Meowth4 = new OneAttackBasicPokemon("Meowth", "Normal", "Fighting", "Psychic", 30, 50, 1,
            "Persian", "Pay Day", 10, true, false, "None", "Flip a coin. If heads, draw a card.", 2);
        TwoAttackEvolutionaryPokemon Persian1 = new TwoAttackEvolutionaryPokemon("Persian", "Normal", "Fighting", "Psychic",
            30, 70, 0, "None", "Meowth", "Scratch", 20, false, false, "None", "None", 2, "Pounce", 30, false, false, "None",
            "If the Defending Pokemon attacks Persian During your opponent's next turn, any damage done by the attack is" +
            " reduced by 10(after applying Weakness and Resistance).(Benching either Pokemon ends this effect.)", 3);
        TwoAttackEvolutionaryPokemon Persian2 = new TwoAttackEvolutionaryPokemon("Persian", "Normal", "Fighting", "Psychic",
            30, 70, 0, "None", "Meowth", "Scratch", 20, false, false, "None", "None", 2, "Pounce", 30, false, false, "None",
            "If the Defending Pokemon attacks Persian During your opponent's next turn, any damage done by the attack is" +
            " reduced by 10(after applying Weakness and Resistance).(Benching either Pokemon ends this effect.)", 3);
        TwoAttackEvolutionaryPokemon Persian3 = new TwoAttackEvolutionaryPokemon("Persian", "Normal", "Fighting", "Psychic",
            30, 70, 0, "None", "Meowth", "Scratch", 20, false, false, "None", "None", 2, "Pounce", 30, false, false, "None",
            "If the Defending Pokemon attacks Persian During your opponent's next turn, any damage done by the attack is" +
            " reduced by 10(after applying Weakness and Resistance).(Benching either Pokemon ends this effect.)", 3);
        TwoAttackEvolutionaryPokemon Persian4 = new TwoAttackEvolutionaryPokemon("Persian", "Normal", "Fighting", "Psychic",
            30, 70, 0, "None", "Meowth", "Scratch", 20, false, false, "None", "None", 2, "Pounce", 30, false, false, "None",
            "If the Defending Pokemon attacks Persian During your opponent's next turn, any damage done by the attack is" +
            " reduced by 10(after applying Weakness and Resistance).(Benching either Pokemon ends this effect.)", 3);
        Potion WaterPotion1 = new Potion();
        Potion WaterPotion2 = new Potion();
        Potion WaterPotion3 = new Potion();
        Potion WaterPotion4 = new Potion();
        Energy WaterEnergy1 = new Energy("Water");
        Energy WaterEnergy2 = new Energy("Water");
        Energy WaterEnergy3 = new Energy("Water");
        Energy WaterEnergy4 = new Energy("Water");
        Energy WaterEnergy5 = new Energy("Water");
        Energy WaterEnergy6 = new Energy("Water");
        Energy WaterEnergy7 = new Energy("Water");
        Energy WaterEnergy8 = new Energy("Water");
        Energy WaterEnergy9 = new Energy("Water");
        Energy WaterEnergy10 = new Energy("Water");
        Energy WaterEnergy11 = new Energy("Water");
        Energy WaterEnergy12 = new Energy("Water");
        Energy WaterEnergy13 = new Energy("Water");
        Energy WaterEnergy14 = new Energy("Water");
        Energy WaterEnergy15 = new Energy("Water");
        Energy WaterEnergy16 = new Energy("Water");
        Energy WaterEnergy17 = new Energy("Water");
        Energy WaterEnergy18 = new Energy("Water");
        Energy WaterEnergy19 = new Energy("Water");
        Energy WaterEnergy20 = new Energy("Water");

        //Bulbasaur and Friends Deck objects
        OneAttackBasicPokemon Bulbasaur1 = new OneAttackBasicPokemon("Bulbasaur", "Grass", "Fire", "None", 0, 40,
            1, "Ivysaur", "Leech Seed", 20, false, false, "None", "Unless all damage from this attack is" +
            " prevented, you may remove 1 damage counter from Bulbasaur.", 2);
        OneAttackBasicPokemon Bulbasaur2 = new OneAttackBasicPokemon("Bulbasaur", "Grass", "Fire", "None", 0, 40,
            1, "Ivysaur", "Leech Seed", 20, false, false, "None", "Unless all damage from this attack is" +
            " prevented, you may remove 1 damage counter from Bulbasaur.", 2);
        OneAttackBasicPokemon Bulbasaur3 = new OneAttackBasicPokemon("Bulbasaur", "Grass", "Fire", "None", 0, 40,
            1, "Ivysaur", "Leech Seed", 20, false, false, "None", "Unless all damage from this attack is" +
            " prevented, you may remove 1 damage counter from Bulbasaur.", 2);
        OneAttackBasicPokemon Bulbasaur4 = new OneAttackBasicPokemon("Bulbasaur", "Grass", "Fire", "None", 0, 40,
            1, "Ivysaur", "Leech Seed", 20, false, false, "None", "Unless all damage from this attack is" +
            " prevented, you may remove 1 damage counter from Bulbasaur.", 2);
        TwoAttackEvolutionaryPokemon Ivysaur1 = new TwoAttackEvolutionaryPokemon("Ivysaur", "Grass", "Fire", "None",
            0, 60, 1, "None", "Bulbasuar", "Vine Whip", 30, false, false, "None", "None", 3, "Poisonpowder", 20,
            false, true, "Poison", "The Defending Pokemon is now Poisoned.", 3);
        TwoAttackEvolutionaryPokemon Ivysaur2 = new TwoAttackEvolutionaryPokemon("Ivysaur", "Grass", "Fire", "None",
            0, 60, 1, "None", "Bulbasuar", "Vine Whip", 30, false, false, "None", "None", 3, "Poisonpowder", 20,
            false, true, "Poison", "The Defending Pokemon is now Poisoned.", 3);
        TwoAttackEvolutionaryPokemon Ivysaur3 = new TwoAttackEvolutionaryPokemon("Ivysaur", "Grass", "Fire", "None",
            0, 60, 1, "None", "Bulbasuar", "Vine Whip", 30, false, false, "None", "None", 3, "Poisonpowder", 20,
            false, true, "Poison", "The Defending Pokemon is now Poisoned.", 3);
        TwoAttackEvolutionaryPokemon Ivysaur4 = new TwoAttackEvolutionaryPokemon("Ivysaur", "Grass", "Fire", "None",
            0, 60, 1, "None", "Bulbasuar", "Vine Whip", 30, false, false, "None", "None", 3, "Poisonpowder", 20,
            false, true, "Poison", "The Defending Pokemon is now Poisoned.", 3);
        TwoAttackBasicPokemon ErikasBulbasaur1 = new TwoAttackBasicPokemon("Erika's Bulbasaur", "Grass", "Fire", "None",
            0, 50, 1, "None", "Sleep Seed", 10, false, true, "Sleep", "The Defending Pokemon is now Asleep.",
            1, "Errand-Running", 0, true, true, "Select Trainer Card From Deck", "Flip a coin. If heads, you may search"
            + " your deck for a Trainer card. Show it to your opponent and put it into your hand. Shuffle Deck afterward.",
            2);
        TwoAttackBasicPokemon ErikasBulbasaur2 = new TwoAttackBasicPokemon("Erika's Bulbasaur", "Grass", "Fire", "None",
            0, 50, 1, "None", "Sleep Seed", 10, false, true, "Sleep", "The Defending Pokemon is now Asleep.",
            1, "Errand-Running", 0, true, true, "Select Trainer Card From Deck", "Flip a coin. If heads, you may search"
            + " your deck for a Trainer card. Show it to your opponent and put it into your hand. Shuffle Deck afterward.",
            2);
        TwoAttackBasicPokemon ErikasBulbasaur3 = new TwoAttackBasicPokemon("Erika's Bulbasaur", "Grass", "Fire", "None",
            0, 50, 1, "None", "Sleep Seed", 10, false, true, "Sleep", "The Defending Pokemon is now Asleep.",
            1, "Errand-Running", 0, true, true, "Select Trainer Card From Deck", "Flip a coin. If heads, you may search"
            + " your deck for a Trainer card. Show it to your opponent and put it into your hand. Shuffle Deck afterward.",
            2);
        TwoAttackBasicPokemon ErikasBulbasaur4 = new TwoAttackBasicPokemon("Erika's Bulbasaur", "Grass", "Fire", "None",
            0, 50, 1, "None", "Sleep Seed", 10, false, true, "Sleep", "The Defending Pokemon is now Asleep.",
            1, "Errand-Running", 0, true, true, "Select Trainer Card From Deck", "Flip a coin. If heads, you may search"
            + " your deck for a Trainer card. Show it to your opponent and put it into your hand. Shuffle Deck afterward.",
            2);
        OneAttackBasicPokemon Nidoran1 = new OneAttackBasicPokemon("Nidoran", "Grass", "Psychic", "None", 0, 40, 1,
            "Nidorino", "Horn Hazard", 30, true, false, "None", "Flip a coin. If tails, this attack does nothing.", 1);
        OneAttackBasicPokemon Nidoran2 = new OneAttackBasicPokemon("Nidoran", "Grass", "Psychic", "None", 0, 40, 1,
            "Nidorino", "Horn Hazard", 30, true, false, "None", "Flip a coin. If tails, this attack does nothing.", 1);
        OneAttackBasicPokemon Nidoran3 = new OneAttackBasicPokemon("Nidoran", "Grass", "Psychic", "None", 0, 40, 1,
            "Nidorino", "Horn Hazard", 30, true, false, "None", "Flip a coin. If tails, this attack does nothing.", 1);
        OneAttackBasicPokemon Nidoran4 = new OneAttackBasicPokemon("Nidoran", "Grass", "Psychic", "None", 0, 40, 1,
            "Nidorino", "Horn Hazard", 30, true, false, "None", "Flip a coin. If tails, this attack does nothing.", 1);
        TwoAttackEvolutionaryPokemon Nidorino1 = new TwoAttackEvolutionaryPokemon("Nidorino", "Grass", "Psychic", "None",
            0, 60, 1, "Nidoking", "Nidoran", "Double Kick", 30, true, false, "None", "Flip 2 Coins. This attack does 30" +
            " damage times the number of heads.", 3, "Horn Drill", 50, false, false, "None", "None", 4);
        TwoAttackEvolutionaryPokemon Nidorino2 = new TwoAttackEvolutionaryPokemon("Nidorino", "Grass", "Psychic", "None",
            0, 60, 1, "Nidoking", "Nidoran", "Double Kick", 30, true, false, "None", "Flip 2 Coins. This attack does 30" +
            " damage times the number of heads.", 3, "Horn Drill", 50, false, false, "None", "None", 4);
        TwoAttackEvolutionaryPokemon Nidorino3 = new TwoAttackEvolutionaryPokemon("Nidorino", "Grass", "Psychic", "None",
            0, 60, 1, "Nidoking", "Nidoran", "Double Kick", 30, true, false, "None", "Flip 2 Coins. This attack does 30" +
            " damage times the number of heads.", 3, "Horn Drill", 50, false, false, "None", "None", 4);
        TwoAttackEvolutionaryPokemon Nidorino4 = new TwoAttackEvolutionaryPokemon("Nidorino", "Grass", "Psychic", "None",
            0, 60, 1, "Nidoking", "Nidoran", "Double Kick", 30, true, false, "None", "Flip 2 Coins. This attack does 30" +
            " damage times the number of heads.", 3, "Horn Drill", 50, false, false, "None", "None", 4);
        TwoAttackEvolutionaryPokemon Nidoking1 = new TwoAttackEvolutionaryPokemon("Nidoking", "Grass", "Psychic", "None", 0,
            90, 3, "None", "Nidorino", "Thrash", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage and Nidoking does 10 damage to itself.", 3,
            "Toxic", 20, false, true, "Toxic Poison", "The Defending Pokemon is now Poisoned. It now takes 20 Poison damage" +
            " instead of 10 after each player's turn (even if it was already Poisoned).", 3);
        TwoAttackEvolutionaryPokemon Nidoking2 = new TwoAttackEvolutionaryPokemon("Nidoking", "Grass", "Psychic", "None", 0,
            90, 3, "None", "Nidorino", "Thrash", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage and Nidoking does 10 damage to itself.", 3,
            "Toxic", 20, false, true, "Toxic Poison", "The Defending Pokemon is now Poisoned. It now takes 20 Poison damage" +
            " instead of 10 after each player's turn (even if it was already Poisoned).", 3);
        TwoAttackEvolutionaryPokemon Nidoking3 = new TwoAttackEvolutionaryPokemon("Nidoking", "Grass", "Psychic", "None", 0,
            90, 3, "None", "Nidorino", "Thrash", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage and Nidoking does 10 damage to itself.", 3,
            "Toxic", 20, false, true, "Toxic Poison", "The Defending Pokemon is now Poisoned. It now takes 20 Poison damage" +
            " instead of 10 after each player's turn (even if it was already Poisoned).", 3);
        TwoAttackEvolutionaryPokemon Nidoking4 = new TwoAttackEvolutionaryPokemon("Nidoking", "Grass", "Psychic", "None", 0,
            90, 3, "None", "Nidorino", "Thrash", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage and Nidoking does 10 damage to itself.", 3,
            "Toxic", 20, false, true, "Toxic Poison", "The Defending Pokemon is now Poisoned. It now takes 20 Poison damage" +
            " instead of 10 after each player's turn (even if it was already Poisoned).", 3);
        TwoAttackBasicPokemon RocketsScyther1 = new TwoAttackBasicPokemon("Rocket's Scyther", "Grass", "Fire", "Fighting", 30,
            60, 1, "None", "Shadow Images", 0, false, false, "None", "Whenever Rocket's Scyther is attacked, your" +
            " opponent flips a coin. If tails, that attack does no damage to Rocket's Scyther. (Any other effects of the" +
            " attack still happen.) This effect lasts until Rocket's Scyther takes damage(or is Benched or is evolved).",
            1, "Blinding Scythe", 40, false, false, "None", "None", 3);
        TwoAttackBasicPokemon RocketsScyther2 = new TwoAttackBasicPokemon("Rocket's Scyther", "Grass", "Fire", "Fighting", 30,
            60, 1, "None", "Shadow Images", 0, false, false, "None", "Whenever Rocket's Scyther is attacked, your" +
            " opponent flips a coin. If tails, that attack does no damage to Rocket's Scyther. (Any other effects of the" +
            " attack still happen.) This effect lasts until Rocket's Scyther takes damage(or is Benched or is evolved).",
            1, "Blinding Scythe", 40, false, false, "None", "None", 3);
        TwoAttackBasicPokemon RocketsScyther3 = new TwoAttackBasicPokemon("Rocket's Scyther", "Grass", "Fire", "Fighting", 30,
            60, 1, "None", "Shadow Images", 0, false, false, "None", "Whenever Rocket's Scyther is attacked, your" +
            " opponent flips a coin. If tails, that attack does no damage to Rocket's Scyther. (Any other effects of the" +
            " attack still happen.) This effect lasts until Rocket's Scyther takes damage(or is Benched or is evolved).",
            1, "Blinding Scythe", 40, false, false, "None", "None", 3);
        TwoAttackBasicPokemon RocketsScyther4 = new TwoAttackBasicPokemon("Rocket's Scyther", "Grass", "Fire", "Fighting", 30,
            60, 1, "None", "Shadow Images", 0, false, false, "None", "Whenever Rocket's Scyther is attacked, your" +
            " opponent flips a coin. If tails, that attack does no damage to Rocket's Scyther. (Any other effects of the" +
            " attack still happen.) This effect lasts until Rocket's Scyther takes damage(or is Benched or is evolved).",
            1, "Blinding Scythe", 40, false, false, "None", "None", 3);
        OneAttackBasicPokemon Caterpie1 = new OneAttackBasicPokemon("Caterpie", "Grass", "Fire", "None", 0, 40, 1, "None",
            "String Shot", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 1);
        OneAttackBasicPokemon Caterpie2 = new OneAttackBasicPokemon("Caterpie", "Grass", "Fire", "None", 0, 40, 1, "None",
            "String Shot", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 1);
        OneAttackBasicPokemon Caterpie3 = new OneAttackBasicPokemon("Caterpie", "Grass", "Fire", "None", 0, 40, 1, "None",
            "String Shot", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 1);
        OneAttackBasicPokemon Caterpie4 = new OneAttackBasicPokemon("Caterpie", "Grass", "Fire", "None", 0, 40, 1, "None",
            "String Shot", 10, true, true, "Paralyze", "Flip a coin. If heads, the Defending Pokemon is now Paralyzed.", 1);
        Potion GrassPotion1 = new Potion();
        Potion GrassPotion2 = new Potion();
        Potion GrassPotion3 = new Potion();
        Potion GrassPotion4 = new Potion();
        PlusPower GrassPlusPower1 = new PlusPower();
        PlusPower GrassPlusPower2 = new PlusPower();
        PlusPower GrassPlusPower3 = new PlusPower();
        PlusPower GrassPlusPower4 = new PlusPower();
        Energy GrassEnergy1 = new Energy("Grass");
        Energy GrassEnergy2 = new Energy("Grass");
        Energy GrassEnergy3 = new Energy("Grass");
        Energy GrassEnergy4 = new Energy("Grass");
        Energy GrassEnergy5 = new Energy("Grass");
        Energy GrassEnergy6 = new Energy("Grass");
        Energy GrassEnergy7 = new Energy("Grass");
        Energy GrassEnergy8 = new Energy("Grass");
        Energy GrassEnergy9 = new Energy("Grass");
        Energy GrassEnergy10 = new Energy("Grass");
        Energy GrassEnergy11 = new Energy("Grass");
        Energy GrassEnergy12 = new Energy("Grass");
        Energy GrassEnergy13 = new Energy("Grass");
        Energy GrassEnergy14 = new Energy("Grass");
        Energy GrassEnergy15 = new Energy("Grass");
        Energy GrassEnergy16 = new Energy("Grass");
        Energy GrassEnergy17 = new Energy("Grass");
        Energy GrassEnergy18 = new Energy("Grass");
        Energy GrassEnergy19 = new Energy("Grass");
        Energy GrassEnergy20 = new Energy("Grass");

        //Carmander and Friends Deck Objects
        TwoAttackBasicPokemon Charmander1 = new TwoAttackBasicPokemon("Charmander", "Fire", "Water", "None", 0, 50, 1,
            "Charmeleon", "Scratch", 10, false, false, "None", "None", 1, "Ember", 30, false, false, "None", "Discard" +
            " 1 Fire Energy card attached to Charmander in order to use this attack.", 2);
        TwoAttackBasicPokemon Charmander2 = new TwoAttackBasicPokemon("Charmander", "Fire", "Water", "None", 0, 50, 1,
            "Charmeleon", "Scratch", 10, false, false, "None", "None", 1, "Ember", 30, false, false, "None", "Discard" +
            " 1 Fire Energy card attached to Charmander in order to use this attack.", 2);
        TwoAttackBasicPokemon Charmander3 = new TwoAttackBasicPokemon("Charmander", "Fire", "Water", "None", 0, 50, 1,
            "Charmeleon", "Scratch", 10, false, false, "None", "None", 1, "Ember", 30, false, false, "None", "Discard" +
            " 1 Fire Energy card attached to Charmander in order to use this attack.", 2);
        TwoAttackBasicPokemon Charmander4 = new TwoAttackBasicPokemon("Charmander", "Fire", "Water", "None", 0, 50, 1,
            "Charmeleon", "Scratch", 10, false, false, "None", "None", 1, "Ember", 30, false, false, "None", "Discard" +
            " 1 Fire Energy card attached to Charmander in order to use this attack.", 2);
        TwoAttackEvolutionaryPokemon Charmeleon1 = new TwoAttackEvolutionaryPokemon("Charmeleon", "Fire", "Water", "None",
            0, 80, 1, "None", "Charmeleon", "Slash", 30, false, false, "None", "None", 3, "Flamethrower", 50, false, false,
            "None", "Discard 1 Fire Energy card attached to Charmeleon in order to use this attack.", 3);
        TwoAttackEvolutionaryPokemon Charmeleon2 = new TwoAttackEvolutionaryPokemon("Charmeleon", "Fire", "Water", "None",
            0, 80, 1, "None", "Charmeleon", "Slash", 30, false, false, "None", "None", 3, "Flamethrower", 50, false, false,
            "None", "Discard 1 Fire Energy card attached to Charmeleon in order to use this attack.", 3);
        TwoAttackEvolutionaryPokemon Charmeleon3 = new TwoAttackEvolutionaryPokemon("Charmeleon", "Fire", "Water", "None",
            0, 80, 1, "None", "Charmeleon", "Slash", 30, false, false, "None", "None", 3, "Flamethrower", 50, false, false,
            "None", "Discard 1 Fire Energy card attached to Charmeleon in order to use this attack.", 3);
        TwoAttackEvolutionaryPokemon Charmeleon4 = new TwoAttackEvolutionaryPokemon("Charmeleon", "Fire", "Water", "None",
            0, 80, 1, "None", "Charmeleon", "Slash", 30, false, false, "None", "None", 3, "Flamethrower", 50, false, false,
            "None", "Discard 1 Fire Energy card attached to Charmeleon in order to use this attack.", 3);
        TwoAttackBasicPokemon BlainesCharmander1 = new TwoAttackBasicPokemon("Blaine's Charmander", "Fire", "Water", "None",
            0, 50, 1, "None", "Kindle", 10, false, false, "None", "Discard 1 Energy card attached to Blaine's Charmander" +
            " in order to use this attack. If the Defending Pokemon has any Energy cards attached to it, choose 1 of them" +
            " and discard it", 1, "Slash", 20, false, false, "None", "None", 2);
        TwoAttackBasicPokemon BlainesCharmander2 = new TwoAttackBasicPokemon("Blaine's Charmander", "Fire", "Water", "None",
            0, 50, 1, "None", "Kindle", 10, false, false, "None", "Discard 1 Energy card attached to Blaine's Charmander" +
            " in order to use this attack. If the Defending Pokemon has any Energy cards attached to it, choose 1 of them" +
            " and discard it", 1, "Slash", 20, false, false, "None", "None", 2);
        TwoAttackBasicPokemon BlainesCharmander3 = new TwoAttackBasicPokemon("Blaine's Charmander", "Fire", "Water", "None",
            0, 50, 1, "None", "Kindle", 10, false, false, "None", "Discard 1 Energy card attached to Blaine's Charmander" +
            " in order to use this attack. If the Defending Pokemon has any Energy cards attached to it, choose 1 of them" +
            " and discard it", 1, "Slash", 20, false, false, "None", "None", 2);
        TwoAttackBasicPokemon BlainesCharmander4 = new TwoAttackBasicPokemon("Blaine's Charmander", "Fire", "Water", "None",
            0, 50, 1, "None", "Kindle", 10, false, false, "None", "Discard 1 Energy card attached to Blaine's Charmander" +
            " in order to use this attack. If the Defending Pokemon has any Energy cards attached to it, choose 1 of them" +
            " and discard it", 1, "Slash", 20, false, false, "None", "None", 2);
        OneAttackBasicPokemon BlainesGrowlithe1 = new OneAttackBasicPokemon("Blaine's Growlithe", "Fire", "Water", "None", 0,
            50, 1, "None", "Blaze", 20, false, false, "None", "Does 10 damage to each Grass Pokemon on your opponent's" +
            " Bench. (Don't apply Weakness and Resistance for Benched Pokemon.", 2);
        OneAttackBasicPokemon BlainesGrowlithe2 = new OneAttackBasicPokemon("Blaine's Growlithe", "Fire", "Water", "None", 0,
            50, 1, "None", "Blaze", 20, false, false, "None", "Does 10 damage to each Grass Pokemon on your opponent's" +
            " Bench. (Don't apply Weakness and Resistance for Benched Pokemon.", 2);
        OneAttackBasicPokemon BlainesGrowlithe3 = new OneAttackBasicPokemon("Blaine's Growlithe", "Fire", "Water", "None", 0,
            50, 1, "None", "Blaze", 20, false, false, "None", "Does 10 damage to each Grass Pokemon on your opponent's" +
            " Bench. (Don't apply Weakness and Resistance for Benched Pokemon.", 2);
        OneAttackBasicPokemon BlainesGrowlithe4 = new OneAttackBasicPokemon("Blaine's Growlithe", "Fire", "Water", "None", 0,
            50, 1, "None", "Blaze", 20, false, false, "None", "Does 10 damage to each Grass Pokemon on your opponent's" +
            " Bench. (Don't apply Weakness and Resistance for Benched Pokemon.", 2);
        OneAttackBasicPokemon Vulpix1 = new OneAttackBasicPokemon("Vulpix", "Fire", "Water", "None", 0, 50, 1, "None",
            "Confuse Ray", 10, true, true, "Confused", "Flip a coin. If heads, the Defending Pokemon is now Confused.", 2);
        OneAttackBasicPokemon Vulpix2 = new OneAttackBasicPokemon("Vulpix", "Fire", "Water", "None", 0, 50, 1, "None",
            "Confuse Ray", 10, true, true, "Confused", "Flip a coin. If heads, the Defending Pokemon is now Confused.", 2);
        OneAttackBasicPokemon Vulpix3 = new OneAttackBasicPokemon("Vulpix", "Fire", "Water", "None", 0, 50, 1, "None",
            "Confuse Ray", 10, true, true, "Confused", "Flip a coin. If heads, the Defending Pokemon is now Confused.", 2);
        TwoAttackBasicPokemon BrocksVulpix1 = new TwoAttackBasicPokemon("Brock's Vulpix", "Fire", "Water", "None", 0, 40, 1,
            "None", "Flame", 20, false, false, "None", "None", 1, "Quick Attack", 10, true, false, "None", "Flip a coin." +
            " If heads, this attack does 10 damage plus 20 more damage; if tails, this attack does 10 damage.", 2);
        TwoAttackBasicPokemon BrocksVulpix2 = new TwoAttackBasicPokemon("Brock's Vulpix", "Fire", "Water", "None", 0, 40, 1,
            "None", "Flame", 20, false, false, "None", "None", 1, "Quick Attack", 10, true, false, "None", "Flip a coin." +
            " If heads, this attack does 10 damage plus 20 more damage; if tails, this attack does 10 damage.", 2);
        TwoAttackBasicPokemon BrocksVulpix3 = new TwoAttackBasicPokemon("Brock's Vulpix", "Fire", "Water", "None", 0, 40, 1,
            "None", "Flame", 20, false, false, "None", "None", 1, "Quick Attack", 10, true, false, "None", "Flip a coin." +
            " If heads, this attack does 10 damage plus 20 more damage; if tails, this attack does 10 damage.", 2);
        TwoAttackBasicPokemon Magmar1 = new TwoAttackBasicPokemon("Magmar", "Fire", "Water", "None", 0, 70, 1, "None",
            "Smokescreen", 10, false, false, "None", "If the Defending Pokemon tries to attack during your opponent's" +
            " next turn, your opponent flips a coin. If tails, that attack does nothing.", 1, "Smog", 20, true, true,
            "Poison", "Flip a coin. If heads, the Defending Pokemon is now Poisoned.", 2);
        TwoAttackBasicPokemon Magmar2 = new TwoAttackBasicPokemon("Magmar", "Fire", "Water", "None", 0, 70, 1, "None",
            "Smokescreen", 10, false, false, "None", "If the Defending Pokemon tries to attack during your opponent's" +
            " next turn, your opponent flips a coin. If tails, that attack does nothing.", 1, "Smog", 20, true, true,
            "Poison", "Flip a coin. If heads, the Defending Pokemon is now Poisoned.", 2);
        TwoAttackBasicPokemon Magmar3 = new TwoAttackBasicPokemon("Magmar", "Fire", "Water", "None", 0, 70, 1, "None",
            "Smokescreen", 10, false, false, "None", "If the Defending Pokemon tries to attack during your opponent's" +
            " next turn, your opponent flips a coin. If tails, that attack does nothing.", 1, "Smog", 20, true, true,
            "Poison", "Flip a coin. If heads, the Defending Pokemon is now Poisoned.", 2);
        OneAttackBasicPokemon PonytaRocket1 = new OneAttackBasicPokemon("Ponyta(Rocket)", "Fire", "Water", "None", 0, 50, 1,
            "None", "Ember", 30, false, false, "None", "Discard one Fire Energy card attached to Ponyta in order to use" +
            " this attack.", 2);
        OneAttackBasicPokemon PonytaRocket2 = new OneAttackBasicPokemon("Ponyta(Rocket)", "Fire", "Water", "None", 0, 50, 1,
            "None", "Ember", 30, false, false, "None", "Discard one Fire Energy card attached to Ponyta in order to use" +
            " this attack.", 2);
        OneAttackBasicPokemon PonytaRocket3 = new OneAttackBasicPokemon("Ponyta(Rocket)", "Fire", "Water", "None", 0, 50, 1,
            "None", "Ember", 30, false, false, "None", "Discard one Fire Energy card attached to Ponyta in order to use" +
            " this attack.", 2);
        TwoAttackBasicPokemon BlainesKangaskhan1 = new TwoAttackBasicPokemon("Blaine's Kangaskhan", "Normal", "Fighting",
            "Psychic", 30, 80, 3, "None", "Child's Punch", 10, true, false, "None", "Flip a coin. If tails, this attack" +
            " does nothing.", 1, "One-Two Punch", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage.", 3);
        TwoAttackBasicPokemon BlainesKangaskhan2 = new TwoAttackBasicPokemon("Blaine's Kangaskhan", "Normal", "Fighting",
            "Psychic", 30, 80, 3, "None", "Child's Punch", 10, true, false, "None", "Flip a coin. If tails, this attack" +
            " does nothing.", 1, "One-Two Punch", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage.", 3);
        TwoAttackBasicPokemon BlainesKangaskhan3 = new TwoAttackBasicPokemon("Blaine's Kangaskhan", "Normal", "Fighting",
            "Psychic", 30, 80, 3, "None", "Child's Punch", 10, true, false, "None", "Flip a coin. If tails, this attack" +
            " does nothing.", 1, "One-Two Punch", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage.", 3);
        TwoAttackBasicPokemon BlainesKangaskhan4 = new TwoAttackBasicPokemon("Blaine's Kangaskhan", "Normal", "Fighting",
            "Psychic", 30, 80, 3, "None", "Child's Punch", 10, true, false, "None", "Flip a coin. If tails, this attack" +
            " does nothing.", 1, "One-Two Punch", 30, true, false, "None", "Flip a coin. If heads, this attack does 30" +
            " damage plus 10 more damage; if tails, this attack does 30 damage.", 3);
        Potion FirePotion1 = new Potion();
        Potion FirePotion2 = new Potion();
        Potion FirePotion3 = new Potion();
        Potion FirePotion4 = new Potion();
        PlusPower FirePlusPower1 = new PlusPower();
        PlusPower FirePlusPower2 = new PlusPower();
        PlusPower FirePlusPower3 = new PlusPower();
        PlusPower FirePlusPower4 = new PlusPower();
        Energy FireEnergy1 = new Energy("Fire");
        Energy FireEnergy2 = new Energy("Fire");
        Energy FireEnergy3 = new Energy("Fire");
        Energy FireEnergy4 = new Energy("Fire");
        Energy FireEnergy5 = new Energy("Fire");
        Energy FireEnergy6 = new Energy("Fire");
        Energy FireEnergy7 = new Energy("Fire");
        Energy FireEnergy8 = new Energy("Fire");
        Energy FireEnergy9 = new Energy("Fire");
        Energy FireEnergy10 = new Energy("Fire");
        Energy FireEnergy11 = new Energy("Fire");
        Energy FireEnergy12 = new Energy("Fire");
        Energy FireEnergy13 = new Energy("Fire");
        Energy FireEnergy14 = new Energy("Fire");
        Energy FireEnergy15 = new Energy("Fire");
        Energy FireEnergy16 = new Energy("Fire");
        Energy FireEnergy17 = new Energy("Fire");
        Energy FireEnergy18 = new Energy("Fire");
        Energy FireEnergy19 = new Energy("Fire");
        Energy FireEnergy20 = new Energy("Fire");

        public frmGameBoard(string _deckType)
        {
            InitializeComponent();

            deckType = _deckType;
        }

        private void DrawSevenDisplayWaterHand(PokemonCard[] PHand, PictureBox[] HandPics)
        {
            for (int index = 0; index < DRAW_SEVEN; index++)
            {
                if (PHand[index] == Squirtle1 || PHand[index] == Squirtle2 || PHand[index] == Squirtle3 || PHand[index] == 
                    Squirtle4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[0];
                }

                else if (PHand[index] == Wartortle1 || PHand[index] == Wartortle2 || PHand[index] == Wartortle3 || 
                    PHand[index] == Wartortle4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[1];
                }

                else if (PHand[index] == SquirtleRocket1 || PHand[index] == SquirtleRocket2 || PHand[index] == SquirtleRocket3 ||
                    PHand[index] == SquirtleRocket4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[2];
                }

                else if (PHand[index] == Magikarp1 || PHand[index] == Magikarp2 || PHand[index] == Magikarp3 || PHand[index] == 
                    Magikarp4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[3];
                }

                else if (PHand[index] == Gyarados1 || PHand[index] == Gyarados2 || PHand[index] == Gyarados3 || PHand[index] == 
                    Gyarados4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[4];
                }

                else if (PHand[index] == Seel1 || PHand[index] == Seel2 || PHand[index] == Seel3 || PHand[index] == Seel4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[5];
                }

                else if (PHand[index] == Dewgong1 || PHand[index] == Dewgong2 || PHand[index] == Dewgong3 || PHand[index] == 
                    Dewgong4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[6];
                }

                else if (PHand[index] == Meowth1 || PHand[index] == Meowth2 || PHand[index] == Meowth3 || PHand[index] == 
                    Meowth4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[7];
                }

                else if (PHand[index] == Persian1 || PHand[index] == Persian2 || PHand[index] == Persian3 || PHand[index] == 
                    Persian4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[8];
                }

                else if (PHand[index] == WaterPotion1 || PHand[index] == WaterPotion2 || PHand[index] == WaterPotion3 || 
                    PHand[index] == WaterPotion4)
                {
                    HandPics[index].Image = imlWaterDeck.Images[9];
                }

                else if (PHand[index] == WaterEnergy1 || PHand[index] == WaterEnergy2 || PHand[index] == WaterEnergy3 ||
                    PHand[index] == WaterEnergy4 || PHand[index] == WaterEnergy5 || PHand[index] == WaterEnergy6 ||
                    PHand[index] == WaterEnergy7 || PHand[index] == WaterEnergy8 || PHand[index] == WaterEnergy9 ||
                    PHand[index] == WaterEnergy10 || PHand[index] == WaterEnergy11 || PHand[index] == WaterEnergy12 ||
                    PHand[index] == WaterEnergy13 || PHand[index] == WaterEnergy14 || PHand[index] == WaterEnergy15 ||
                    PHand[index] == WaterEnergy16 || PHand[index] == WaterEnergy17 || PHand[index] == WaterEnergy18 ||
                    PHand[index] == WaterEnergy19 || PHand[index] == WaterEnergy20)
                {
                    HandPics[index].Image = imlWaterDeck.Images[10];
                }
            }
        }

        static Random rand = new Random();

        static public void Shuffle(object[] deckArray)
        {
            for (int index = deckArray.Length - 1; index > 0; --index)
            {
                int swapVar = rand.Next(index + 1);
                object temp = deckArray[index];
                deckArray[index] = deckArray[swapVar];
                deckArray[swapVar] = temp;
            }
        }

        private void frmGameBoard_Load(object sender, EventArgs e)
        {
            SquirtleAndFriendsDeck[0] = Squirtle1;
            SquirtleAndFriendsDeck[1] = Squirtle2;
            SquirtleAndFriendsDeck[2] = Squirtle3;
            SquirtleAndFriendsDeck[3] = Squirtle4;
            SquirtleAndFriendsDeck[4] = Wartortle1;
            SquirtleAndFriendsDeck[5] = Wartortle2;
            SquirtleAndFriendsDeck[6] = Wartortle3;
            SquirtleAndFriendsDeck[7] = Wartortle4;
            SquirtleAndFriendsDeck[8] = SquirtleRocket1;
            SquirtleAndFriendsDeck[9] = SquirtleRocket2;
            SquirtleAndFriendsDeck[10] = SquirtleRocket3;
            SquirtleAndFriendsDeck[11] = SquirtleRocket4;
            SquirtleAndFriendsDeck[12] = Magikarp1;
            SquirtleAndFriendsDeck[13] = Magikarp2;
            SquirtleAndFriendsDeck[14] = Magikarp3;
            SquirtleAndFriendsDeck[15] = Magikarp4;
            SquirtleAndFriendsDeck[16] = Gyarados1;
            SquirtleAndFriendsDeck[17] = Gyarados2;
            SquirtleAndFriendsDeck[18] = Gyarados3;
            SquirtleAndFriendsDeck[19] = Gyarados4;
            SquirtleAndFriendsDeck[20] = Seel1;
            SquirtleAndFriendsDeck[21] = Seel2;
            SquirtleAndFriendsDeck[22] = Seel3;
            SquirtleAndFriendsDeck[23] = Seel4;
            SquirtleAndFriendsDeck[24] = Dewgong1;
            SquirtleAndFriendsDeck[25] = Dewgong2;
            SquirtleAndFriendsDeck[26] = Dewgong3;
            SquirtleAndFriendsDeck[27] = Dewgong4;
            SquirtleAndFriendsDeck[28] = Meowth1;
            SquirtleAndFriendsDeck[29] = Meowth2;
            SquirtleAndFriendsDeck[30] = Meowth3;
            SquirtleAndFriendsDeck[31] = Meowth4;
            SquirtleAndFriendsDeck[32] = Persian1;
            SquirtleAndFriendsDeck[33] = Persian2;
            SquirtleAndFriendsDeck[34] = Persian3;
            SquirtleAndFriendsDeck[35] = Persian4;
            SquirtleAndFriendsDeck[36] = WaterPotion1;
            SquirtleAndFriendsDeck[37] = WaterPotion2;
            SquirtleAndFriendsDeck[38] = WaterPotion3;
            SquirtleAndFriendsDeck[39] = WaterPotion4;
            SquirtleAndFriendsDeck[40] = WaterEnergy1;
            SquirtleAndFriendsDeck[41] = WaterEnergy2;
            SquirtleAndFriendsDeck[42] = WaterEnergy3;
            SquirtleAndFriendsDeck[43] = WaterEnergy4;
            SquirtleAndFriendsDeck[44] = WaterEnergy5;
            SquirtleAndFriendsDeck[45] = WaterEnergy6;
            SquirtleAndFriendsDeck[46] = WaterEnergy7;
            SquirtleAndFriendsDeck[47] = WaterEnergy8;
            SquirtleAndFriendsDeck[48] = WaterEnergy9;
            SquirtleAndFriendsDeck[49] = WaterEnergy10;
            SquirtleAndFriendsDeck[50] = WaterEnergy11;
            SquirtleAndFriendsDeck[51] = WaterEnergy12;
            SquirtleAndFriendsDeck[52] = WaterEnergy13;
            SquirtleAndFriendsDeck[53] = WaterEnergy14;
            SquirtleAndFriendsDeck[54] = WaterEnergy15;
            SquirtleAndFriendsDeck[55] = WaterEnergy16;
            SquirtleAndFriendsDeck[56] = WaterEnergy17;
            SquirtleAndFriendsDeck[57] = WaterEnergy18;
            SquirtleAndFriendsDeck[58] = WaterEnergy19;
            SquirtleAndFriendsDeck[59] = WaterEnergy20;
            
            BulbasaurAndFriendsDeck[0] = Bulbasaur1;
            BulbasaurAndFriendsDeck[1] = Bulbasaur2;
            BulbasaurAndFriendsDeck[2] = Bulbasaur3;
            BulbasaurAndFriendsDeck[3] = Bulbasaur4;
            BulbasaurAndFriendsDeck[4] = Ivysaur1;
            BulbasaurAndFriendsDeck[5] = Ivysaur2;
            BulbasaurAndFriendsDeck[6] = Ivysaur3;
            BulbasaurAndFriendsDeck[7] = Ivysaur4;
            BulbasaurAndFriendsDeck[8] = ErikasBulbasaur1;
            BulbasaurAndFriendsDeck[9] = ErikasBulbasaur2;
            BulbasaurAndFriendsDeck[10] = ErikasBulbasaur3;
            BulbasaurAndFriendsDeck[11] = ErikasBulbasaur4;
            BulbasaurAndFriendsDeck[12] = Nidoran1;
            BulbasaurAndFriendsDeck[13] = Nidoran2;
            BulbasaurAndFriendsDeck[14] = Nidoran3;
            BulbasaurAndFriendsDeck[15] = Nidoran4;
            BulbasaurAndFriendsDeck[16] = Nidorino1;
            BulbasaurAndFriendsDeck[17] = Nidorino2;
            BulbasaurAndFriendsDeck[18] = Nidorino3;
            BulbasaurAndFriendsDeck[19] = Nidorino4;
            BulbasaurAndFriendsDeck[20] = Nidoking1;
            BulbasaurAndFriendsDeck[21] = Nidoking2;
            BulbasaurAndFriendsDeck[22] = Nidoking3;
            BulbasaurAndFriendsDeck[23] = Nidoking4;
            BulbasaurAndFriendsDeck[24] = RocketsScyther1;
            BulbasaurAndFriendsDeck[25] = RocketsScyther2;
            BulbasaurAndFriendsDeck[26] = RocketsScyther3;
            BulbasaurAndFriendsDeck[27] = RocketsScyther4;
            BulbasaurAndFriendsDeck[28] = Caterpie1;
            BulbasaurAndFriendsDeck[29] = Caterpie2;
            BulbasaurAndFriendsDeck[30] = Caterpie3;
            BulbasaurAndFriendsDeck[31] = Caterpie4;
            BulbasaurAndFriendsDeck[32] = GrassPlusPower1;
            BulbasaurAndFriendsDeck[33] = GrassPlusPower2;
            BulbasaurAndFriendsDeck[34] = GrassPlusPower3;
            BulbasaurAndFriendsDeck[35] = GrassPlusPower4;
            BulbasaurAndFriendsDeck[36] = GrassPotion1;
            BulbasaurAndFriendsDeck[37] = GrassPotion2;
            BulbasaurAndFriendsDeck[38] = GrassPotion3;
            BulbasaurAndFriendsDeck[39] = GrassPotion4;
            BulbasaurAndFriendsDeck[40] = GrassEnergy1;
            BulbasaurAndFriendsDeck[41] = GrassEnergy2;
            BulbasaurAndFriendsDeck[42] = GrassEnergy3;
            BulbasaurAndFriendsDeck[43] = GrassEnergy4;
            BulbasaurAndFriendsDeck[44] = GrassEnergy5;
            BulbasaurAndFriendsDeck[45] = GrassEnergy6;
            BulbasaurAndFriendsDeck[46] = GrassEnergy7;
            BulbasaurAndFriendsDeck[47] = GrassEnergy8;
            BulbasaurAndFriendsDeck[48] = GrassEnergy9;
            BulbasaurAndFriendsDeck[49] = GrassEnergy10;
            BulbasaurAndFriendsDeck[50] = GrassEnergy11;
            BulbasaurAndFriendsDeck[51] = GrassEnergy12;
            BulbasaurAndFriendsDeck[52] = GrassEnergy13;
            BulbasaurAndFriendsDeck[53] = GrassEnergy14;
            BulbasaurAndFriendsDeck[54] = GrassEnergy15;
            BulbasaurAndFriendsDeck[55] = GrassEnergy16;
            BulbasaurAndFriendsDeck[56] = GrassEnergy17;
            BulbasaurAndFriendsDeck[57] = GrassEnergy18;
            BulbasaurAndFriendsDeck[58] = GrassEnergy19;
            BulbasaurAndFriendsDeck[59] = GrassEnergy20;

            CharmanderAndFriendsDeck[0] = Charmander1;
            CharmanderAndFriendsDeck[1] = Charmander2;
            CharmanderAndFriendsDeck[2] = Charmander3;
            CharmanderAndFriendsDeck[3] = Charmander4;
            CharmanderAndFriendsDeck[4] = Charmeleon1;
            CharmanderAndFriendsDeck[5] = Charmander2;
            CharmanderAndFriendsDeck[6] = Charmeleon3;
            CharmanderAndFriendsDeck[7] = Charmeleon4;
            CharmanderAndFriendsDeck[8] = BlainesCharmander1;
            CharmanderAndFriendsDeck[9] = BlainesCharmander2;
            CharmanderAndFriendsDeck[10] = BlainesCharmander3;
            CharmanderAndFriendsDeck[11] = BlainesCharmander4;
            CharmanderAndFriendsDeck[12] = BlainesGrowlithe1;
            CharmanderAndFriendsDeck[13] = BlainesGrowlithe2;
            CharmanderAndFriendsDeck[14] = BlainesGrowlithe3;
            CharmanderAndFriendsDeck[15] = BlainesGrowlithe4;
            CharmanderAndFriendsDeck[16] = Vulpix1;
            CharmanderAndFriendsDeck[17] = Vulpix2;
            CharmanderAndFriendsDeck[18] = Vulpix3;
            CharmanderAndFriendsDeck[19] = BrocksVulpix1;
            CharmanderAndFriendsDeck[20] = BrocksVulpix2;
            CharmanderAndFriendsDeck[21] = BrocksVulpix3;
            CharmanderAndFriendsDeck[22] = Magmar1;
            CharmanderAndFriendsDeck[23] = Magmar2;
            CharmanderAndFriendsDeck[24] = Magmar3;
            CharmanderAndFriendsDeck[25] = PonytaRocket1;
            CharmanderAndFriendsDeck[26] = PonytaRocket2;
            CharmanderAndFriendsDeck[27] = PonytaRocket3;
            CharmanderAndFriendsDeck[28] = BlainesKangaskhan1;
            CharmanderAndFriendsDeck[29] = BlainesKangaskhan2;
            CharmanderAndFriendsDeck[30] = BlainesKangaskhan3;
            CharmanderAndFriendsDeck[31] = BlainesKangaskhan4;
            CharmanderAndFriendsDeck[32] = FirePlusPower1;
            CharmanderAndFriendsDeck[33] = FirePlusPower2;
            CharmanderAndFriendsDeck[34] = FirePlusPower3;
            CharmanderAndFriendsDeck[35] = FirePlusPower4;
            CharmanderAndFriendsDeck[36] = FirePotion1;
            CharmanderAndFriendsDeck[37] = FirePotion2;
            CharmanderAndFriendsDeck[38] = FirePotion3;
            CharmanderAndFriendsDeck[39] = FirePotion4;
            CharmanderAndFriendsDeck[40] = FireEnergy1;
            CharmanderAndFriendsDeck[41] = FireEnergy2;
            CharmanderAndFriendsDeck[42] = FireEnergy3;
            CharmanderAndFriendsDeck[43] = FireEnergy4;
            CharmanderAndFriendsDeck[44] = FireEnergy5;
            CharmanderAndFriendsDeck[45] = FireEnergy6;
            CharmanderAndFriendsDeck[46] = FireEnergy7;
            CharmanderAndFriendsDeck[47] = FireEnergy8;
            CharmanderAndFriendsDeck[48] = FireEnergy9;
            CharmanderAndFriendsDeck[49] = FireEnergy10;
            CharmanderAndFriendsDeck[50] = FireEnergy11;
            CharmanderAndFriendsDeck[51] = FireEnergy12;
            CharmanderAndFriendsDeck[52] = FireEnergy13;
            CharmanderAndFriendsDeck[53] = FireEnergy14;
            CharmanderAndFriendsDeck[54] = FireEnergy15;
            CharmanderAndFriendsDeck[55] = FireEnergy16;
            CharmanderAndFriendsDeck[56] = FireEnergy17;
            CharmanderAndFriendsDeck[57] = FireEnergy18;
            CharmanderAndFriendsDeck[58] = FireEnergy19;
            CharmanderAndFriendsDeck[59] = FireEnergy20;

            
            /*
            if (deckType == "Water")
            {
                for (int index = 0; index < DECK_SIZE; index++)
                {
                    SquirtleAndFriendsDeck[index] = PlayerDeck[index];
                }
            }
            else if (deckType == "Grass")
            {
                for (int index = 0; index < DECK_SIZE; index++)
                {
                    BulbasaurAndFriendsDeck[index] = PlayerDeck[index];
                }
            }
            else if (deckType == "Fire")
            {
                for (int index = 0; index < DECK_SIZE; index++)
                {
                    CharmanderAndFriendsDeck[index] = PlayerDeck[index];
                }
            }
            */

            Shuffle(PlayerDeck);

            frmPlayersHand frmUserHand = new frmPlayersHand();
            //frmUserHand.lblPokemonCard1Selected.Text =  

            /*
            //MessageBox.Show("Welcome to your first match! Both player's decks have been shuffled. You have" +
            //    " each been given 7 cards to start with in your hand. We will begin the game by choosing any" +
            //    " basic Pokemon that are present in each players hand to be in play or on the bench. Both" +
            //    " players must choose at least 1 basic Pokemon to put in play.");

            for (int index = 0; index < DRAW_SEVEN; index++)
            {
                PlayersHand[index] = PlayerDeck[index];
            }

            

            /*PictureBox[] HandPictures = new PictureBox[HAND_SIZE];

            HandPictures[0] = frmUserHand.pbxPokemonCard1;
            HandPictures[1] = frmUserHand.pbxPokemonCard2;
            HandPictures[2] = frmUserHand.pbxPokemonCard3;
            HandPictures[3] = frmUserHand.pbxPokemonCard4;
            HandPictures[4] = frmUserHand.pbxPokemonCard5;
            HandPictures[5] = frmUserHand.pbxPokemonCard6;
            HandPictures[6] = frmUserHand.pbxPokemonCard7;
            HandPictures[7] = frmUserHand.pbxPokemonCard8;
            HandPictures[8] = frmUserHand.pbxPokemonCard9;
            HandPictures[9] = frmUserHand.pbxPokemonCard10;
            HandPictures[10] = frmUserHand.pbxPokemonCard11;
            HandPictures[11] = frmUserHand.pbxPokemonCard12;
            HandPictures[12] = frmUserHand.pbxPokemonCard13;
            HandPictures[13] = frmUserHand.pbxPokemonCard14;
            HandPictures[14] = frmUserHand.pbxPokemonCard15;
            HandPictures[15] = frmUserHand.pbxPokemonCard16;
            HandPictures[16] = frmUserHand.pbxPokemonCard17;
            HandPictures[17] = frmUserHand.pbxPokemonCard18;
            HandPictures[18] = frmUserHand.pbxPokemonCard19;
            */
            //DrawSevenDisplayWaterHand(PlayersHand, HandPictures);

            //frmUserHand.pbxPokemonCard1.Image = imlWaterDeck.Images[2];
     
            //frmUserHand.ShowDialog();

        }
        
        private void btnAttack_Click(object sender, EventArgs e)
        {
        
        }
            
        private void cbxAttacks_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }   

        private void btnHand_Click(object sender, EventArgs e)
        {

        }

        private void btnStartTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnFinishTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnRetreat_Click(object sender, EventArgs e)
        {

        }     
    }
}
