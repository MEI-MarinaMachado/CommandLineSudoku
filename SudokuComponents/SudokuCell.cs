
namespace CommandLineSudoku {

    public class SudokuCell {
        
        // CONSTRUCTORS
        public SudokuCell(int value) {
            this.Value = value;
            this.IsVisible = true;
        } 

        // PROPERTIES
        public int Value { get; set; }
        public bool IsVisible { get; set; }

        // OBJECT OVERRIDES
        public override string ToString() {
            string s = (IsVisible) ? $"{Value}" : SudokuPrint.HiddenValue;
            return " "+s+" ";
        }
    }
}