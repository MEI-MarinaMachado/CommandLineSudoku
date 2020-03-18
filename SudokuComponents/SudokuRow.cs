using System;

namespace CommandLineSudoku {

    public class SudokuRow : ISudokuComponent {

        // CONSTRUCTORS
        public SudokuRow() {
            this.Cells = new SudokuCell[9];
        } 

        // PROPERTIES
        public SudokuCell[] Cells { get; private set; }

        // METHODS
        public bool ContainsValue(int value) {
            return Array.Exists(Cells, c => c != null && c.Value == value);
        }
    }
}