namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            Thoat = new Button();
            DangXuat = new Button();
            pnMatrix = new Panel();
            panel4 = new Panel();
            btnPreviours = new Button();
            btnSun = new Button();
            btnnext = new Button();
            btnSat = new Button();
            btnFri = new Button();
            btnTue = new Button();
            btnWed = new Button();
            btnThu = new Button();
            btnMon = new Button();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            HomNay = new Button();
            dtpkDate = new DateTimePicker();
            Nofity = new NotifyIcon(components);
            tmNotify = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 396);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(Thoat);
            panel3.Controls.Add(DangXuat);
            panel3.Controls.Add(pnMatrix);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(3, 32);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(770, 338);
            panel3.TabIndex = 1;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(666, 310);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(98, 25);
            Thoat.TabIndex = 4;
            Thoat.Text = "Thoát";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // DangXuat
            // 
            DangXuat.AccessibleDescription = "";
            DangXuat.Location = new Point(666, 280);
            DangXuat.Name = "DangXuat";
            DangXuat.Size = new Size(99, 25);
            DangXuat.TabIndex = 3;
            DangXuat.Text = "Đăng xuất";
            DangXuat.UseVisualStyleBackColor = true;
            DangXuat.Click += DangXuat_Click;
            // 
            // pnMatrix
            // 
            pnMatrix.AutoSize = true;
            pnMatrix.Location = new Point(88, 46);
            pnMatrix.Margin = new Padding(2);
            pnMatrix.Name = "pnMatrix";
            pnMatrix.Size = new Size(574, 287);
            pnMatrix.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnPreviours);
            panel4.Controls.Add(btnSun);
            panel4.Controls.Add(btnnext);
            panel4.Controls.Add(btnSat);
            panel4.Controls.Add(btnFri);
            panel4.Controls.Add(btnTue);
            panel4.Controls.Add(btnWed);
            panel4.Controls.Add(btnThu);
            panel4.Controls.Add(btnMon);
            panel4.Location = new Point(-3, 4);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(771, 39);
            panel4.TabIndex = 0;
            // 
            // btnPreviours
            // 
            btnPreviours.Location = new Point(5, 11);
            btnPreviours.Margin = new Padding(2);
            btnPreviours.Name = "btnPreviours";
            btnPreviours.Size = new Size(83, 28);
            btnPreviours.TabIndex = 8;
            btnPreviours.Text = "Tháng trước ";
            btnPreviours.UseVisualStyleBackColor = true;
            btnPreviours.Click += btnPreviours_Click;
            // 
            // btnSun
            // 
            btnSun.Location = new Point(582, 11);
            btnSun.Margin = new Padding(2);
            btnSun.Name = "btnSun";
            btnSun.Size = new Size(78, 28);
            btnSun.TabIndex = 7;
            btnSun.Text = "CN";
            btnSun.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(669, 11);
            btnnext.Margin = new Padding(2);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(78, 28);
            btnnext.TabIndex = 6;
            btnnext.Text = "Tháng sau ";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // btnSat
            // 
            btnSat.Location = new Point(500, 11);
            btnSat.Margin = new Padding(2);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(78, 28);
            btnSat.TabIndex = 5;
            btnSat.Text = "Th7";
            btnSat.UseVisualStyleBackColor = true;
            // 
            // btnFri
            // 
            btnFri.Location = new Point(418, 11);
            btnFri.Margin = new Padding(2);
            btnFri.Name = "btnFri";
            btnFri.Size = new Size(78, 28);
            btnFri.TabIndex = 4;
            btnFri.Text = "Th6";
            btnFri.UseVisualStyleBackColor = true;
            // 
            // btnTue
            // 
            btnTue.Location = new Point(172, 11);
            btnTue.Margin = new Padding(2);
            btnTue.Name = "btnTue";
            btnTue.Size = new Size(78, 28);
            btnTue.TabIndex = 3;
            btnTue.Text = "Th3";
            btnTue.UseVisualStyleBackColor = true;
            // 
            // btnWed
            // 
            btnWed.Location = new Point(254, 11);
            btnWed.Margin = new Padding(2);
            btnWed.Name = "btnWed";
            btnWed.Size = new Size(78, 28);
            btnWed.TabIndex = 2;
            btnWed.Text = "Th4";
            btnWed.UseVisualStyleBackColor = true;
            // 
            // btnThu
            // 
            btnThu.Location = new Point(336, 11);
            btnThu.Margin = new Padding(2);
            btnThu.Name = "btnThu";
            btnThu.Size = new Size(78, 28);
            btnThu.TabIndex = 1;
            btnThu.Text = "Th5";
            btnThu.UseVisualStyleBackColor = true;
            // 
            // btnMon
            // 
            btnMon.Location = new Point(90, 11);
            btnMon.Margin = new Padding(2);
            btnMon.Name = "btnMon";
            btnMon.Size = new Size(78, 28);
            btnMon.TabIndex = 0;
            btnMon.Text = "Th2";
            btnMon.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(HomNay);
            panel2.Controls.Add(dtpkDate);
            panel2.Location = new Point(1, 5);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(775, 33);
            panel2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(74, 0);
            button3.Name = "button3";
            button3.Size = new Size(153, 26);
            button3.TabIndex = 4;
            button3.Text = "Xem danh sách công việc";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(2, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 26);
            button2.TabIndex = 3;
            button2.Text = "Tạo sự kiện";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(654, 0);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 2;
            button1.Text = "Thông tin tài khoản";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // HomNay
            // 
            HomNay.Location = new Point(555, 0);
            HomNay.Margin = new Padding(2);
            HomNay.Name = "HomNay";
            HomNay.Size = new Size(73, 27);
            HomNay.TabIndex = 1;
            HomNay.Text = "Hôm nay ";
            HomNay.UseVisualStyleBackColor = true;
            HomNay.Click += button1_Click;
            // 
            // dtpkDate
            // 
            dtpkDate.CalendarMonthBackground = SystemColors.ScrollBar;
            dtpkDate.Location = new Point(284, 3);
            dtpkDate.Margin = new Padding(2);
            dtpkDate.Name = "dtpkDate";
            dtpkDate.Size = new Size(211, 23);
            dtpkDate.TabIndex = 0;
            // 
            // Nofity
            // 
            Nofity.Icon = (Icon)resources.GetObject("Nofity.Icon");
            Nofity.Text = "notifyIcon1";
            Nofity.Visible = true;
            // 
            // tmNotify
            // 
            tmNotify.Enabled = true;
            tmNotify.Interval = 5000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(778, 405);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Calendar";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel pnMatrix;
        private Panel panel4;
        private Panel panel2;
        private DateTimePicker dtpkDate;
        private Button btnSun;
        private Button btnnext;
        private Button btnSat;
        private Button btnFri;
        private Button btnTue;
        private Button btnWed;
        private Button btnThu;
        private Button btnMon;
        private Button HomNay;
        private Button btnPreviours;
        private Button Thoat;
        private Button DangXuat;
        private Button button1;
        private NotifyIcon Nofity;
        private System.Windows.Forms.Timer tmNotify;
        private Button button3;
        private Button button2;
    }
}