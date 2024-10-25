﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_OOP_.TextRPG_OOP_;

namespace TextRPG_OOP_
{
    internal class Sword: Item
    {
        public Sword(Settings settings)
        {
            gainAmount = settings.swordGain;
            avatar = settings.swordChar;
            color = settings.swordColor;
            itemType = "Sword";
            cost = settings.swordCost;
        }

        public override void Apply(Player player, UIManager uiManager, QuestManager questManager)
        {
            player.damage += gainAmount;
            uiManager.AddEventLogMessage($"{player.name} gained {gainAmount} damage");
            if(!player.boughtItem)
                isCollected = true;

        }
    }
}