using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using EFEX.Data;

namespace EFEX
{
    public partial class VideoIssueForm : Form
    {
        DafestyVKEntities ctx = new DafestyVKEntities();

        public VideoIssueForm()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            IssueTran it = new IssueTran();

            short i = System.Convert.ToInt16(txtvideocode.Text);

            Movie m = ctx.Movies.First(x => x.VideoCode == i);
            m.NumberRented += 1;

            it.CustomerID = txtcusid.Text;
            it.VideoCode = Convert.ToInt16(txtvideocode.Text);
            it.DateIssue = dtpdateissue.Value.Date;
            it.DateDue = dtpduedate.Value.Date;
            it.RentalStatus = "OUT";
            it.Remarks = txtremark.Text;

            ctx.AddToIssueTrans(it);
            if (m.NumberRented <= m.TotalStock)
                ctx.SaveChanges();
        }

        private void btnmovdet_Click(object sender, EventArgs e)
        {
            VideoLookUp vlu = new VideoLookUp();
            DialogResult dr = vlu.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtvideocode.Text = vlu.VidCod;
                txtmovietitle.Text = vlu.MovT;
            }
            vlu.Dispose();

        }

        private void txtvideocode_TextChanged(object sender, EventArgs e)
        {
            //var m = from x in ctx.Movies where x.VideoCode == Convert.ToInt32(txtvideocode.Text) select new { x.MovieTitle };

            //Movie m = ctx.Movies.First(x => Convert.ToInt32(x.VideoCode) == Convert.ToInt32(txtvideocode.Text));
            //txtmovietitle.Text = m.MovieTitle;
        }

        private void btncusdet_Click(object sender, EventArgs e)
        {
            CustomerLookUp clu = new CustomerLookUp();
            DialogResult dr = clu.ShowDialog();
            if (dr == DialogResult.OK)
                txtcusid.Text = clu.CusID;
            clu.Dispose();
        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {

        }

        private void VideoIssueForm_Load(object sender, EventArgs e)
        {

        }

        private void txtcusid_Leave(object sender, EventArgs e)
        {
            Customer cus = ctx.Customers.First(x => x.CustomerID == txtcusid.Text);
            txtcusname.Text = cus.CustomerName;
        }
    }
}
