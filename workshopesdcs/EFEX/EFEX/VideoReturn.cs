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
    public partial class VideoReturn : Form
    {
        DafestyVKEntities ctx = new DafestyVKEntities();

        public VideoReturn()
        {
            InitializeComponent();
        }

        private void VideoReturn_Load(object sender, EventArgs e)
        {
            IssueTran ir = new IssueTran();

            var sourcecus = new AutoCompleteStringCollection();
            var cus = from c in ctx.Customers select c;
            foreach(Customer c in cus.ToList())
            {
                sourcecus.AddRange(new string[]
                {
                    c.CustomerName+Environment.NewLine
                });
            }

            txtcus.AutoCompleteCustomSource = sourcecus;
            txtcus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtcus.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var sourcemov = new AutoCompleteStringCollection();
            var mov = from m in ctx.Movies select m;
            foreach (Movie m in mov.ToList())
            {
                sourcemov.AddRange(new string[]
                {
                    m.MovieTitle+Environment.NewLine
                });
            }

            txtmov.AutoCompleteCustomSource = sourcemov;
            txtmov.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtmov.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtcus_TextChanged(object sender, EventArgs e)
        {
            //Customer cus=ctx.Customers.First(x=>x.CustomerName==txtcus.Text);
            var cus=from x in ctx.Customers where x.CustomerName==txtcus.Text select x;
            foreach (Customer c in cus.ToList())
            {
                label1.Text += c.CustomerID + Environment.NewLine;
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            var cus = from x in ctx.Customers where x.CustomerName == txtcus.Text select x;
            foreach (Customer c in cus.ToList())
            {
                label1.Text += c.CustomerID + Environment.NewLine;
            }
        }
    }
}
