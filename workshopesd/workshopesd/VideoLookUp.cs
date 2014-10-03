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
        VideoIssueTableAdapters.CustomersTableAdapter cus = new VideoIssueTableAdapters.CustomersTableAdapter();
        VideoIssueTableAdapters.MoviesTableAdapter mov = new VideoIssueTableAdapters.MoviesTableAdapter();

        public VideoLookUp()
        {
            InitializeComponent();
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            VideoIssueForm vif = new VideoIssueForm();
            vif.txtcusid.Text = "asdf";
            //vif.txtcusname.Text = ds.Customers.CustomerNameColumn.ToString();
            this.SuspendLayout();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VideoLookUp_Load(object sender, EventArgs e)
        {
            cus.Fill(ds.Customers);
            dgvlookup.DataSource = ds;
            dgvlookup.DataMember = "Customers";
        }
    }
}
