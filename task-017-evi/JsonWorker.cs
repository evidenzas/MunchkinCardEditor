using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_017_evi.Cards;
using task_017_evi.Model;
using task_017_evi.Model.Doors;
using task_017_evi.Model.Others;
using task_017_evi.Model.Treasures;

namespace task_017_evi
{
    class JsonWorker
    {
        public static Card CardDeserialize(string filelines)
        {
            try
            {
                var card = JsonConvert.DeserializeObject<Card>(filelines);
                switch (card.CardType)
                {
                    case "ClassCard":
                        return JsonConvert.DeserializeObject<ClassCard>(filelines);
                    case "CurseCard":
                        return JsonConvert.DeserializeObject<CurseCard>(filelines);
                    case "ModifierCard":
                        return JsonConvert.DeserializeObject<ModifierCard>(filelines);
                    case "MonsterCard":
                        return JsonConvert.DeserializeObject<MonsterCard>(filelines);
                    case "RaceCard":
                        return JsonConvert.DeserializeObject<RaceCard>(filelines);

                    case "GoUpALevelCard":
                        return JsonConvert.DeserializeObject<GoUpALevelCard>(filelines);
                    case "ItemCard":
                        return JsonConvert.DeserializeObject<ItemCard>(filelines);
                    case "OneShotTreasureCard":
                        return JsonConvert.DeserializeObject<OneShotTreasureCard>(filelines);

                    case "OtherCard":
                        return JsonConvert.DeserializeObject<OtherCard>(filelines);
                }
                return card;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Could not convert json file to object");
                return null;
            }
        }

        public static string CardSerialize(Card card)
        {
            try
            {
                string output = JsonConvert.SerializeObject(card);
                return output;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Could not convert object to json file");
                return null;
            }
        }
    }
}
