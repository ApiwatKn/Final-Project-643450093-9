using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ระบบจองโรงแรม
{
    public partial class Form4 : Form
    {
        public DataTable indata;
        public Form4(Form fm, DataTable data)
        {
            indata = data;
            InitializeComponent();
            fm1 = fm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form5 form = Form5(indata.Rows.Count);
                form.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm1.Show(); ;
        }
    }
}
