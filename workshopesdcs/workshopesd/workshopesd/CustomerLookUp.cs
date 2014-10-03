using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace workshopesd
{
    public partial class CustomerLookUp : Form
    {
        VideoIssue ds = new VideoIssue();
        VideoIssueTableAdapters.CustomersTableAdapter cus = new VideoIssueTableAdapters.CustomersTableAdapter();
        
        public CustomerLookUp()
        {
            InitializeComponent();
        }

        private void CustomerLookUp_Load(object sender, EventArgs e)
        {
            cus.Fill(ds.Customers);
            dgvclookup.DataSource = ds;
            dgvclookup.DataMember = "Customers";
        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public string LblCus
        {
            get { return dgvclookup.CurrentRow.Cells["customerid"].Value.ToString(); }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
