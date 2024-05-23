using Project.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DL
{
    internal class MenuDL
    {
        public static double FinalBill = 0;
        public static void MenuLoop()
        {
            for (int idx = 0; idx < ProductDL.p1.Count(); idx++)
            {
                int n = 1 + idx;
                Console.SetCursorPosition(60, 33 + n);
                Console.WriteLine(n + "-" + ProductDL.p1[idx].ItemName);
                Console.SetCursorPosition(80, 33 + n);
                Console.WriteLine(ProductDL.p1[idx].ItemRate);
            }
        }
        public static void MenuLoop2()
        {
            for (int idx = 0; idx < ProductDL.p1.Count(); idx++)
            {
                int n = 1 + idx;
                Console.SetCursorPosition(60, 33 + n);
                Console.WriteLine(n + "-" + ProductDL.p1[idx].ItemName);
                Console.SetCursorPosition(80, 33 + n);
                Console.WriteLine(ProductDL.p1[idx].ItemRate);
                Console.SetCursorPosition(60, 47);
                Console.WriteLine("Enter 0 to end buying");
            }
        }
    }
}
