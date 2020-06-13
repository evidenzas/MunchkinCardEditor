using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munchkin_card_editor.Model.Treasures
{
    class ItemCard :Treasure
    {
        public int Modifier { get; set; }
        public string Sign { get; set; }
        public string Restriction { get; set; }
        public string PartOfBody { get; set; }
        public string Cost  { get; set; }
        public bool IsBigItem  { get; set; }
        public ItemCard()
        {
            CardType = "ItemCard";
        }
    }
}
