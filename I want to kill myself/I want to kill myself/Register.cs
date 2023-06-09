﻿using I_want_to_kill_myself.Forms;
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
    public partial class Register : childForm
    {
        DateTime date = DateTime.Now;
        public Register()
        {
            InitializeComponent();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            openFormInMain(new Login());
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text, password = txtPassword.Text, email = txtEmail.Text;
            DateTime birthday = dateTimePicker1.Value;
            User you = new User(username, email, password, birthday);
            Accounts acc = new Accounts();
            if(acc.CheckForAccount(you)==false)
            {
                if (you.Username != "" && you.Email!= "" && you.Password != "")
                {
                    Accounts.accounts.Add(you);
                    openFormInMain(new Artists());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Input was invalid", "Invlaid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Account exists\nWould you like to go to the login page?", "Invlaid input", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
    }
}
