namespace ระบบจองโรงแรม
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
            button101 = new Button();
            button102 = new Button();
            button103 = new Button();
            button201 = new Button();
            button202 = new Button();
            button203 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnNextForm = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 33);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "เลือกห้องพัก";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(729, 89);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "ห้องว่าง";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(729, 136);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "ห้องไม่ว่าง";
            button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 94);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "วันเข้า-วันออก";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(145, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 89);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 5;
            label3.Text = "-";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(422, 89);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // button101
            // 
            button101.Location = new Point(6, 26);
            button101.Name = "button101";
            button101.Size = new Size(48, 29);
            button101.TabIndex = 7;
            button101.Text = "101";
            button101.UseVisualStyleBackColor = true;
            button101.Click += button101_Click;
            // 
            // button102
            // 
            button102.Location = new Point(101, 26);
            button102.Name = "button102";
            button102.Size = new Size(48, 29);
            button102.TabIndex = 8;
            button102.Text = "102";
            button102.UseVisualStyleBackColor = true;
            button102.Click += button102_Click;
            // 
            // button103
            // 
            button103.Location = new Point(196, 26);
            button103.Name = "button103";
            button103.Size = new Size(48, 29);
            button103.TabIndex = 9;
            button103.Text = "103";
            button103.UseVisualStyleBackColor = true;
            button103.Click += button103_Click;
            // 
            // button201
            // 
            button201.Location = new Point(7, 26);
            button201.Name = "button201";
            button201.Size = new Size(48, 29);
            button201.TabIndex = 10;
            button201.Text = "201";
            button201.UseVisualStyleBackColor = true;
            button201.Click += button201_Click;
            // 
            // button202
            // 
            button202.Location = new Point(102, 26);
            button202.Name = "button202";
            button202.Size = new Size(48, 29);
            button202.TabIndex = 11;
            button202.Text = "202";
            button202.UseVisualStyleBackColor = true;
            button202.Click += button202_Click;
            // 
            // button203
            // 
            button203.Location = new Point(197, 26);
            button203.Name = "button203";
            button203.Size = new Size(48, 29);
            button203.TabIndex = 12;
            button203.Text = "203";
            button203.UseVisualStyleBackColor = true;
            button203.Click += button203_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button103);
            groupBox1.Controls.Add(button101);
            groupBox1.Controls.Add(button102);
            groupBox1.Location = new Point(145, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 78);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "ห้องธรรมดา";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button203);
            groupBox2.Controls.Add(button201);
            groupBox2.Controls.Add(button202);
            groupBox2.Location = new Point(422, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 77);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "ห้องเซอร์วิส";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._338738333_726222929229800_5113679888180872822_n;
            pictureBox1.Location = new Point(145, 257);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._2;
            pictureBox2.Location = new Point(422, 257);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 143);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // btnNextForm
            // 
            btnNextForm.Location = new Point(729, 371);
            btnNextForm.Name = "btnNextForm";
            btnNextForm.Size = new Size(94, 29);
            btnNextForm.TabIndex = 17;
            btnNextForm.Text = "ตกลง";
            btnNextForm.UseVisualStyleBackColor = true;
            btnNextForm.Click += btnNextForm_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 450);
            Controls.Add(btnNextForm);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Button button101;
        private Button button102;
        private Button button103;
        private Button button201;
        private Button button202;
        private Button button203;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnNextForm;

        public EventHandler Form5_Load { get; private set; }
        public EventHandler Form_Load { get; private set; }
    }
}