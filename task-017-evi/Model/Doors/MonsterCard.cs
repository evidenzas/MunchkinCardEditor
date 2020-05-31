using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_017_evi.Model.Doors
{
    class MonsterCard : Door
    {
        public int Level { get; set; }
        public string Race { get; set; }
        public string BadStuff { get; set; }
        public int TreasureReward { get; set; }
        public int LevelReward { get; set; }
    }
}
