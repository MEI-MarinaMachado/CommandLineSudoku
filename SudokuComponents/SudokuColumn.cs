using System;

namespace CommandLineSudoku {

    public class SudokuColumn {

        // CONSTRUCTORS
        internal SudokuColumn() {
            this.Cells = new SudokuCell[9];
        } 

        // PROPERTIES
        internal SudokuCell[] Cells { get; set; }

        // METHODS
        public bool ContainsNumber(int number) {
            return Array.Exists(Cells, c =>  c != null && c.Number == number);
        }
    }
}