using System;

namespace CommandLineSudoku {

    public class SudokuPuzzleFactory {

        // CONSTANTS
        private const int maxValueGeneratorAttempts = 100;

        // METHODS
        public SudokuPuzzle CreateSudokuPuzzle(SudokuGame.Difficulty difficulty) {
            SudokuPuzzle puzzle = initSudokuGrid();
            return decorateSudokuPuzzle(difficulty, puzzle);
        }

        private SudokuPuzzle attemptToInitSudokuGrid() {
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
                        puzzle.Rows[x].ContainsNumber(number) ||
                        puzzle.Columns[y].ContainsNumber(number) ||
                        puzzle.Blocks[bx,by].ContainsNumber(number)
                    );
                    
                    SudokuCell c = new SudokuCell(puzzle, number);
                    puzzle.Grid[x,y] = c;
                    puzzle.Rows[x].Cells[y] = c;
                    puzzle.Columns[y].Cells[x] = c;
                    puzzle.Blocks[bx,by].Cells[cx,cy] = c;
                }
            }

            return puzzle;
        }

        private SudokuPuzzle initSudokuGrid() {
            SudokuPuzzle puzzle = null;

            do puzzle = attemptToInitSudokuGrid();
            while( puzzle == null ); 

            return puzzle;
        }

        private SudokuPuzzle decorateSudokuPuzzle(SudokuGame.Difficulty difficulty, SudokuPuzzle puzzle){
            int x, y, counter = 0;
            int valuesToHide = getValuesToHide(difficulty);
            Random rand = new Random();

            do {
                x = rand.Next(0,9);
                y = rand.Next(0,9);

                if(puzzle.Grid[x,y].IsEditable) continue;

                puzzle.Grid[x,y].IsEditable = true;
                puzzle.DecValues();
                counter ++;
            }
            while(counter < valuesToHide);

            return puzzle;
        }

        private int getValuesToHide(SudokuGame.Difficulty difficulty) {
            int valuesToHide = 0;
            switch(difficulty) {
                case SudokuGame.Difficulty.Easy : valuesToHide = (int) (81 * 0.4); break;
                case SudokuGame.Difficulty.Medium : valuesToHide = (int) (81 * 0.6); break; 
                case SudokuGame.Difficulty.Hard : valuesToHide = (int) (81 * 0.75); break; 
            }
            return valuesToHide;
        }
    }
}