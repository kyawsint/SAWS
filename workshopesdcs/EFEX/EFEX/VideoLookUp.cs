using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EFEX.Data;

namespace EFEX
{
    public partial class VideoLookUp : Form
    {
        DafestyVKEntities ctx = new DafestyVKEntities();

        public VideoLookUp()
        {
            InitializeComponent();
        }

        private void VideoLookUp_Load(object sender, EventArgs e)
        {
            var q = from x in ctx.Movies select new { x.VideoCode, x.MovieTitle, x.MovieType, x.RentalPrice, x.TotalStock, x.NumberRented, x.Rating };
            dgvvlu.DataSource = q.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string VidCod
        {
            get { return dgvvlu.CurrentRow.Cells["VideoCode"].Value.ToString(); }
        }

        public string MovT
        {
            get { return dgvvlu.CurrentRow.Cells["MovieTitle"].Value.ToString(); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
