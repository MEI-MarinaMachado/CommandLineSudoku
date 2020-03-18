using System;

namespace CommandLineSudoku {
    class Program {
        static void Main(string[] args) {

            SudokuPuzzleFactory puzzleFactory = new SudokuPuzzleFactory();
            SudokuPuzzle p = puzzleFactory.CreateSudokuPuzzle();

            Console.WriteLine(p);
        }
    }
}
