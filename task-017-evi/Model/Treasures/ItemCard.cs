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
    [JsonSubtypes.KnownSubType(typeof(ItemCard), "ItemCard")]
    class ItemCard :Treasure
    {
        public int Modifier { get; set; }
        public string Sign { get; set; }
        public string Restriction { get; set; }
        public string PartOfBody { get; set; }
        public string Cost  { get; set; }
        public bool IsBigItem  { get; set; }
        public new string CardType { get; set; } = "ItemCard";
    }
}
