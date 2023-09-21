namespace Sudoku
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnMatrix = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.timerDemPhut = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.Play = new System.Windows.Forms.Button();
            this.Mute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnMatrix
            // 
            this.pnMatrix.Location = new System.Drawing.Point(130, 88);
            this.pnMatrix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnMatrix.Name = "pnMatrix";
            this.pnMatrix.Size = new System.Drawing.Size(638, 560);
            this.pnMatrix.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(18, 18);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(99, 35);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(126, 18);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(112, 35);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Check.Location = new System.Drawing.Point(248, 18);
            this.Check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(99, 35);
            this.Check.TabIndex = 3;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(766, 32);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(40, 20);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "0:00";
            // 
            // timerDemPhut
            // 
            this.timerDemPhut.Enabled = true;
            this.timerDemPhut.Interval = 1000;
            this.timerDemPhut.Tick += new System.EventHandler(this.timerDemPhut_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thời gian:";
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "volume.ico");
            this.IconList.Images.SetKeyName(1, "volume-mute.ico");
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.Control;
            this.Play.FlatAppearance.BorderSize = 0;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.ImageIndex = 0;
            this.Play.ImageList = this.IconList;
            this.Play.Location = new System.Drawing.Point(9, 612);
            this.Play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(112, 35);
            this.Play.TabIndex = 6;
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Mute
            // 
            this.Mute.FlatAppearance.BorderSize = 0;
            this.Mute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mute.ImageIndex = 1;
            this.Mute.ImageList = this.IconList;
            this.Mute.Location = new System.Drawing.Point(9, 612);
            this.Mute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(112, 35);
            this.Mute.TabIndex = 7;
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 688);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnMatrix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Sudoku_Nhom7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMatrix;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timerDemPhut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList IconList;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Mute;
    }
}

