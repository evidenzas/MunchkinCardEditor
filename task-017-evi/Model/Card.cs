using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_017_evi.Cards
{
    public class Card
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public Color FontCardColor { get; set; }
        public Color BackCardColor { get; set; }
        public string CardType { get; set; }
    }
}
