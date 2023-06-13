using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace I_want_to_kill_myself.Forms
{
    public partial class Artists : childForm
    {
        public Artists()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tableArt.Location = new Point(this.tableArt.Location.X,12 - vScrollBar1.Value);
        }
    }
}
