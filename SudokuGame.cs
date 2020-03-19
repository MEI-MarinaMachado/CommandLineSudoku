using System;

namespace CommandLineSudoku {

    public class SudokuGame {

        // FIELDS
        private SudokuPuzzle puzzle;

        // ENUMS
        public enum Difficulty { 
            Easy,
            Medium,
            Hard,
            Unknown
        }

        // CONSTRUCTORS
        public SudokuGame(Difficulty difficulty) {
            Console.WriteLine(SudokuPrint.GeneratingPuzzleMsg);
            SudokuPuzzleFactory factory = new SudokuPuzzleFactory();
            this.puzzle = factory.CreateSudokuPuzzle(difficulty);
        } 

        // METHODS
        public void Play() {
            Console.WriteLine(SudokuPrint.NewPuzzleMsg);
            Console.WriteLine();

            while(!puzzle.IsComplete) {
                printPuzzle();
                readInput();
                Console.WriteLine();
            }

            printPuzzle(true);

            if(puzzle.HasErrors) {
                Console.ForegroundColor = SudokuPrint.ConsoleColorError;
                Console.WriteLine(string.Format(SudokuPrint.FailurePuzzleMsg, puzzle.Errors));
            } else {
                Console.ForegroundColor = SudokuPrint.ConsoleColorValid;
                Console.WriteLine(SudokuPrint.SuccessPuzzleMsg);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        private void printPuzzle (bool printWithValidation = false) {
            Console.ForegroundColor = SudokuPrint.ConsoleColorMuted;
            Console.WriteLine("    1   2   3   4   5   6   7   8   9  ");
            Console.ResetColor();

            for(int y = 0; y < 9; y++) {

                if(y%3 != 0) Console.ForegroundColor = SudokuPrint.ConsoleColorMuted;
                Console.WriteLine("  "+SudokuPrint.HorizontalLine);
                Console.ResetColor();

                Console.ForegroundColor = SudokuPrint.ConsoleColorMuted;
                Console.Write((y+1)+" ");
                Console.ResetColor();

                for(int x = 0; x < 9; x++) {

                    if(x%3 != 0) Console.ForegroundColor = SudokuPrint.ConsoleColorMuted;
                    Console.Write(SudokuPrint.VerticalDivider);
                    Console.ResetColor();

                    SudokuCell cell = puzzle.Grid[x,y];
                    if(cell.IsEditable) {
                        if(printWithValidation) 
                            if(cell.HasError) Console.ForegroundColor = SudokuPrint.ConsoleColorError;
                            else Console.ForegroundColor = SudokuPrint.ConsoleColorValid;
                        else
                            Console.ForegroundColor = SudokuPrint.ConsoleColorInput;
                    }
                    Console.Write(puzzle.Grid[x,y]);
                    Console.ResetColor();
                }

                Console.WriteLine(SudokuPrint.VerticalDivider);
            }

             Console.WriteLine("  "+SudokuPrint.HorizontalLine);

            Console.WriteLine();
        }

        private void readInput() {
            int x = readInputAsNumber(SudokuPrint.TypeColumnMsg)-1;
            int y = readInputAsNumber(SudokuPrint.TypeRowMsg)-1;
            int number = readInputAsNumber(SudokuPrint.TypeValueMsg);

            if(puzzle.Grid[x,y].IsEditable == false) {
                Console.WriteLine(string.Format(SudokuPrint.CellErrorMsg,y+1,x+1));
                return;
            }

            puzzle.Grid[x,y].Input = number;
        }

        private int readInputAsNumber(string displayMessage){
            int? number = null;
            string input;

            do {

                Console.Write(displayMessage);
                input = Console.ReadLine();
                try {
                    number = Int32.Parse(input);
                    if( number < 1 || number > 9) number = null; 
                }
                catch(Exception e) { }

                if(number == null) Console.WriteLine(SudokuPrint.NumberErrorMsg);
            }
            while( number == null );
            
            return (int) number;
        }
    }
}