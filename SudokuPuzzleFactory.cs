using System;

namespace CommandLineSudoku {

    public class SudokuPuzzleFactory {

        // ENUMS
        public enum SudokuDifficulty{ 
            Easy,
            Medium,
            Hard
        }

        // FIELDS
        private static int maxValueGeneratorAttempts = 100;

        // METHODS
        public SudokuPuzzle CreateSudokuPuzzle() {
            return CreateSudokuPuzzle(SudokuDifficulty.Easy);
        }

        public SudokuPuzzle CreateSudokuPuzzle(SudokuDifficulty difficulty) {
            SudokuPuzzle puzzle = InitSudokuGrid();
            return DecorateSudokuPuzzle(difficulty, puzzle);
        }

        private SudokuPuzzle AttemptToInitSudokuGrid() {
            SudokuPuzzle puzzle = new SudokuPuzzle();
            Random valueGenerator = new Random();
            int number;

            for(int y = 0 ; y < 9 ; y++){
                for(int x = 0 ; x < 9 ; x++){

                    int bx = x/3, cx = x%3;
                    int by = y/3, cy = y%3;
                    int counter = 0;

                    do {
                        number = valueGenerator.Next(1,10);
                        counter++;
                        
                        if(counter == maxValueGeneratorAttempts) return null;
  
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

        private SudokuPuzzle InitSudokuGrid() {
            SudokuPuzzle puzzle = null;

            do puzzle = AttemptToInitSudokuGrid();
            while( puzzle == null ); 

            return puzzle;
        }

        private SudokuPuzzle DecorateSudokuPuzzle(SudokuDifficulty difficulty, SudokuPuzzle puzzle){
            
            int x, y, valuesToHide = 0, counter = 0;
            int totalValue = puzzle.Rows.Length * puzzle.Columns.Length;
            Random rand = new Random();

            switch(difficulty){
                case SudokuDifficulty.Easy : valuesToHide = (int) (totalValue * 0.4); break;
                case SudokuDifficulty.Medium : valuesToHide = (int) (totalValue * 0.6); break;
                case SudokuDifficulty.Hard : valuesToHide = (int) (totalValue * 0.75); break;
            }

            do {
                x = rand.Next(0,9);
                y = rand.Next(0,9);

                if(puzzle.Grid[x,y].IsVisible == false) continue;

                puzzle.Grid[x,y].IsVisible = false;
                counter ++;
            }
            while(counter < valuesToHide);

            return puzzle;
        }
    }
}