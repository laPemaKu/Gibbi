using I_want_to_kill_myself.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_want_to_kill_myself.Account
{
    public partial class Login : childForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            openFormInMain(new Register());
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text, password = txtPassword.Text;
            User you = new User(username, password);
            Accounts acc = new Accounts();
            if (acc.CheckForAccount(you)==true)
            {
                if (acc.CheckForLogin(you) == true)
                {
                    openFormInMain(new Artists());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Input was invalid", "Invlaid input", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Account doesnt exist", "Invlaid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
