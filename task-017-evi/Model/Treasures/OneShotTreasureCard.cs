using JsonSubTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_017_evi.Model.Treasures
{
    [JsonConverter(typeof(JsonSubtypes), "CardType")]
    [JsonSubtypes.KnownSubType(typeof(OneShotTreasureCard), "OneShotTreasureCard")]
    class OneShotTreasureCard : Treasure
    {
        public string Cost { get; set; }
        public new string CardType { get; set; } = "OneShotTreasureCard";
    }
}
