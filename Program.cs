using System;

namespace CommandLineSudoku {
    class Program {
        static void Main(string[] args) {
            
            SudokuPuzzle p = SudokuPuzzle.Generate();
            Console.WriteLine(SudokuPrinter.Print(p));

        }
    }
}
