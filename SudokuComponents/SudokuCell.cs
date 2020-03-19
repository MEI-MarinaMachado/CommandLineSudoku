namespace CommandLineSudoku {

    public class SudokuCell {
        // FIELDS
        private SudokuPuzzle puzzle;
        private int? input;

        // CONSTRUCTORS
        internal SudokuCell(SudokuPuzzle puzzle, int number) {
            this.Number = number;
            this.IsEditable = false;
            this.HasError = false;
            this.puzzle = puzzle;
        } 

        // PROPERTIES
        public int Number { get; private set; }
        public int? Input {
            get { return input; }
            set {
                if(!IsEditable) return;

                if(IsEmpty && value != null)  puzzle.IncValues();
                if(!IsEmpty && value == null) puzzle.DecValues();

                if(value != Number) {
                    if(HasError == false) {
                        puzzle.IncErrors();
                        HasError = true;
                    }
                    
                } else {
                    if(HasError) {
                        puzzle.DecErrors();
                        HasError = false;
                    }
                }

                input = value;
            }
        }
        public bool IsEditable { get; set; }
        public bool HasError { get; private set; }
        public bool IsEmpty { get { return IsEditable && input == null; }}

        // OBJECT OVERRIDES
        public override string ToString() {
            string s;

            if(IsEditable) s = (Input != null) ? $"{Input}" : s = $"{SudokuPrint.BlankValue}";
            else s = $"{Number}";
            
            return $" {s} ";
        }
    }
}