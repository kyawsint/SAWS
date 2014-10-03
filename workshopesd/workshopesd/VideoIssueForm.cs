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
    public partial class VideoIssueForm : Form
    {
        VideoIssue ds = new VideoIssue();
        VideoIssueTableAdapters.CustomersTableAdapter cus = new VideoIssueTableAdapters.CustomersTableAdapter();
        VideoIssueTableAdapters.MoviesTableAdapter mov = new VideoIssueTableAdapters.MoviesTableAdapter();
        VideoIssueTableAdapters.IssueTranTableAdapter isstran = new VideoIssueTableAdapters.IssueTranTableAdapter();

        public VideoIssueForm()
        {
            InitializeComponent();
        }

        private void VideoIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void btnmovdet_Click(object sender, EventArgs e)
        {
            VideoLookUp vlu = new VideoLookUp();
            vlu.Show();
        }

        private void txtvideocode_TextChanged(object sender, EventArgs e)
        {
            mov.FillByVidCodP(ds.Movies,Convert.ToInt16(txtvideocode.Text));
            txtmovietitle.DataBindings.Add("Text", ds, "Movies.MovieTitle");
        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {
            cus.FillByCusIDP(ds.Customers,txtcusid.Text);
            txtcusname.DataBindings.Add("Text", ds, "Customers.CustomerName");
        }
    }
}
