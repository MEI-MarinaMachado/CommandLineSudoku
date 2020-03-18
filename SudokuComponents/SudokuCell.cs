namespace CommandLineSudoku {

    public class SudokuCell {

        // CONSTRUCTORS
        public SudokuCell(int value) {
            this.Value = value;
        } 

        // PROPERTIES
        public int Value { get; set; }

        // METHOD OVERRIDES
        public override string ToString() { return $"{Value}"; }

    }
}