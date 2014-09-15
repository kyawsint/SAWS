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
    public partial class eg1_3a : Form
    {
        public eg1_3a()
        {
            InitializeComponent();
        }

        private void eg1_3a_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(400, 300);
            this.btnreset.Font = new Font("Arial", 8.25F, FontStyle.Bold);
            this.btnreset.Location = new Point(200, 200);
            this.btnreset.Text = "Reset";
        }
    }
}
