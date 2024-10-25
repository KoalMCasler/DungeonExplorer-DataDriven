using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_OOP_
{
    /// <summary>
    /// Holds the base values for all Characater
    /// </summary>
    internal class Settings
    {
        // Settings for map char
        public char storeChar = 'S';
        public char storeFloor = '%';
        public char dungeonWall = '#';
        public char dungeonFloor = '-';
        public char stairs = '~';
        public char newStairsChar = (char)30;
        public char startingPosition = '=';

        // Settings for quests
        public string questEnemyType = "Plasmoid";
        public string questEnemyType2 = "Construct";
        public int questTargetCoin = 20;
        public int questTargetEnemy1 = 20;
        public int questTargetEnemy2 = 10;
        public int questTargetMulti = 30;

        //Base values for enemy stats. 
        public int PlasmoidBaseHP = 3;
        public int PlasmoidBaseDamage = 1;
        public char PlasmoidChar = (char)4;
        public int ConstructBaseHP = 3;
        public int ConstructBaseDamage = 2;
        public char ConstructChar = (char)5;
        public int GoblinFolkBaseHP = 3;
        public int GoblinFolkBaseDamage = 4;
        public char GoblinFolkChar = (char)6;

        // base value for player stats
        public int playerMaxHP = 15;
        public int playerStartingCoins = 0;
        public int PlayerBaseDamage = 1;
        public string playerName = "Guard";

        // base values for items
        public int healthGain = 3;
        public int coinGain = 1;
        public int armorGain = 1;
        public int spikeDamage = 3;
        public int swordGain = 2;

        // Color For Items
        public ConsoleColor healthColor = ConsoleColor.Red;
        public ConsoleColor coinColor = ConsoleColor.DarkYellow;
        public ConsoleColor armorColor = ConsoleColor.DarkBlue;
        public ConsoleColor finalLootColor = ConsoleColor.Yellow;
        public ConsoleColor swordColor = ConsoleColor.DarkGreen;
        public ConsoleColor spikeColor = ConsoleColor.Red;

        // Characters for Items
        public char healthChar = (char)3;
        public char coinChar = (char)164;
        public char armorChar = (char)21;
        public char finalLootChar = (char)165;
        public char spikeChar = (char)23;
        public char swordChar = '+';

        // Item Cost
        public int healthCost = 7;
        public int armorCost = 8;
        public int swordCost = 10;
        //public static int healthCost = 1;
        //public static int armorCost = 1;
        //public static int swordCost = 1;
        public Settings()
        {
            
        }
    }
}
