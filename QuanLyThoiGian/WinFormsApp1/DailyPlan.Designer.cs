namespace WinFormsApp1
{
    partial class DailyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlan));
            pnJob = new Panel();
            btnPreviousDay = new Button();
            btnNextDay = new Button();
            dtpkDate = new DateTimePicker();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            pnJob.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnJob
            // 
            pnJob.BackColor = Color.LightGray;
            pnJob.Controls.Add(button3);
            pnJob.Controls.Add(btnPreviousDay);
            pnJob.Controls.Add(btnNextDay);
            pnJob.Controls.Add(dtpkDate);
            pnJob.Location = new Point(-2, 0);
            pnJob.Margin = new Padding(2);
            pnJob.Name = "pnJob";
            pnJob.Size = new Size(967, 34);
            pnJob.TabIndex = 1;
            // 
            // btnPreviousDay
            // 
            btnPreviousDay.BackColor = Color.DarkGray;
            btnPreviousDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreviousDay.Location = new Point(278, 4);
            btnPreviousDay.Margin = new Padding(2);
            btnPreviousDay.Name = "btnPreviousDay";
            btnPreviousDay.Size = new Size(78, 27);
            btnPreviousDay.TabIndex = 3;
            btnPreviousDay.Text = "Hôm qua ";
            btnPreviousDay.UseVisualStyleBackColor = false;
            btnPreviousDay.Click += btnPreviousDay_Click;
            // 
            // btnNextDay
            // 
            btnNextDay.BackColor = Color.DarkGray;
            btnNextDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextDay.Location = new Point(617, 4);
            btnNextDay.Margin = new Padding(2);
            btnNextDay.Name = "btnNextDay";
            btnNextDay.Size = new Size(78, 27);
            btnNextDay.TabIndex = 2;
            btnNextDay.Text = "Ngày mai ";
            btnNextDay.UseVisualStyleBackColor = false;
            btnNextDay.Click += btnNextDay_Click_1;
            // 
            // dtpkDate
            // 
            dtpkDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dtpkDate.Location = new Point(380, 7);
            dtpkDate.Margin = new Padding(2);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(213, 23);
            dtpkDate.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pnJob);
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 372);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(738, 334);
            button2.Name = "button2";
            button2.Size = new Size(75, 38);
            button2.TabIndex = 4;
            button2.Text = "Chỉnh sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(819, 334);
            button1.Name = "button1";
            button1.Size = new Size(75, 38);
            button1.TabIndex = 3;
            button1.Text = "Trở lại ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(891, 299);
            dataGridView1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(3, 4);
            button3.Name = "button3";
            button3.Size = new Size(92, 30);
            button3.TabIndex = 4;
            button3.Text = "Thêm sự kiện";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // DailyPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 376);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "DailyPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lịch trong ngày ";
            FormClosing += DailyPlan_FormClosing;
            Load += DailyPlan_Load;
            pnJob.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnJob;
        private Button btnPreviousDay;
        private Button btnNextDay;
        private DateTimePicker dtpkDate;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}