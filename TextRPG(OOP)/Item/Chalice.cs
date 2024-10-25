using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG_OOP_.TextRPG_OOP_;

namespace TextRPG_OOP_
{
    internal class Chalice : Item
    {
        public Chalice(Settings settings)
        {
            avatar = settings.finalLootChar;
            color = settings.finalLootColor;
        }

        public override void Apply(Player player, UIManager uiManager, QuestManager questManager)
        {
            isCollected = true;
        }
    }
}
