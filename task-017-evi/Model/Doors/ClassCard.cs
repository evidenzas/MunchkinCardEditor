using JsonSubTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_017_evi.Cards;

namespace task_017_evi.Model.Doors
{
    [JsonConverter(typeof(JsonSubtypes), "CardType")]
    [JsonSubtypes.KnownSubType(typeof(ClassCard), "ClassCard")]
    class ClassCard : Door
    {
        public new string CardType { get; set; } = "ClassCard";
    }
}
