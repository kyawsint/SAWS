using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace workshopesd
{
    public partial class Ex_Video : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder scb;
        string cons = "data source=KYAWSINT;initial catalog=DafestyVK;integrated security=SSPI";
        int posn = 0;

        public Ex_Video()
        {
            InitializeComponent();
        }

        private void Ex_Video_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cons);
            cmd=new SqlCommand();
            cmd.CommandText = "select customerid, customername, membercategory from customers";
            cmd.Connection = con;

            sda = new SqlDataAdapter(cmd);
            scb = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds, "Customers");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            for(int i=0;i<ds.Tables["Customers"].Rows.Count;i++)
            {
                if (ds.Tables["Customers"].Rows[i]["customerid"].Equals(txtsearch.Text.ToString()))
                {
                    posn = i;
                    break;
                }
            }
            DisplayData();
        }

        private void DisplayData()
        {
            txtcusid.Text = ds.Tables["Customers"].Rows[posn]["customerid"].ToString();
            txtcusname.Text = ds.Tables["Customers"].Rows[posn]["customername"].ToString();
            txtmc.Text = ds.Tables["Customers"].Rows[posn]["membercategory"].ToString();
            toolStripStatusLabel1.Text = posn.ToString();
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            posn = 0;
            DisplayData();
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (posn > 0)
            {
                posn--;
                DisplayData();
            }
            else
            {
                toolStripStatusLabel1.Text = "This is the first record!";
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (posn < ds.Tables["Customers"].Rows.Count-1)
            {
                posn++;
                DisplayData();
            }
            else
                toolStripStatusLabel1.Text = "This is the last record!";
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            posn = ds.Tables["Customers"].Rows.Count - 1;
            DisplayData();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void RetrieveData()
        {
            ds.Tables["Customers"].Rows[posn]["customerid"] = txtcusid.Text;
            ds.Tables["Customers"].Rows[posn]["customername"] = txtcusname.Text;
            ds.Tables["Customers"].Rows[posn]["membercategory"] = txtmc.Text;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            RetrieveData();
            sda.Update(ds, "Customers");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            ClearData();
            DataRow dra = ds.Tables["Customers"].NewRow();
            ds.Tables["Customers"].Rows.Add(dra);
            RetrieveData();
            sda.Update(ds, "Customers");
            posn = ds.Tables["Customers"].Rows.Count - 1;
        }

        private void ClearData()
        {
            txtcusid.Clear();
            txtcusname.Clear();
            txtmc.Clear();
            txtsearch.Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Customers"].Rows[posn];
            dr.Delete();
            sda.Update(ds, "Customers");
            DisplayData();
        }
    }
}
