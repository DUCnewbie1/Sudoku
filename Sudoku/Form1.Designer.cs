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
            this.pnMatrix = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
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
            this.btnSolve.Location = new System.Drawing.Point(130, 18);
            this.btnSolve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(112, 35);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 688);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnMatrix);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMatrix;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnSolve;
    }
}

