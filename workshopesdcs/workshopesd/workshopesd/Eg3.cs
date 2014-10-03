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
    public partial class Eg3 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;
        SqlCommandBuilder scb;
        string cons = "data source=KYAWSINT; initial catalog=Dafestyvk; integrated security=SSPI";

        public Eg3()
        {
            InitializeComponent();
        }

        private void Eg3_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cons);
            cmd = new SqlCommand();
            ds = new DataSet();
            cmd.CommandText = "select customerid, customername, membercategory from customers";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            scb = new SqlCommandBuilder(sda);
            sda.Fill(ds, "Customers");
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            label1.Text = ds.Tables["Customers"].Rows[3][1].ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ds.Tables["Customers"].Rows[3][2] = "ZZZ";
            label1.Text = ds.Tables["Customers"].Rows[3][2].ToString();

            sda.Update(ds, "Customers");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Customers"].NewRow();
            dr[0] = "1005";
            dr[1] = "Venkat";
            dr[2] = "Z";
            ds.Tables["Customers"].Rows.Add(dr);

            label1.Text = ds.Tables["Customers"].Rows.Count.ToString();
            sda.Update(ds, "Customers");
        }
    }
}
