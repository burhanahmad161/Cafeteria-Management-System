using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;

namespace Project.DL
{
    internal class BeverageDiscount : DiscountDL
    {
        public override double calculateTax(double beverageBill)
        {
            double discount;
            discount = 0.10 * (beverageBill);
            return discount;
        }
    }
}
