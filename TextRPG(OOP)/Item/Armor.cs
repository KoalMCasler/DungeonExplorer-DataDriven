using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_OOP_.TextRPG_OOP_;

namespace TextRPG_OOP_
{
    internal class Armor : Item
    {
        public Armor(Settings settings)
        {
            gainAmount = settings.armorGain;
            avatar = settings.armorChar;
            color = settings.armorColor;
            itemType = "Armor";
            cost = settings.armorCost;
        }


        public override void Apply(Player player, UIManager uiManager, QuestManager questManager)
        {
            player.healthSystem.IncreaseArmor(gainAmount);
            uiManager.AddEventLogMessage($"{player.name} gained {gainAmount} armor");
            if (!player.boughtItem)
                isCollected = true;
        }
    }
}
