using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workshopesd
{
    public partial class Eg7 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataSet ds;
        DataView dv;
        string cons = "data source=(local);initial catalog=DafestyVK;integrated security=SSPI";

        public Eg7()
        {
            InitializeComponent();
        }

        private void Eg7_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cons);
            cmd = new SqlCommand("select customerid, customername, membercategory from customers", con);
            sda = new SqlDataAdapter(cmd);
            scb = new SqlCommandBuilder(sda);
            ds = new DataSet();
            dv = new DataView();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            sda.Fill(ds, "Customers");
            dv.Table = ds.Tables["Customers"];

            txtcusid.DataBindings.Add("Text", dv, "customerid");
            txtcusname.DataBindings.Add("Text", dv, "customername");
            txtmc.DataBindings.Add("Text", dv, "membercategory");
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].Position = 0;
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].Position = ds.Tables["Customers"].Rows.Count - 1;
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].Position--;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].Position++;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].EndCurrentEdit();
            sda.Update(ds, "Customers");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.BindingContext[dv].RemoveAt(this.BindingContext[dv].Position);
            sda.Update(ds, "Customers");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            BindingContext[dv].Position=dv.Find(txtsearch.Text);
        }

        private void btnsortcid_Click(object sender, EventArgs e)
        {
            dv.Sort = "customerid";
        }

        private void btnsortcusname_Click(object sender, EventArgs e)
        {
            dv.Sort = "customername desc";
        }

        private void btnsortmc_Click(object sender, EventArgs e)
        {
            dv.Sort = "membercategory desc";
        }

        private void btnfiltermc_Click(object sender, EventArgs e)
        {
            dv.RowFilter = "membercategory='A' and customername like 'A%'";
        }
    }
}
