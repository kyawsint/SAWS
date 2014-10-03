using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFEX
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnvi_Click(object sender, EventArgs e)
        {
            VideoIssueForm vlf = new VideoIssueForm();
            vlf.Show();
        }

        private void btnvr_Click(object sender, EventArgs e)
        {
            VideoReturn vr = new VideoReturn();
            vr.Show();
        }
    }
}
