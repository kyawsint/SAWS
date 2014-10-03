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
    public partial class Eg2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlDataReader sdr;
        DataSet ds;
        string cons = "data source=KYAWSINT;initial catalog=Dafestyvk;Integrated Security=SSPI";

        public Eg2()
        {
            InitializeComponent();
        }

        private void Eg2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cons);
            cmd = new SqlCommand();
        }

        private void btn_updconcat_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update customers set membercategory='" + textBox2.Text + "' where customerid='" + textBox1.Text + "'";
            cmd.Connection = con;
            con.Open();
            int i = cmd.ExecuteNonQuery();
            label1.Text = i.ToString();
        }

        private void btn_updparam_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "update customers set membercategory=@mc where customerid=@cid";
            cmd.Connection = con;
            SqlParameter pmc = new SqlParameter("@mc", SqlDbType.NVarChar, 2);
            SqlParameter pcid = new SqlParameter("@cid", SqlDbType.NVarChar, 4);
            cmd.Parameters.Add(pmc);
            cmd.Parameters.Add(pcid);
            con.Open();
            pmc.Value = textBox2.Text;
            pcid.Value = (string)textBox1.Text;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_updsto_Click(object sender, EventArgs e)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "update_customers";
            cmd.Connection = con;

            SqlParameter pmc = new SqlParameter("@mc", SqlDbType.NVarChar, 2);
            SqlParameter pcid = new SqlParameter("@cid", SqlDbType.NVarChar, 4);

            cmd.Parameters.AddWithValue(textBox1.Text, pmc);
            cmd.Parameters.AddWithValue(Convert.ToString(textBox1.Text),pcid);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
