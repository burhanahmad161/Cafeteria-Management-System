using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;

namespace Project.DL
{
    internal class DiscountDL
    {
        public static List<double> food = new List<double>();
        public static List<double> drinks = new List<double>();
        public virtual double calculateTax(double rate)
        {
            return 0;
        }
        public static void DataTransfer()
        {
            for (int idx = 0; idx < OrderedProductDL.order.Count; idx++)
            {
                string food = OrderedProductDL.order[idx].Category1;
                if (food == "Food")
                {
                    double abc = OrderedProductDL.order[idx].Rate1 * OrderedProductDL.order[idx].Quantity1;
                    DiscountDL.food.Add(abc);
                }
                else if (food == "Drink")
                {
                    double abc = OrderedProductDL.order[idx].Rate1 * OrderedProductDL.order[idx].Quantity1;
                    DiscountDL.drinks.Add(abc);
                }
            }
        }
    } 
}
