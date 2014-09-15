using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workshopgui
{
    public partial class CatchAGenie : Form
    {
        int x = 100, y = 150;
        public CatchAGenie()
        {
            InitializeComponent();
        }

        private void CatchAGenie_Load(object sender, EventArgs e)
        {
            this.picgenie.Visible = false;
        }

        private void piclamp_Click(object sender, EventArgs e)
        {
            this.picgenie.Visible = true;
        }

        private void piclamp_DoubleClick(object sender, EventArgs e)
        {
            this.picgenie.Size = new Size(x, y);
            x += 25;
            y += 25;
        }

        private void Genie_MouseMove(object sender, MouseEventArgs e)
        {
            this.picgenie.Size = new Size(50, 60);
        }
    }
}
