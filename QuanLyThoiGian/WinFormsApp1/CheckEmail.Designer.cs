namespace QuanLyThoiGian
{
    partial class CheckEmail
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
            txt_Email = new TextBox();
            label2 = new Label();
            XacNhan = new Button();
            Huy = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 39);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(113, 36);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(162, 23);
            txt_Email.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(134, 10);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Mời nhập email";
            // 
            // XacNhan
            // 
            XacNhan.ForeColor = Color.Black;
            XacNhan.Location = new Point(113, 80);
            XacNhan.Name = "XacNhan";
            XacNhan.Size = new Size(75, 23);
            XacNhan.TabIndex = 3;
            XacNhan.Text = "Xác nhận";
            XacNhan.UseVisualStyleBackColor = true;
            XacNhan.Click += XacNhan_Click;
            // 
            // Huy
            // 
            Huy.Location = new Point(200, 80);
            Huy.Name = "Huy";
            Huy.Size = new Size(75, 23);
            Huy.TabIndex = 4;
            Huy.Text = "Hủy";
            Huy.UseVisualStyleBackColor = true;
            Huy.Click += Huy_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(113, 62);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên Email?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // CheckEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 110);
            Controls.Add(linkLabel1);
            Controls.Add(Huy);
            Controls.Add(XacNhan);
            Controls.Add(label2);
            Controls.Add(txt_Email);
            Controls.Add(label1);
            Name = "CheckEmail";
            Text = "CheckEmail";
            FormClosing += CheckEmail_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_Email;
        private Label label2;
        private Button XacNhan;
        private Button Huy;
        private LinkLabel linkLabel1;
    }
}