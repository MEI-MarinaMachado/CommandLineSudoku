using System.Text;

namespace CommandLineSudoku {

    public class SudokuPuzzle {

        private const int rowLength = 9;
        private const int columnLength = 9;
        private const int blockLength = 3;

        // CONSTRUCTORS
        public SudokuPuzzle() {
            this.Grid = new SudokuCell[rowLength,columnLength]; 
            this.Rows = new SudokuRow[rowLength];
            this.Columns = new SudokuColumn[columnLength];
            this.Blocks = new SudokuBlock[blockLength,blockLength];

            for(int i = 0; i < rowLength; i++)
                Rows[i] = new SudokuRow(rowLength);

            for(int i = 0; i < columnLength; i++)
                Columns[i] = new SudokuColumn(columnLength);

            for(int y = 0; y < blockLength; y++)
                for(int x = 0; x < blockLength; x++)
                    Blocks[x,y] = new SudokuBlock(blockLength);

        }

        // PROPERTIES
        public SudokuCell[,] Grid { get; private set; }
        public SudokuRow[] Rows { get; private set; }
        public SudokuColumn[] Columns { get; private set; }
        public SudokuBlock[,] Blocks { get; private set; }

        // OBJECT OVERRIDES
        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            for(int y = 0; y < columnLength; y ++) {
                sb.Append(SudokuPrint.HorizontalLine);

                sb.Append(SudokuPrint.NewLine);
                for(int x = 0; x < rowLength; x ++) {
                    sb.Append(SudokuPrint.VerticalDivider);
                    sb.Append(Grid[x,y]);
                }
                sb.Append(SudokuPrint.VerticalDivider);
                sb.Append(SudokuPrint.NewLine);
            }
            sb.Append(SudokuPrint.HorizontalLine);

            return sb.ToString();
        }
    }
}