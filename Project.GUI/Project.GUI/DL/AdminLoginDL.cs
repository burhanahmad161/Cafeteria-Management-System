using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.BL;
using Project.DL;

namespace Project.DL
{
    internal class AdminLoginDL
    {
        public static List<AdminLoginBL> adminDetails = new List<AdminLoginBL>();
        public static void storeAdminData(string admin, string adminName, string adminPassword) //////////// for storing users info in file
        {
            string path = "admin.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(admin + "," + adminName + "," + adminPassword);
            file.Flush();
            file.Close();
        }
        public static void loadAdminData() /////////////// for loading user's data from file
        {
            string path = "admin.txt";
            StreamReader fp = new StreamReader(path);
            string word;
            if (File.Exists(path))
            {
                while ((word = fp.ReadLine()) != null)
                {
                    string[] splittedRecords = word.Split(',');
                    string name = splittedRecords[0];
                    string username = splittedRecords[1];
                    string password = splittedRecords[2];
                    AdminLoginBL data = new AdminLoginBL(name, username, password);
                    adminDetails.Add(data);
                }
                fp.Close();
            }
        }
        public static void addIntoList(AdminLoginBL obj)
        {
            adminDetails.Add(obj);
        }
        public static void addIntoFile(AdminLoginBL obj)
        {
            storeAdminData(obj.Name, obj.UserName, obj.Password);
        }
    }
}
