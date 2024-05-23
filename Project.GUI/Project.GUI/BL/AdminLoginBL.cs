using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DL;

namespace Project.BL
{
    internal class AdminLoginBL : LoginBL
    {
        public AdminLoginBL() { }
        public AdminLoginBL(string Name,string UserName,string Password) : base(Name,UserName,Password)
        { 
        
        }
        public static bool AdminSignin(string adminName, string adminPassword) /////////////////// for checking sigining in
        {
            bool flag = false;
            for(int idx=0;idx<AdminLoginDL.adminDetails.Count;idx++)
            {
                if (AdminLoginDL.adminDetails[idx].UserName == adminName && AdminLoginDL.adminDetails[idx].Password == adminPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public static bool isvalidAdmin(string adminName) ///////////////////// to check validity of adminName
        {
            bool flag = true;
            foreach (AdminLoginBL name in AdminLoginDL.adminDetails)
            {
                if (name.Name == adminName)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
