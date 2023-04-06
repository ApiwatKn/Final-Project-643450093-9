using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ระบบจองโรงแรม
{
    public partial class Form5 : Form
    {
        Form fm1;
        public DataTable indata;
        DataTable Check = new DataTable();
        String numberroom = "";
        String roomRate = "";

        public Form5 (DataTable indata, Form fm1)
        {
            this.indata = indata;
            this.fm1 = fm1;
        }

        private void Chkcolor()
        {
            button101.BackColor = Color.LawnGreen;
            button102.BackColor = Color.LawnGreen;
            button103.BackColor = Color.LawnGreen;
            button201.BackColor = Color.LawnGreen;
            button202.BackColor = Color.LawnGreen;
            button203.BackColor = Color.LawnGreen;
        }

        public void Addtime(String numberrom, String roomRate)
        {
            int dayin = Int32.Parse(dateTimePicker1.Value.Day.ToString());
            int dayout = Int32.Parse(dateTimePicker2.Value.Day.ToString());
            int mouthin = Int32.Parse(dateTimePicker1.Value.Month.ToString());
            int mouthout = Int32.Parse(dateTimePicker2.Value.Month.ToString());
            int yearin = Int32.Parse(dateTimePicker1.Value.Year.ToString());
            int yearout = Int32.Parse(dateTimePicker2.Value.Year.ToString());
            Mouth(dayin, dayout, mouthin, mouthout, yearin, yearout, numberroom, roomRate);
        }
        public void Mouth(int dayin, int dayout, int mouthin, int mouthout, int yearin, int yearout, String numberroom, String roomRate)
        {
            int[] m1 = { 31, 28, 31, 30, 31, 30, 31, 31, 31, 30, 31, 30, 31 };
            String[] mchk = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int[] sum = new Int32[10];
            sum[0] = dayin;
            var addyearin = yearin.ToString();
            int chk = 0;
            var chk1 = dateTimePicker1.Value.ToShortDateString();
            var chkyearlength = dateTimePicker1.Value.ToShortDateString();
            String yearinSub = dateTimePicker1.Value.ToShortDateString().Substring(chkyearlength.Length - 4);
            var chkmouthlength = dateTimePicker1.Value.ToShortDateString();
            String stringsub = dateTimePicker1.Value.ToShortDateString().Substring(chkmouthlength.Length - 5, 1);
            int numberDay = 0;
            for (int i = 0; ; i++)
            {
                for (int ii = 0; ii < indata.Rows.Count; ii++)
                {
                    if (sum[7] < 10)
                    {
                        if ("0" + sum[7].ToString() + stringsub + mouthin + stringsub + yearinSub == indata.Rows[ii][0].ToString()
                            && numberroom == indata.Rows[ii][2].ToString())
                        {
                            chk++;
                        }
                    }
                    else if (sum[7] > 10)
                    {
                        {
                            if (sum[7].ToString() + stringsub + mouthin + "-" + stringsub + yearinSub == indata.Rows[ii][0].ToString()
                    && numberroom == indata.Rows[ii][2].ToString())
                            {
                                chk++;
                            }
                        }
                    }
                    if (chk == 0)
                        numberDay++;
                    {
                        indata.Rows.Add(sum[0] + "-" + stringsub + mouthin + stringsub + yearinSub, dateTimePicker2.Value.ToShortDateString(), numberroom, roomRate);
                        Check.Rows[Check.Rows.Count - 1]["จำนวนวัน"] = numberDay.ToString();
                    }
                    if (sum[0] == dayout)
                        break;
                    sum[0]++;
                }

            }

        }
        private void button101_Click(object sender, EventArgs e)
        {
            if (button101.BackColor == Color.LawnGreen)
            {
                int Chk = 0;
                button101.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "101" == indata.Rows[i]["number_room"].ToString())
                    {
                        Chk++;
                    }
                    numberroom = "101";
                    roomRate = "2500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "101", "2500", "");
                    Addtime(numberroom, roomRate);

                }
                if (Chk == indata.Rows.Count)
                {

                }
                else
                {
                    button101.BackColor = Color.LawnGreen;
                }
            }

        }
        private void button102_Click(object sender, EventArgs e)
        {
            if (button102.BackColor == Color.LawnGreen)
            {
                button102.BackColor = Color.Red;

                int Chk = 0;
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "102" == indata.Rows[i]["number_room"].ToString())
                    {
                        Chk++;
                    }
                    numberroom = "102";
                    roomRate = "2500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "102", "2500", "");
                    Addtime(numberroom, roomRate);
                }
                if (Chk == indata.Rows.Count)
                {

                }
            }
            else
            {
                button102.BackColor = Color.LawnGreen;
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (button103.BackColor == Color.LawnGreen)
            {
                button103.BackColor = Color.Red;

                int Chk = 0;
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "103" == indata.Rows[i]["number_room"].ToString())
                    {
                        Chk++;
                    }
                    numberroom = "103";
                    roomRate = "2500";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "103", "2500", "");
                    Addtime(numberroom, roomRate);
                }
                if (Chk == indata.Rows.Count)
                {

                }
            }
            else
            {
                button103.BackColor = Color.LawnGreen;
            }
        }

        private void button201_Click(object sender, EventArgs e)
        {
            if (button201.BackColor == Color.LawnGreen)
            {
                button201.BackColor = Color.Red;

                int Chk = 0;
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "201" == indata.Rows[i]["number_room"].ToString())
                    {
                        Chk++;
                    }
                    numberroom = "201";
                    roomRate = "3000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "201", "3000", "");
                    Addtime(numberroom, roomRate);
                }
                if (Chk == indata.Rows.Count)
                {

                }
            }
            else
            {
                button201.BackColor = Color.LawnGreen;
            }
        }

        private void button202_Click(object sender, EventArgs e)
        {
            if (button202.BackColor == Color.LawnGreen)
            {
                button202.BackColor = Color.Red;

                int Chk = 0;
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "202" == indata.Rows[i]["number_room"].ToString())
                    {
                        Chk++;
                    }
                    numberroom = "202";
                    roomRate = "3000";
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "202", "3000", "");
                    Addtime(numberroom, roomRate);
                }
                if (Chk == indata.Rows.Count)
                {

                }
            }
            else
            {
                button202.BackColor = Color.LawnGreen;
            }
        }

        private void button203_Click(object sender, EventArgs e)
        {
            if (button203.BackColor == Color.LawnGreen)
            {
                button203.BackColor = Color.Red;

                int Chk = 0;
                button101.BackColor = Color.Red;
                for (int i = 0; i < indata.Rows.Count; i++)
                {
                    if (dateTimePicker1.Value.ToShortDateString() == indata.Rows[i][0].ToString() && "203" == indata.Rows[i]["number_room"].ToString())
                    {
                        Chk++;
                    }
                    Check.Rows.Add(dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.ToShortDateString(), "203", "3000", "");
                    numberroom = "203";
                    roomRate = "3000";
                    Addtime(numberroom, roomRate);
                }
                if (Chk == indata.Rows.Count)
                {

                }
            }
            else
            {
                button203.BackColor = Color.LawnGreen;
            }
        }
        private void button9_Click_1(object sender, EventArgs e)
        {
            Button btnNextForm = new Button();
            btnNextForm.Text = "Next Form";
            btnNextForm.Location = new Point(100, 100);
            this.Controls.Add(btnNextForm);
        }
        public void btnNextForm_Click(object sender, EventArgs e)
        {
            {
                fm6 form = new fm6();
                form.Show();
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public String txt;
        private void From2_Load5(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
