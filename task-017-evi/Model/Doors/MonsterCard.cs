using JsonSubTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_017_evi.Model.Doors
{
    [JsonConverter(typeof(JsonSubtypes), "CardType")]
    [JsonSubtypes.KnownSubType(typeof(MonsterCard), "MonsterCard")]
    class MonsterCard : Door
    {
        public int Level { get; set; }
        public string Race { get; set; }
        public string BadStuff { get; set; }
        public int TreasureReward { get; set; }
        public int LevelReward { get; set; }
        public new string CardType { get; set; } = "MonsterCard";
    }
}
