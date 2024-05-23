using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL
{
    internal class LoginBL
    {
        private string name;
        private string userName;
        private string password;

        public string Name { get => name; set => name = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }

        public LoginBL()
        { }
        public LoginBL(string name,string username,string password)
        {
            this.Name = name;
            this.UserName = username;
            this.Password = password;
        }
    }
}
