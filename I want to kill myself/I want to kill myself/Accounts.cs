using I_want_to_kill_myself.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I_want_to_kill_myself
{
    internal class Accounts
    {
        public static List<User> accounts = new List<User>();

        public bool CheckForAccount(User user)
        {
            bool accountExists = false;
            foreach(User e in accounts)
            {
                if(user.Username == e.Username)
                {
                    accountExists = true;
                    break;
                }
            }
            return accountExists;
        }
        public bool CheckForLogin(User user)
        {
            bool Login = false;
            foreach(User e in accounts)
            {
                if (user.Username == e.Username && user.Password == e.Password)
                {
                    Login = true;
                    break;
                }
            }
            return Login;
        }

        public string LoadCsv()
        {
            string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "\\Accounts.csv";
            StreamReader sr = new StreamReader(path);
            string cvs = sr.ReadToEnd();
            sr.Close();
            return cvs;

        }

        public void SaveCsv()
        {
            string path = System.IO.Path.Combine(System.Windows.Forms.Application.StartupPath, "Resources") + "\\Accounts.csv";
            StreamWriter sw = new StreamWriter(path);
            foreach (User e in accounts)
            {
                sw.WriteLine(e.Csv());  
            }
            sw.Close();
        }
    }
}
