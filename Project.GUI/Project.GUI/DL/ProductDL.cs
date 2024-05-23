using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Project.BL;

namespace Project.DL
{
    internal class ProductDL
    {
        public static List<ProductBL> p1 = new List<ProductBL>();
        public static void addIntoList(ProductBL obj)
        {
            p1.Add(obj);
        }
        public static void storeItems(string name, float price, string category) ///////////////// for storing items
        {
            string path = "data.txt";
            StreamWriter gross = new StreamWriter(path, true);
            gross.WriteLine(name + "," + price + "," + category);
            gross.Flush();
            gross.Close();
        }
        public static void loadItems() ////////////////// for loading items
        {
            string path = "data.txt";
            if (File.Exists(path))
            {
                StreamReader fp = new StreamReader(path);
                string word;
                while ((word = fp.ReadLine()) != null)
                {
                    string[] splittedRecords = word.Split(',');
                    ProductBL data = new ProductBL();
                    data.ItemName = splittedRecords[0];
                    data.ItemRate = int.Parse(splittedRecords[1]);
                    data.Category = splittedRecords[2];
                    p1.Add(data);
                }
                fp.Close();
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
        }
        public static void addIntoFile(ProductBL obj)
        {
            storeItems(obj.ItemName, obj.ItemRate,obj.Category);
        }
        public static void UpdateItems_fromFile() ////////////////////// for deleting an item from file
        {
            string path = "data.txt";
            StreamWriter gross = new StreamWriter(path, false);
            for (int idx = 0; idx < p1.Count(); idx++)
            {
                gross.WriteLine(p1[idx].ItemName + "," + p1[idx].ItemRate + "," + p1[idx].Category);
                gross.Flush();
            }
            gross.Close();
        }
        public static void deleteItems_fromFile() ////////////////////// for deleting an item from file
        {
            string path = "data.txt";
            StreamWriter gross = new StreamWriter(path, false);
            for (int idx = 0; idx < p1.Count(); idx++)
            {
                gross.WriteLine(p1[idx].ItemName + "," + p1[idx].ItemRate + "," + p1[idx].Category);
                gross.Flush();
            }
            gross.Close();
        }
    }
}
