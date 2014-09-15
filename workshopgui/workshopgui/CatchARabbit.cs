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
    public partial class CatchARabbit : Form
    {
        Random rdm = new Random();
        int x, y;

        public CatchARabbit()
        {
            InitializeComponent();
        }

        private void btnrabbit_Click(object sender, EventArgs e)
        {
            x = rdm.Next(100, 400);
            y = rdm.Next(100, 400);
            this.btnrabbit.Location = new Point(x, y);
        }

        private void eg1_4_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(500, 500);
        }
    }
}
