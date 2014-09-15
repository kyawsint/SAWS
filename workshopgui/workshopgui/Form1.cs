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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catchAFishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatchAFish caf = new CatchAFish();
            caf.ShowDialog();
            caf.Dispose();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatchAGenie cag = new CatchAGenie();
            cag.ShowDialog();
            cag.Dispose();
        }

        private void catchARabitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatchARabbit cab = new CatchARabbit();
            cab.ShowDialog();
            cab.Dispose();
        }

        private void contextMenuStripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.ShowDialog();
            cms.Dispose();
        }

        private void eg11AndEg12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eg1_1andeg1_2 eg1 = new eg1_1andeg1_2();
            eg1.ShowDialog();
            eg1.Dispose();
        }

        private void eg13aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eg1_3a eg3a = new eg1_3a();
            eg3a.ShowDialog();
            eg3a.Dispose();
        }

        private void eg13bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eg1_3b eg3b = new eg1_3b();
            eg3b.ShowDialog();
            eg3b.Dispose();
        }

        private void killARabbitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KillARabbit kab = new KillARabbit();
            kab.ShowDialog();
            kab.Dispose();
        }
    }
}
