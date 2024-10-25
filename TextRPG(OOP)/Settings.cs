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
        public char storeChar { get; set; }
        public char storeFloor { get; set; }
        public char dungeonWall { get; set; }
        public char dungeonFloor { get; set; }
        public char stairs { get; set; }
        public char newStairsChar { get; set; }
        public char startingPosition { get; set; }

        // Settings for quests
        public string questEnemyType { get; set; }
        public string questEnemyType2 { get; set; }
        public int questTargetCoin { get; set; }
        public int questTargetEnemy1 { get; set; }
        public int questTargetEnemy2 { get; set; }
        public int questTargetMulti { get; set; }

        //Base values for enemy stats. 
        public int PlasmoidBaseHP { get; set; }
        public int PlasmoidBaseDamage { get; set; }
        public char PlasmoidChar { get; set; }
        public int ConstructBaseHP { get; set; }
        public int ConstructBaseDamage { get; set; }
        public char ConstructChar { get; set; }
        public int GoblinFolkBaseHP { get; set; }
        public int GoblinFolkBaseDamage { get; set; }
        public char GoblinFolkChar { get; set; }

        // base value for player stats
        public int playerMaxHP { get; set; }
        public int playerStartingCoins { get; set; }
        public int PlayerBaseDamage { get; set; }
        public string playerName { get; set; }

        // base values for items
        public int healthGain { get; set; }
        public int coinGain { get; set; }
        public int armorGain { get; set; }
        public int spikeDamage { get; set; }
        public int swordGain { get; set; }

        // Color For Items
        public ConsoleColor healthColor { get; set; }
        public ConsoleColor coinColor { get; set; }
        public ConsoleColor armorColor { get; set; }
        public ConsoleColor finalLootColor { get; set; }
        public ConsoleColor swordColor { get; set; }
        public ConsoleColor spikeColor { get; set; }

        // Characters for Items
        public char healthChar { get; set; }
        public char coinChar { get; set; }
        public char armorChar { get; set; }
        public char finalLootChar { get; set; }
        public char spikeChar { get; set; }
        public char swordChar { get; set; }

        // Item Cost
        public int healthCost { get; set; }
        public int armorCost { get; set; }
        public int swordCost { get; set; }
        //public static int healthCost = 1;
        //public static int armorCost = 1;
        //public static int swordCost = 1;
        public Settings() //Sets defult values for everything. 
        {
        storeChar = 'S';
        storeFloor = '%';
        dungeonWall = '#';
        dungeonFloor = '-';
        stairs = '~';
        newStairsChar = (char)30;
        startingPosition = '=';

        // Settings for quests
        questEnemyType = "Plasmoid";
        questEnemyType2 = "Construct";
        questTargetCoin = 20;
        questTargetEnemy1 = 20;
        questTargetEnemy2 = 10;
        questTargetMulti = 30;

        //Base values for enemy stats. 
        PlasmoidBaseHP = 3;
        PlasmoidBaseDamage = 1;
        PlasmoidChar = (char)4;
        ConstructBaseHP = 3;
        ConstructBaseDamage = 2;
        ConstructChar = (char)5;
        GoblinFolkBaseHP = 3;
        GoblinFolkBaseDamage = 4;
        GoblinFolkChar = (char)6;

        // base value for player stats
        playerMaxHP = 15;
        playerStartingCoins = 0;
        PlayerBaseDamage = 1;
        playerName = "Guard";

        // base values for items
        healthGain = 3;
        coinGain = 1;
        armorGain = 1;
        spikeDamage = 3;
        swordGain = 2;

        // Color For Items
        healthColor = ConsoleColor.Red;
        coinColor = ConsoleColor.DarkYellow;
        armorColor = ConsoleColor.DarkBlue;
        finalLootColor = ConsoleColor.Yellow;
        swordColor = ConsoleColor.DarkGreen;
        spikeColor = ConsoleColor.Red;

        // Characters for Items
        healthChar = (char)3;
        coinChar = (char)164;
        armorChar = (char)21;
        finalLootChar = (char)165;
        spikeChar = (char)23;
        swordChar = '+';

        // Item Cost
        healthCost = 7;
        armorCost = 8;
        swordCost = 10;
        }
    }
}
