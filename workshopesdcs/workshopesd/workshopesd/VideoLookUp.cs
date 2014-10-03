using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workshopesd
{
    public partial class VideoLookUp : Form
    {
        VideoIssue ds = new VideoIssue();
        VideoIssueTableAdapters.MoviesTableAdapter mov = new VideoIssueTableAdapters.MoviesTableAdapter();

        public VideoLookUp()
        {
            InitializeComponent();
        }

        private void VideoLookUp_Load(object sender, EventArgs e)
        {
            mov.Fill(ds.Movies);
            dgvlookup.DataSource = ds;
            dgvlookup.DataMember = "Movies";
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public string VidCod
        {
            get { return dgvlookup.CurrentRow.Cells["VideoCode"].Value.ToString(); }
        }

    }
}
