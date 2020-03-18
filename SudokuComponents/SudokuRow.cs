using System;
using System.Text;

namespace CommandLineSudoku {

    public class SudokuRow : ISudokuComponent {

        // CONSTRUCTORS
        public SudokuRow(int length) {
            this.Length = Length;
            this.Cells = new SudokuCell[length];
        } 

        // PROPERTIES
        public SudokuCell[] Cells { get; private set; }
        public int Length { get; private set; }

        // METHODS
        public bool ContainsValue(int value) {
            return Array.Exists(Cells, c => c != null && c.Value == value);
        }

        // OBJECT OVERRIDES
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            foreach(SudokuCell c in Cells) {
                sb.Append(SudokuPrint.VerticalDivider);
                sb.Append(c);
            }
            sb.Append(SudokuPrint.VerticalDivider);
            sb.Append(SudokuPrint.NewLine);

            return sb.ToString();
        }
    }
}