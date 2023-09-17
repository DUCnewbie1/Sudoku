using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form   
    {
        private Button[,] sudokuButtons = new Button[9, 9];

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
                    if (int.TryParse(sudokuButtons[i, j].Text, out int num))
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
                // Nếu không thể giải quyết, hiển thị thông báo cho người dùng
                MessageBox.Show("Không thể giải quyết bảng Sudoku này.");
            }
        }

    }
}
