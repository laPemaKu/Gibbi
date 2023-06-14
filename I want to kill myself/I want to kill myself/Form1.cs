
using I_want_to_kill_myself.Account;
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

namespace I_want_to_kill_myself
{
    public partial class Gibbi : Form
    {
        int load = 0;
        public static Panel panel;
        public Gibbi()
        {
            InitializeComponent();
            panel = pnlMain;
        }

        public void openForm(childForm childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;
            childForm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            switch (pnlMenu.Visible)
            {
                case true:
                    pnlMenu.Visible = false; break;
                case false:
                    pnlMenu.Visible = true; break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openForm(new Register());
        }

        private void pnlMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (load > 0)
            {
                
            }
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            openForm(new Artists());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            openForm(new Orders());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            openForm(new Profile());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openForm(new Settings());
            pnlMain.Controls.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Gibbi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
