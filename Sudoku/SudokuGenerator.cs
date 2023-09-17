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

            int seed = Guid.NewGuid().GetHashCode();
            Random random = new Random(seed);

            SudokuSolver solver = new SudokuSolver(board); // Tạo một SudokuSolver mới với ma trận ban đầu

            solver.Solve();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {   
                    board[i, j] = solver.GetBoard()[i, j];
                }
            }

            int countToRemove = random.Next(41, 62);
            
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