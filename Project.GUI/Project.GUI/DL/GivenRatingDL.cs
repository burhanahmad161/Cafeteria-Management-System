using Project.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DL
{
    internal class GivenRatingDL
    {
        public static List<GivenRatingBL> ratings = new List<GivenRatingBL>();
        public static void storeReview(string ratingName, int review) ////////////////////// for storing customer's review
        {
            string path = "rating.txt";
            StreamWriter gross = new StreamWriter(path, true);
            gross.WriteLine(ratingName + "," + review);
            gross.Flush();
            gross.Close();
        }
        public static void loadReview() ////////////////////// for loading customer's review
        {
            string path = "rating.txt";
            StreamReader fp = new StreamReader(path);
            string word;
            while ((word = fp.ReadLine()) != null)
            {
                string name = Parsing.parsItems(word, 1);
                int review = int.Parse((Parsing.parsItems(word, 2)));
                GivenRatingBL obj = new GivenRatingBL(name, review);
                ratings.Add(obj);
            }
            fp.Close();
        }
    }
}
