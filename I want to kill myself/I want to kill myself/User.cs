using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_want_to_kill_myself
{
    internal class User
    {
        string username, email, password;
        DateTime birthday;

        public User(string username, string email, string password, DateTime birthday)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.birthday = birthday;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }

        public string Csv()
        {
            
            return username + ", " + email + ", " + password + ", " + birthday;
        }
    }
}
