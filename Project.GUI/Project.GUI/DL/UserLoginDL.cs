using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;
using System.IO;

namespace Project.DL
{
    internal class UserLoginDL
    {
    public static List<UserLoginBL> userDetails = new List<UserLoginBL>();
        public static void storeInFile(string user, string userName, string password, int cardNumber, int pin) //////////// for storing users info in file
        {
            string path = "user.txt";
            StreamWriter gross = new StreamWriter(path, true);
            gross.WriteLine(user + "," + userName + "," + password + "," + cardNumber + "," + pin);
            gross.Flush();
            gross.Close();
        }
        public static void addIntoList(UserLoginBL obj)
        {
            userDetails.Add(obj);
        }
        public static void addIntoFile(UserLoginBL obj)
        {
            storeInFile(obj.Name,obj.UserName,obj.Password,obj.CardNumber1,obj.Pin1);
        }
        public static void loadData() /////////////// for loading user's data from file
        {
            string user = "user.txt";
            StreamReader fp = new StreamReader(user);
            string word;
            if (File.Exists(user))
            {
                while ((word = fp.ReadLine()) != null)
                {
                    string[] splittedRecords = word.Split(',');
                    string name = splittedRecords[0];
                    string UserName = splittedRecords[1];
                    string Password = splittedRecords[2];
                    int CardNumber = int.Parse(splittedRecords[3]);
                    int Pin = int.Parse(splittedRecords[4]);
                    UserLoginBL obj = new UserLoginBL(name, UserName, Password, CardNumber, Pin);
                    userDetails.Add(obj);
                }
                fp.Close();
            }
        }
    }
}
