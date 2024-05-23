using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DL;

namespace Project.BL
{
    internal class OrderedProduct
    {
        private string Name;
        private int Rate;
        private int Quantity;
        private string Category;

        public string Name1 { get => Name; set => Name = value; }
        public int Rate1 { get => Rate; set => Rate = value; }
        public int Quantity1 { get => Quantity; set => Quantity = value; }
        public string Category1 { get => Category; set => Category = value; }

        public OrderedProduct(string name, int rate, int quantity,string category1)
        {
            Name = name;
            Rate = rate;
            Quantity = quantity;
            Category1 = category1;
        }
    }
}
