using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_017_evi.Model.Doors
{
    class MonsterCard : Door
    {
        private int Level { get; set; }
        private string Race { get; set; }
        private string BadStuff { get; set; }
        private int TreasureReward { get; set; }
        private int LevelReward { get; set; }
    }
}
