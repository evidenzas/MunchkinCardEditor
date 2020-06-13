using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munchkin_card_editor.Model.Treasures
{
    class OneShotTreasureCard : Treasure
    {
        public string Cost { get; set; }

        public OneShotTreasureCard() 
        {
            CardType = "OneShotTreasureCard";
        }

    }
}
