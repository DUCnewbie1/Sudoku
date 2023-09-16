using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public class SudokuGenerator
    {
        private SudokuSolver solver;
        private Random random;

        public SudokuGenerator()
        {
            this.solver = new SudokuSolver(new int[9, 9]);
            this.random = new Random();
        }

        public int[,] Generate()
        {
            int[,] board = new int[9, 9];

            // Giải quyết ma trận Sudoku 9x9
            solver.Solve();

            // Sao chép bảng đã giải quyết vào bảng mới
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = solver.GetBoard()[i, j];
                }
            }

            //Xóa ngẫu nhiên 45 số
            int countToRemove = 45;
            Random random = new Random();

            while (countToRemove > 0)
            {
                int row = random.Next(9);
                int col = random.Next(9);

                if (board[row, col] != 0)
                {
                    board[row, col] = 0;
                    countToRemove--;
                }
            }
            return board;
        }
    }
}