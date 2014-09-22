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
    public partial class Eg8 : Form
    {
        public Eg8()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dafestyVKDataSet);

        }

        private void Eg8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dafestyVKDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.dafestyVKDataSet.Customers);

        }
    }
}
