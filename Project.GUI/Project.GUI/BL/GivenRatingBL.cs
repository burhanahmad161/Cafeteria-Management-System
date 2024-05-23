using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL
{
    internal class GivenRatingBL
    {
        private string userName;
        private int rating;

        public string UserName { get => userName; set => userName = value; }
        public int Rating { get => rating; set => rating = value; }

        public GivenRatingBL(string name, int rating)
        {
            UserName = name;
            Rating = rating;
        }
    }
}
