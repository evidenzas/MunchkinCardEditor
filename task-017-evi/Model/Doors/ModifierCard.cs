﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace munchkin_card_editor.Model.Doors
{
    class ModifierCard : Door
    {
        public int Modifier { get; set; }
        public string Sign { get; set; }
        public ModifierCard()
        {
            CardType = "ModifierCard";
        }
    }
}
