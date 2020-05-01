using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_017_evi.Model.Treasures
{
    class ItemCard :Treasure
    {
        private int Modifier { get; set; }
        private string RaceRestriction { get; set; }
        private string PartOfBody { get; set; }
        private int Cost  { get; set; }
        private bool IsBigItem  { get; set; }
    }
}
