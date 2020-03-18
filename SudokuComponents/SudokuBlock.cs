using System;

namespace CommandLineSudoku {
    public class SudokuBlock : ISudokuComponent {

        // CONSTRUCTORS
        public SudokuBlock() {
            this.Cells = new SudokuCell[3,3];
        } 

        // PROPERTIES
        public SudokuCell[,] Cells { get; set; }

        // METHODS
        public bool ContainsValue(int value) {
            for(int y = 0; y < 3; y++) {
                for(int x = 0; x < 3; x++) {
                    SudokuCell c = Cells[x,y];
                    if(c != null && c.Value == value) return true;
                }
            }
            return false;
        }
    }
}