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
    [JsonSubtypes.KnownSubType(typeof(CurseCard), "CurseCard")]
    class CurseCard : Door
    {
        public new string CardType { get; set; } = "CurseCard";
    }
}
