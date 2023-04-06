using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ระบบจองโรงแรม
{
    public partial class Form3 : Form
    {
        Form fm1;
        DataTable indata;
        public Form3(Form fm, DataTable data)
        {
            InitializeComponent();
            fm1 = fm;
            indata = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fm1.Show(); ;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
