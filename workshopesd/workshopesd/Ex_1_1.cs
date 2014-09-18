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
    public partial class Ex_1_1 : Form
    {
        public Ex_1_1()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            string cons = "data source=(local);initial catalog=DafestyNew;Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(cons);
            string videocode=txtvideo_code.Text;
            string rentalprice=txtrental_price.Text;
            con.Open();
            string sql = "update movies set rentalprice=" + rentalprice + " where videocode=" + videocode;
            SqlCommand cmd = new SqlCommand(sql, con);
            string sql1 = "select videocode from movies";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
                flag = false;
            }
            con.Close();
            if(flag)
                MessageBox.Show("Update Success !!!");
        }
    }
}
