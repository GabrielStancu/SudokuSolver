using SudokuSolver.Data;

namespace SudokuSolver.Workers
{
    class SudokuMapper
    {
        public SudokuMap Find(int givenRow, int givenCol)
        {
            SudokuMap sudokuMap = new SudokuMap();

            sudokuMap.StartRow = givenRow - givenRow % 3;
            sudokuMap.StartCol = givenCol - givenCol % 3;

            return sudokuMap;
        }
    }
}
