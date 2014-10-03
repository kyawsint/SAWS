using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EFEX.Data;

namespace EFEX
{
    public partial class CustomerLookUp : Form
    {
        DafestyVKEntities ctx = new DafestyVKEntities();

        public CustomerLookUp()
        {
            InitializeComponent();
        }

        private void CustomerLookUp_Load(object sender, EventArgs e)
        {
            var q = from x in ctx.Customers select new { x.CustomerID, x.CustomerName, x.Address, x.PhoneNumber };
            dgvclu.DataSource = q.ToList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public string CusID
        {
            get { return dgvclu.CurrentRow.Cells["CustomerID"].Value.ToString(); }
        }
    }
}
