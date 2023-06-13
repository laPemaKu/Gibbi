using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace I_want_to_kill_myself
{
    public partial class childForm : Form
    {
        public childForm()
        {
            InitializeComponent();
        }

        public void openFormInMain(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Gibbi.panel.Controls.Add(childForm);
            Gibbi.panel.Tag = childForm;
            childForm.Show();
        }
    }
}
