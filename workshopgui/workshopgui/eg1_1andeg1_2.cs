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
    public partial class eg1_1andeg1_2 : Form
    {
        public eg1_1andeg1_2()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "")
            {
                lblsubmit.Text = "Hello ! " + txtname.Text;
                lblsubmit.Visible = true;
            }
            else
            {
                lblnamemsg.Visible = true;
            }
        }

        private void btnbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK button has been Clicked.");
            MessageBox.Show("Height is " + btnbutton1.Height + " , Width is " + btnbutton1.Width + " and Color is " + btnbutton1.BackColor);
        }
    }
}
