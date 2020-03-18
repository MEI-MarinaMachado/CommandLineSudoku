using System;
using System.Text;

namespace CommandLineSudoku {

    public class SudokuColumn : ISudokuComponent {

        // CONSTRUCTORS
        public SudokuColumn(int length) {
            this.Length = length;
            this.Cells = new SudokuCell[length];
        } 

        // PROPERTIES
        public SudokuCell[] Cells { get; set; }
        public int Length { get; private set; }

        // METHODS
        public bool ContainsValue(int value) {
            return Array.Exists(Cells, c =>  c != null && c.Value == value);
        }

        // OBJECT OVERRIDES
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            foreach(SudokuCell c in Cells) {
                sb.Append(SudokuPrint.HorizontalDivider);
                sb.Append(SudokuPrint.NewLine);
                sb.Append(c);
                sb.Append(SudokuPrint.NewLine);
            }
            sb.Append(SudokuPrint.HorizontalDivider);
            sb.Append(SudokuPrint.NewLine);

            return sb.ToString();
        }
    }
}