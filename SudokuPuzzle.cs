using System;

namespace CommandLineSudoku {
    public class SudokuPuzzle {

        // FIELDS
        private static int maxRandom = 100;
        private static int maxGenerateTries = 1000;

        // CONSTRUCTORS
        private SudokuPuzzle() {
            this.Grid = new SudokuCell[9,9]; 
            this.Rows = new SudokuRow[9];
            this.Columns = new SudokuColumn[9];
            this.Blocks = new SudokuBlock[3,3];

            for(int i = 0; i < 9; i++){
                Rows[i] = new SudokuRow();
                Columns[i] = new SudokuColumn();
            }

            for(int y = 0; y < 3; y++){
                for(int x = 0; x < 3; x++){
                    Blocks[x,y] = new SudokuBlock();
                }
            }
        }

        // PROPERTIES
        public SudokuCell[,] Grid { get; private set; }
        public SudokuRow[] Rows { get; private set; }
        public SudokuColumn[] Columns { get; private set; }
        public SudokuBlock[,] Blocks { get; private set; }

        // STATIC METHODS
        public static SudokuPuzzle Generate() {
            SudokuPuzzle puzzle = null;
            int counter = 0;

            do {
                puzzle = SudokuPuzzle.TryGenerate();
                counter ++;

                if(counter == maxGenerateTries) throw new Exception();
            }
            while( puzzle == null ); 
            return puzzle;
        }

        private static SudokuPuzzle TryGenerate() {
            SudokuPuzzle puzzle = new SudokuPuzzle();
            Random rand = new Random();
            int number;

            for(int y = 0 ; y < 9 ; y++){
                for(int x = 0 ; x < 9 ; x++){

                    int bx = x/3, cx = x%3;
                    int by = y/3, cy = y%3;
                    int counter = 0;

                    do {
                        number = rand.Next(1,10);
                        counter++;
                        
                        if(counter == maxRandom) return null;
  
                    } while(
                        puzzle.Rows[x].ContainsValue(number) ||
                        puzzle.Columns[y].ContainsValue(number) ||
                        puzzle.Blocks[bx,by].ContainsValue(number)
                    );
                    
                    SudokuCell c = new SudokuCell(number);
                    puzzle.Grid[x,y] = c;
                    puzzle.Rows[x].Cells[y] = c;
                    puzzle.Columns[y].Cells[x] = c;
                    puzzle.Blocks[bx,by].Cells[cx,cy] = c;
                }
            }

            return puzzle;
        }
    }
}