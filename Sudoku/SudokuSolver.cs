using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class SudokuSolver
    {
        private int[,] board; // Biểu diễn bảng Sudoku

        // Hàm khởi tạo cho lớp SudokuSolver
        public SudokuSolver(int[,] board)
        {
            this.board = board; // Gán bảng Sudoku cho thuộc tính board
        }

        // Phương thức giải quyết Sudoku
        public bool Solve()
        {
            // Tạo một danh sách các số từ 1 đến 9
            List<int> numbers = new List<int>();
            for (int num = 1; num <= 9; num++)
            {
                numbers.Add(num);
            }

            // Xáo trộn danh sách số để có thứ tự ngẫu nhiên
            Random rng = new Random();
            numbers = numbers.OrderBy(x => rng.Next()).ToList();

            // Duyệt qua từng hàng và cột của bảng
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // Kiểm tra nếu ô hiện tại chưa được điền số
                    if (board[row, col] == 0)
                    {
                        foreach (int num in numbers)
                        {
                            // Kiểm tra nếu số này hợp lệ để điền vào ô
                            if (IsValid(row, col, num))
                            {
                                board[row, col] = num; // Điền số vào ô

                                // Tiếp tục giải quyết bảng, nếu giải quyết thành công thì trả về true
                                if (Solve())
                                {
                                    return true;
                                }
                                else
                                {
                                    board[row, col] = 0; // Quay lui và thử số khác
                                }
                            }
                        }

                        return false; // Không có số nào hợp lệ để điền vào ô này
                    }
                }
            }

            return true; // Đã giải quyết xong bảng Sudoku
        }

        public bool IsValid(int row, int col, int num)
        {
            // Kiểm tra hàng
            for (int i = 0; i < 9; i++)
                if (i != col && board[row, i] == num)
                    return false;

            // Kiểm tra cột
            for (int i = 0; i < 9; i++)
                if (i != row && board[i, col] == num)
                    return false;

            // Kiểm tra hộp 3x3
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if ((i + startRow != row || j + startCol != col) && board[i + startRow, j + startCol] == num)
                        return false;

            return true; // Số này hợp lệ để điền vào ô
        }

        public int[,] GetBoard()
        {
            return board;
        }
    }
}
