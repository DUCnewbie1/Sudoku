using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class CreateMatrix
    {
        private Panel pnMatrix;
        private Button[,] sudokuButtons;
        private SudokuGenerator generator;

        // Hàm khởi tạo cho lớp CreateMatrix
        public CreateMatrix(Panel pnMatrix, Button[,] sudokuButtons)
        {
            this.pnMatrix = pnMatrix;
            this.sudokuButtons = sudokuButtons;
            this.generator = new SudokuGenerator();
        }

        // Phương thức tạo ma trận
        public void createMatrix()
        {
            int[,] board = generator.Generate(); // Tạo bảng Sudoku với 36 số ngẫu nhiên

            int rowCount = 9; // Số hàng
            int colCount = 9; // Số cột
            int panelWidth = pnMatrix.Width;
            int panelHeight = pnMatrix.Height;

            int cellSize = Math.Min(panelWidth / colCount, panelHeight / rowCount);
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    Button button = new Button();
                    button.Width = cellSize;
                    button.Height = cellSize;
                    button.Top = row * cellSize;
                    button.Left = col * cellSize;
                    button.Text = board[row, col] == 0 ? "" : board[row, col].ToString();
                    sudokuButtons[row, col] = button;
                    pnMatrix.Controls.Add(button);

                    if ((col + 1) % 3 == 0 && col != colCount - 1)
                    {
                        DrawVerticalLine(cellSize, button.Right, button.Top, button.Bottom);
                    }

                    if ((row + 1) % 3 == 0 && row != rowCount - 1)
                    {
                        DrawHorizontalLine(cellSize, button.Left, button.Bottom, button.Right);
                    }
                }
            }
        }

        // Phương thức vẽ đường kẻ dọc
        private void DrawVerticalLine(int cellSize, int x, int top, int bottom)
        {
            Panel line = new Panel();
            line.BackColor = Color.Black;
            line.Width = 1;
            line.Height = cellSize;
            line.Location = new Point(x, top);
            pnMatrix.Controls.Add(line);
        }

        // Phương thức vẽ đường kẻ ngang
        private void DrawHorizontalLine(int cellSize, int left, int y, int right)
        {
            Panel line = new Panel();
            line.BackColor = Color.Black;
            line.Width = cellSize;
            line.Height = 1;
            line.Location = new Point(left, y);
            pnMatrix.Controls.Add(line);
        }
    }
}
