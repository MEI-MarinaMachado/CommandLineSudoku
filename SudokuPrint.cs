using System;

namespace CommandLineSudoku {
    internal static class SudokuPrint {

        public const ConsoleColor ConsoleColorMuted = ConsoleColor.White;
        public const ConsoleColor ConsoleColorError = ConsoleColor.Red;
        public const ConsoleColor ConsoleColorInput = ConsoleColor.Blue;
        public const ConsoleColor ConsoleColorValid = ConsoleColor.Green;

        public const char BlankValue = ' ';
        public const char VerticalDivider = '|';
        public const string HorizontalLine = " --- --- --- --- --- --- --- --- --- ";

        public const string TitleScreen =
        "\n" +
        "__COMMAND LINE________________________________________\n" +
        " _______  __   __  ______   _______  ___   _  __   __ \n" +
        "|       ||  | |  ||      | |       ||   | | ||  | |  |\n" +
        "|  _____||  | |  ||  _    ||   _   ||   |_| ||  | |  |\n" +
        "| |_____ |  |_|  || | |   ||  | |  ||      _||  |_|  |\n" +
        "|_____  ||       || |_|   ||  |_|  ||     |_ |       |\n" +
        " _____| ||       ||       ||       ||    _  ||       |\n" +
        "|_______||_______||______| |_______||___| |_||_______|\n" ;

        public const string MenuScreen =
        "Hey there! What would you like to do?\n" +
        "------------------------------------------------------\n" +
        " P. Play    C. Credits                        X. Exit \n" +
        "------------------------------------------------------\n" ;

        public const string CreditsScreen =
        "---CREDITS--------------------------------------------\n" +
        "                                                      \n" +
        "    CREATED BY                                        \n" +
        "    Marina Machado                                    \n" +
        "    Check me on github as MEI-Marina-Machado          \n" +
        "                                                      \n" +
        "    MADE IN                                           \n" +
        "    72 hours just for the challenge                   \n" +
        "                                                      \n" +
        "    I hope you're having fun!                         \n" +
        "    You can also contribute to the project in         \n" +
        "    github.com/MEI-MarinaMachado/CommandLineSudoku    \n" +
        "                                                      \n" +
        "------------------------------------------------------\n" ;

        public const string DifficultyScreen =
        "Select the game difficulty:\n" +
        "------------------------------------------------------\n" +
        " E. Easy    M. Medium    H. Hard              X. Exit \n" +
        "------------------------------------------------------\n" ;

        public const string WelcomeMsg = "Welcome to Command Line Sudoku.\n";
        public const string ExitMsg = "Thank you for playing!\n";
        public const string SelectionMsg = "Please type the option's letter and press enter: ";
        public const string SelectionErrorMsg = "Unrecognized option.";
        public const string GoBackMsg = "Type Enter to go back:";
        public const string GeneratingPuzzleMsg = "Generating the puzzle... Please wait.";
        public const string NewPuzzleMsg = "Ready, set, go!";
        public const string SuccessPuzzleMsg = "Congratulations, You won!";
        public const string FailurePuzzleMsg = "You lost :( You have {0} error(s).";

        public const string TypeColumnMsg = "Column:\t";
        public const string TypeRowMsg = "Row:\t";
        public const string TypeValueMsg = "Value:\t";
        public const string CellErrorMsg = "Cell at column {0} and row {1} can't be edited.\nPlease select another.";
        public const string NumberErrorMsg = "Please enter a number between 1 and 9.";
    }
}