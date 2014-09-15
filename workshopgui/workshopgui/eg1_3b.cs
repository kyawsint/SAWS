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
    public partial class eg1_3b : Form
    {
        public eg1_3b()
        {
            InitializeComponent();
        }

        private void eg1_3b_Load(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ButtonFace;
            this.ClientSize = new Size(199, 264);
        }

        private void eg1_3b_Close(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Bye Bye");
        }
    }
}
