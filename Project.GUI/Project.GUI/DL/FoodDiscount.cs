using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DL
{
    internal class FoodDiscount : DiscountDL
    {
        public override double calculateTax(double foodBill)
        {
            double discount = 0;
            discount = 0.20 * (foodBill);
            return discount;
        }
    }
}
