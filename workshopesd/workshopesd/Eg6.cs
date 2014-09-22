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
    public partial class Eg6 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataSet ds;
        string cons = "data source=KYAWSINT; initial catalog=DafestyVK; integrated security=SSPI";

        public Eg6()
        {
            InitializeComponent();
        }

        private void Eg6_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cons);
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "select_customers";
            cmd.Connection = con;

            sda = new SqlDataAdapter(cmd);
            scb = new SqlCommandBuilder(sda);
            ds = new DataSet();
            sda.Fill(ds, "Customers");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dgv_1.DataSource = ds;
            dgv_1.DataMember="Customers";
        }
    }
}
