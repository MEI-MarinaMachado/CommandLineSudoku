namespace CommandLineSudoku {

    public class SudokuBlock {

        // CONSTRUCTORS
        public SudokuBlock() {
            this.Cells = new SudokuCell[3,3];
        } 

        // PROPERTIES
        public SudokuCell[,] Cells { get; set; }

        // METHODS
        public bool ContainsNumber(int number) {
            for(int y = 0; y < 3; y++) {
                for(int x = 0; x < 3; x++) {
                    SudokuCell c = Cells[x,y];
                    if(c != null && c.Number == number) return true;
                }
            }
            return false;
        } 
    }
}