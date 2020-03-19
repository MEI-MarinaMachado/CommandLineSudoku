using System;

namespace CommandLineSudoku {

    public class SudokuRow {

        // CONSTRUCTORS
        internal SudokuRow() {
            this.Cells = new SudokuCell[9];
        } 

        // PROPERTIES
        internal SudokuCell[] Cells { get; private set; }

        // METHODS
        public bool ContainsNumber(int number) {
            return Array.Exists(Cells, c => c != null && c.Number == number);
        }
    }
}