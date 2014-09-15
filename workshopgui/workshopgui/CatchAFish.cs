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
    public partial class CatchAFish : Form
    {
        int x = 100, y = 100;
        Random rdm = new Random();

        public CatchAFish()
        {
            InitializeComponent();
            this.ClientSize = new Size(500, 500);
        }

        private void Fish_MouseEnter(object sender, EventArgs e)
        {
            x = rdm.Next(100, 400);
            y = rdm.Next(100, 400);
            this.btnfish.Location = new Point(x, y);
        }
    }
}
