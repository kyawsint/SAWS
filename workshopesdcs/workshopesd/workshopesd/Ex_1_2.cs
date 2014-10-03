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
    public partial class Ex_1_2 : Form
    {
        string cons = "data source=(local);initial catalog=DafestyNew;Integrated Security=SSPI";
        public Ex_1_2()
        {
            InitializeComponent();
        }

        private void btn_retrieve_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cons);
            string sql = "select movietitle from movies where rating='" + txt_rating.Text + "'";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con;
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            lbl_retrieve.Items.Clear();
            while (sdr.Read())
            {
                lbl_retrieve.Items.Add(sdr["movietitle"].ToString()+Environment.NewLine);
            }
            sdr.Close();
            con.Close();
        }
    }
}
