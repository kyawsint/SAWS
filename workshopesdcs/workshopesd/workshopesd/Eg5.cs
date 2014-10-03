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
    public partial class Eg5 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder scb;
        string cons = "data source=KYAWSINT;initial catalog=DafestyVK; integrated security=SSPI";
        int posn = 0;

        public Eg5()
        {
            InitializeComponent();
        }

        private void Eg5_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cons);
            string query = "select customerid, customername, membercategory from customers";
            cmd = new SqlCommand(query, con);
            sda = new SqlDataAdapter(cmd);
            scb = new SqlCommandBuilder(sda);
            ds = new DataSet();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            sda.Fill(ds, "Customers");
            DataBind();
        }

        private void DataBind()
        {
            txtcusid.DataBindings.Add("Text", ds, "Customers.customerid");
            txtcusname.DataBindings.Add("Text", ds, "Customers.customername");
            txtmc.DataBindings.Add("Text", ds, "Customers.membercategory");
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].Position = 0;
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].Position = ds.Tables["Customers"].Rows.Count - 1;
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].Position--;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].Position++;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].EndCurrentEdit();
            sda.Update(ds, "Customers");
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Customers"].RemoveAt(this.BindingContext[ds, "Customers"].Position);
            sda.Update(ds, "Customers");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string s = txtsearch.Text;
            for (int i = 0; i < ds.Tables["Customers"].Rows.Count; i++)
            {
                if (s == ds.Tables["Customers"].Rows[i]["CustomerID"].ToString())
                {
                    posn = i;
                    break;
                }
            }
            this.BindingContext[ds, "Customers"].Position = posn;
        }
    }
}
