using System;

namespace SudokuSolver.Workers
{
    class SudokuBoardDisplayer
    {
        public void Display(string title, int[,] sudokuBoard)
        {
            if(!title.Equals(string.Empty))
            {
                Console.WriteLine($"{title} {Environment.NewLine}");
            }

            for(int row = 0; row < sudokuBoard.GetLength(0); row++)
            {
                Console.Write("|");
                for(int col = 0; col < sudokuBoard.GetLength(1); col++)
                {
                    int cellValue = sudokuBoard[row, col];
                    Console.Write($"{(cellValue == 0 ? " " : cellValue.ToString())}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
