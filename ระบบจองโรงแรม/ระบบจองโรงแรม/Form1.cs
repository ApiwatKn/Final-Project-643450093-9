using System.Data;

namespace ระบบจองโรงแรม
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        public Form1()
        {
            InitializeComponent();
            data.Columns.Add("Time_in");
            data.Columns.Add("Time_out");
            data.Columns.Add("number_room");
            data.Columns.Add("ราคา");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(this, data);
            data = form.indata;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}