using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_017_evi.Cards;
using task_017_evi.Model;

namespace task_017_evi
{
    class JsonWorker
    {
        public static Card CardDeserialize(string filelines)
        {
            try
            {
                var card = JsonConvert.DeserializeObject<Card>(filelines);
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
