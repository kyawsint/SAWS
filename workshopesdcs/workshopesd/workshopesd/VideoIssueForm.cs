using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workshopesd
{
    public partial class VideoIssueForm : Form
    {
        SqlConnection con;
        SqlCommand cmdinsertIT;
        SqlCommand cmdupdatemov;

        SqlParameter cid;
        SqlParameter vc;
        SqlParameter di;
        SqlParameter dd;
        SqlParameter remarks;
        SqlParameter vcu;
        
        string cons = "data source=(local);initial catalog=DafestyVK; integrated security=True";
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
            con = new SqlConnection(cons);
            cmdinsertIT = new SqlCommand();
            cmdupdatemov = new SqlCommand();
            cmdinsertIT.CommandText = "insert into issuetran (customerid, videocode, dateissue, datedue, rentalstatus, remarks) values(@CID, @VC, @DI, @DD, 'OUT', @Remarks)";
            cmdinsertIT.Connection = con;

            cid = new SqlParameter("@CID", SqlDbType.NVarChar, 4);
            vc = new SqlParameter("@VC", SqlDbType.SmallInt);
            di = new SqlParameter("@DI", SqlDbType.DateTime);
            dd = new SqlParameter("@DD", SqlDbType.DateTime);
            remarks = new SqlParameter("@Remarks", SqlDbType.NVarChar, 255);
            cmdinsertIT.Parameters.AddRange(new SqlParameter[] { cid, vc, di, dd, remarks });

            cmdupdatemov.CommandText = "update movies set numberrented=numberrented+1 where videocode=@VCU";
            cmdupdatemov.Connection = con;
            vcu = new SqlParameter("@VCU", SqlDbType.SmallInt);
            cmdupdatemov.Parameters.Add(vcu);

            dtpduedate.Value = dtpdateissue.Value.AddDays(2);
        }

        private void btnmovdet_Click(object sender, EventArgs e)
        {
            VideoLookUp vlu = new VideoLookUp();
            DialogResult dr=vlu.ShowDialog();
            if (dr == DialogResult.OK)
                txtvideocode.Text = vlu.VidCod;
            vlu.Dispose();
        }

        private void txtvideocode_TextChanged(object sender, EventArgs e)
        {
            mov.FillByVidCodP(ds.Movies, Convert.ToInt16(txtvideocode.Text));
            txtmovietitle.DataBindings.Clear();
            txtmovietitle.DataBindings.Add("Text", ds, "Movies.MovieTitle");
        }
        
        private void btncusdet_Click(object sender, EventArgs e)
        {
            CustomerLookUp clu = new CustomerLookUp();
            DialogResult drc = clu.ShowDialog();
            if (drc == DialogResult.OK)
                txtcusid.Text = clu.LblCus;
            clu.Dispose();
        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {
            cus.FillByCusIDP(ds.Customers, txtcusid.Text);
            txtcusname.DataBindings.Clear();
            txtcusname.DataBindings.Add("Text", ds, "Customers.CustomerName");
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            cid.Value = txtcusid.Text;
            vc.Value = Convert.ToInt16(txtvideocode.Text);
            vcu.Value = Convert.ToInt16(txtvideocode.Text);
            dd.Value = dtpduedate.Value.Date;
            di.Value = dtpdateissue.Value.Date;
            remarks.Value = txtremark.Text;
   
            using (TransactionScope ts = new TransactionScope())
            {
                con.Open();
                cmdinsertIT.ExecuteNonQuery();
                cmdupdatemov.ExecuteNonQuery();
                ts.Complete();
            }
            con.Close();
            Clear();
        }

        private void Clear()
        {
            txtcusid.Clear();
            txtcusname.Clear();
            txtmovietitle.Clear();
            txtvideocode.Clear();
            txtremark.Clear();
        }
    }
}
