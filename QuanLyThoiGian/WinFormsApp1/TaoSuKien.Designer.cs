namespace QuanLyThoiGian
{
    partial class TaoSuKien
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
            label2 = new Label();
            labelSelectedTime = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            label3 = new Label();
            endTime = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 62);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sự kiện";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 122);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "Ngày bắt đầu";
            // 
            // labelSelectedTime
            // 
            labelSelectedTime.AutoSize = true;
            labelSelectedTime.Location = new Point(375, 149);
            labelSelectedTime.Name = "labelSelectedTime";
            labelSelectedTime.Size = new Size(99, 15);
            labelSelectedTime.TabIndex = 3;
            labelSelectedTime.Text = "Thời gian bắt đầu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(116, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(599, 314);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(518, 314);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 122);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 8;
            label5.Text = "Chọn giờ bắt đầu";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 116);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(296, 9);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 14;
            label6.Text = "Tạo sự kiện";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(480, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(116, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(599, 114);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(78, 23);
            comboBox2.TabIndex = 16;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(480, 170);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(116, 23);
            comboBox3.TabIndex = 17;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(599, 170);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(78, 23);
            comboBox4.TabIndex = 18;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 178);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 19;
            label3.Text = "Chọn giờ kết thúc";
            // 
            // endTime
            // 
            endTime.AutoSize = true;
            endTime.Location = new Point(375, 206);
            endTime.Name = "endTime";
            endTime.Size = new Size(102, 15);
            endTime.TabIndex = 20;
            endTime.Text = "Thời gian kết thúc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 178);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 21;
            label4.Text = "Ngày kết thúc";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(116, 172);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 22;
            // 
            // TaoSuKien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 349);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(endTime);
            Controls.Add(label3);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(labelSelectedTime);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TaoSuKien";
            Text = "TaoSuKien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelSelectedTime;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label3;
        private Label endTime;
        private Label label4;
        private DateTimePicker dateTimePicker2;
    }
}