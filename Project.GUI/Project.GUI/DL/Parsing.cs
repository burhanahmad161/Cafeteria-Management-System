using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DL
{
    internal class Parsing
    {
        public static string parsItems(string itemName, int itemRate) //////////////////// parsing function
        {
            int commaCount = 1;
            string item = "";
            for (int x = 0; x < itemName.Length; x++)
            {
                if (itemName[x] == ',')
                {
                    commaCount = commaCount + 1;
                }
                else if (commaCount == itemRate)
                {
                    item = item + itemName[x];
                }
            }
            return item;
        }
    }
}
