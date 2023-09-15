﻿using System;
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
            // Duyệt qua từng hàng và cột của bảng
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    // Kiểm tra nếu ô hiện tại chưa được điền số
                    if (board[row, col] == 0)
                    {
                        // Thử điền từng số từ 1 đến 9 vào ô
                        for (int num = 1; num <= 9; num++)
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
                if (board[row, i] == num )
                    return false;

            // Kiểm tra cột
            for (int i = 0; i < 9; i++)
            {
                if (board[i, col] == num )
                {
                   return false;
                }          
            }
                

            // Kiểm tra hộp 3x3 mà ô này thuộc về
            int startRow = row - row % 3;
            int startCol = col - col % 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (board[i + startRow, j + startCol] == num)
                        return false;

            return true; // Số này hợp lệ để điền vào ô
        }
    }

}
