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
    public partial class ContextMenuStrip : Form
    {
        int width, height;
        public ContextMenuStrip()
        {
            InitializeComponent();
            width = this.pictureBox1.Width;
            height = this.pictureBox1.Height;
        }

        private void makeBigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width = width * 2;
            this.pictureBox1.Height = height * 2;
        }

        private void makeNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width = width;
            this.pictureBox1.Height = height;
        }

        private void makeSmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Width = width / 2;
            this.pictureBox1.Height = height / 2;
        }
    }
}
