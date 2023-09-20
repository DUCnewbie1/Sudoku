using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        private Button[,] sudokuButtons = new Button[9, 9];
        private int seconds = 0;
        private int minutes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMatrix matrixCreator = new CreateMatrix(pnMatrix, sudokuButtons);
            matrixCreator.createMatrix();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            pnMatrix.Controls.Clear();
            CreateMatrix matrixCreator = new CreateMatrix(pnMatrix, sudokuButtons);
            matrixCreator.createMatrix();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            // Tạo một mảng 2 chiều để lưu trữ giá trị của các ô Sudoku
            int[,] board = new int[9, 9];

            // Đọc giá trị từ các nút Sudoku và lưu vào mảng
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudokuButtons[i, j].BackColor == Color.BurlyWood && int.TryParse(sudokuButtons[i, j].Text, out int num))
                    {
                        board[i, j] = num;
                    }
                    else
                    {
                        board[i, j] = 0;
                    }
                }
            }

            // Tạo một đối tượng SudokuSolver mới với bảng Sudoku hiện tại
            SudokuSolver solver = new SudokuSolver(board);

            // Giải quyết Sudoku
            if (solver.Solve())
            {
                // Nếu giải quyết thành công, cập nhật các nút Sudoku với giá trị giải quyết
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        sudokuButtons[i, j].Text = solver.GetBoard()[i, j].ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không thể giải quyết bảng Sudoku này.");
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int[,] board = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (int.TryParse(sudokuButtons[i, j].Text, out int num))
                    {
                        board[i, j] = num;
                    }
                }
            }

            SudokuSolver solver = new SudokuSolver(board);
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudokuButtons[i, j].BackColor != Color.BurlyWood && !string.IsNullOrEmpty(sudokuButtons[i, j].Text))
                    {
                        if (solver.IsValid(i, j, board[i, j]))
                        {
                            sudokuButtons[i, j].BackColor = Color.LightGreen;
                        }
                        else
                        {
                            sudokuButtons[i, j].BackColor = Color.Red;
                        }
                    }
                }
            }
            timer.Interval = 5000; // 4000 ms = 4 s
            timer.Tick += timer_Tick;
            timer.Start();
            CheckCompletion();
        }
        private void CheckCompletion()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Nếu có bất kỳ ô trống nào, trả về false
                    if (string.IsNullOrEmpty(sudokuButtons[i, j].Text) || sudokuButtons[i, j].BackColor == Color.Red)
                    {
                        return;
                    }
                }
            }
            timerDemPhut.Stop();
            MessageBox.Show($"Chúc mừng, bạn đã hoàn thành Sudoku trong {labelTime.Text}!");
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (sudokuButtons[i, j].BackColor != Color.BurlyWood)
                    {
                        sudokuButtons[i, j].BackColor = SystemColors.ControlLight;
                    }
                }
            }
            timer.Stop();
        }
        private void timerDemPhut_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            labelTime.Text = $"{minutes}:{seconds:D2}";
        }
    }
}
