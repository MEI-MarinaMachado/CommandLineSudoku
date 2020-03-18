using System.Text;

namespace CommandLineSudoku {
    public static class SudokuPrinter {

        // FIELDS
        public static string newLine = "\n";

        // METHODS
        public static string Print(SudokuRow row) {
            StringBuilder sb = new StringBuilder();

            foreach(SudokuCell c in row.Cells) {
                sb.Append(" |");
                sb.Append(c);
            }
            sb.Append(" |");
            sb.Append(newLine);

            return sb.ToString();
        }

        public static string Print(SudokuColumn row) {
            StringBuilder sb = new StringBuilder();

            foreach(SudokuCell c in row.Cells) {
                sb.Append(" ---");
                sb.Append(newLine);
                sb.Append(" ");
                sb.Append(c);
                sb.Append(" ");
                sb.Append(newLine);
            }
            sb.Append(" ---");
            sb.Append(newLine);

            return sb.ToString();
        }

        public static string Print(SudokuBlock block) {
            StringBuilder sb = new StringBuilder();

            for(int x = 0 ; x < 3; x++) {
                sb.Append(" --- --- ---");
                sb.Append(newLine);
                for(int y = 0; y < 3; y ++){
                    sb.Append("|");
                    sb.Append(" ");
                    sb.Append(block.Cells[x,y]);
                    sb.Append(" ");
                }
                sb.Append("|");
                sb.Append(newLine);
            }

            return sb.ToString();
        }

        public static string Print(SudokuPuzzle puzzle) {
            StringBuilder sb = new StringBuilder();

            for(int y = 0; y < 9; y ++) {
                sb.Append(" --- --- --- --- --- --- --- --- --- ");
                sb.Append(newLine);
                for(int x = 0; x < 9; x ++) {
                    sb.Append("| ");
                    sb.Append(puzzle.Grid[x,y]);
                    sb.Append(" ");
                }
                sb.Append("|");
                sb.Append(newLine);
            }
            sb.Append(" --- --- --- --- --- --- --- --- --- ");

            return sb.ToString();
        }
    }
}