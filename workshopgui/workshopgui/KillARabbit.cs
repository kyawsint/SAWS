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
    public partial class KillARabbit : Form
    {
        int x = 200, y = 200;
        Random rdm = new Random();
        public KillARabbit()
        {
            InitializeComponent();
        }

        private void KillARabbit_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(500, 500);
            this.btnRabbit.Location = new Point(x, y);
        }

        private void Rabbit_MouseDown(object sender, MouseEventArgs e)
        {
            this.btnRabbit.Image = Image.FromFile(@"C:\Users\a0132516n\Downloads\KyawSint\workshopgui\workshopgui\image\sadRabbit.gif");
            this.btnRabbit.Text = "Don't kill me!";
        }

        private void Rabbit_MouseUp(object sender, MouseEventArgs e)
        {
            this.btnRabbit.Image = Image.FromFile(@"C:\Users\a0132516n\Downloads\KyawSint\workshopgui\workshopgui\image\happyRabbit.gif");
            this.btnRabbit.Text = "Happy Rabbit";
            x = rdm.Next(100, 400);
            y = rdm.Next(100, 400);
            this.btnRabbit.Location = new Point(x, y);
        }
    }
}
