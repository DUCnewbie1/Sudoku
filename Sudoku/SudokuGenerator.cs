using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            int count = 36;

            while (count > 0)
            {
                int row = random.Next(9);
                int col = random.Next(9);
                int num = random.Next(1, 10);

                if (board[row, col] == 0 && solver.IsValid(row, col, num))
                {
                    board[row, col] = num;
                    count--;
                }
            }

            return board;
        }
    }

}
