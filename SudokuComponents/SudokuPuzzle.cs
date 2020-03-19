namespace CommandLineSudoku {

    public class SudokuPuzzle {

        // CONSTRUCTORS
        internal SudokuPuzzle() {
            this.Grid = new SudokuCell[9,9]; 
            this.Rows = new SudokuRow[9];
            this.Columns = new SudokuColumn[9];
            this.Blocks = new SudokuBlock[3,3];

            this.Errors = 0;
            this.Values = 81;

            for(int i = 0; i < 9; i++)
                Rows[i] = new SudokuRow();

            for(int i = 0; i < 9; i++)
                Columns[i] = new SudokuColumn();

            for(int y = 0; y < 3; y++)
                for(int x = 0; x < 3; x++)
                    Blocks[x,y] = new SudokuBlock();

        }

        // PROPERTIES
        public SudokuCell[,] Grid { get; private set; }
        public SudokuRow[] Rows { get; private set; }
        public SudokuColumn[] Columns { get; private set; }
        public SudokuBlock[,] Blocks { get; private set; }
        public int Errors { get; private set; }
        public int Values { get; private set; }
        public bool IsComplete { get { return Values == 81; } }
        public bool HasErrors { get { return Errors > 0; } }

        // METHODS
        public void IncErrors() { Errors++; }
        public void DecErrors() { Errors--; }
        public void IncValues() { Values++; }
        public void DecValues() { Values--; }
    }
}