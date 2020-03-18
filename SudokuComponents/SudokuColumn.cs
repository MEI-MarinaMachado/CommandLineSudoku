using System;

namespace CommandLineSudoku {

    public class SudokuColumn : ISudokuComponent {

        // CONSTRUCTORS
        public SudokuColumn() {
            this.Cells = new SudokuCell[9];
        } 

        // PROPERTIES
        public SudokuCell[] Cells { get; set; }

        // METHODS
        public bool ContainsValue(int value) {
            return Array.Exists(Cells, c =>  c != null && c.Value == value);
        }
    }
}