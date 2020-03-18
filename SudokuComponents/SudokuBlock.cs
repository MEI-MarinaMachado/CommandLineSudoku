using System.Text;

namespace CommandLineSudoku {

    public class SudokuBlock : ISudokuComponent {

        // CONSTRUCTORS
        public SudokuBlock(int length) {
            this.Length = length;
            this.Cells = new SudokuCell[length,length];
        } 

        // PROPERTIES
        public SudokuCell[,] Cells { get; set; }
        public int Length { get; private set; }

        // METHODS
        public bool ContainsValue(int value) {
            for(int y = 0; y < Length; y++) {
                for(int x = 0; x < Length; x++) {
                    SudokuCell c = Cells[x,y];
                    if(c != null && c.Value == value) return true;
                }
            }
            return false;
        }

        // OBJECT OVERRIDES
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            for(int x = 0 ; x < Length; x++) {
                sb.Append(SudokuPrint.HorizontalDivider);
                sb.Append(SudokuPrint.HorizontalDivider);
                sb.Append(SudokuPrint.HorizontalDivider);
                sb.Append(SudokuPrint.NewLine);

                for(int y = 0; y < Length; y ++){
                    sb.Append(SudokuPrint.VerticalDivider);
                    sb.Append(Cells[x,y]);
                }

                sb.Append(SudokuPrint.VerticalDivider);
                sb.Append(SudokuPrint.NewLine);
            }

            sb.Append(SudokuPrint.HorizontalDivider);
            sb.Append(SudokuPrint.HorizontalDivider);
            sb.Append(SudokuPrint.HorizontalDivider);

            return sb.ToString();
        }        
    }
}