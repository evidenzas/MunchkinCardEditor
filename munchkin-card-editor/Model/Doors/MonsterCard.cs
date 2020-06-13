using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munchkin_card_editor.Model.Doors
{
    class MonsterCard : Door
    {
        public int Level { get; set; }
        public string Race { get; set; }
        public string BadStuff { get; set; }
        public int TreasureReward { get; set; }
        public int LevelReward { get; set; }
        public MonsterCard()
        {
            CardType  = "MonsterCard";
        }
    }
}
