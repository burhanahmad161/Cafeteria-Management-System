using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DL;
namespace Project.BL
{
    internal class UserLoginBL : LoginBL
    {

        private int CardNumber;
        private int Pin;
        public UserLoginBL()
        { }
        public UserLoginBL(string Name,string UserName,string Password,int CardNumber, int Pin) : base(Name,UserName,Password)
        {   
            this.CardNumber = CardNumber;
            this.Pin = Pin;
        }

        public int CardNumber1 { get => CardNumber; set => CardNumber = value; }
        public int Pin1 { get => Pin; set => Pin = value; }

        public static bool isvaliduser(string userName) ///////////////////// to check validity of username
        {
            bool flag = true;
            foreach (UserLoginBL name in UserLoginDL.userDetails)
            {
                if (name.Name == userName)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        public static bool signin(string userName, string password) /////////////////// for checking sigining in
        {
            bool flag = false;
            foreach (UserLoginBL name in UserLoginDL.userDetails)
            {
                if (name.UserName == userName && name.Password == password)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

    }
}
