using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project.BL
{
    internal class ProductBL
    {
        private string itemName;
        private int itemRate;
        private string category;

        public string ItemName { get => itemName; set => itemName = value; }
        public int ItemRate { get => itemRate; set => itemRate = value; }
        public string Category { get => category; set => category = value; }

        public ProductBL()
            {

            }
        public ProductBL(string itemName, int itemRate,string category)
        {
            this.itemName = itemName;
            this.itemRate = itemRate;
            this.category = category;
        }

    }
    
}
