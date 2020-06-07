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
    [JsonSubtypes.KnownSubType(typeof(ModifierCard), "ModifierCard")]
    class ModifierCard : Door
    {
        public int Modifier { get; set; }
        public string Sign { get; set; }
        public new string CardType { get; set; } = "ModifierCard";
    }
}
