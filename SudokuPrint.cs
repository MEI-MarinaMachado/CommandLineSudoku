namespace CommandLineSudoku {
    internal static class SudokuPrint {

        public const string NewLine = "\n";
        public const string HiddenValue = " ";
        public const string VerticalDivider = "|";
        public const string HorizontalDivider = " ---";
        public const string HorizontalLine = " --- --- --- --- --- --- --- --- --- ";

        public const string GameTitle =
        "\n" +
        "__COMMAND LINE________________________________________\n" +
        " _______  __   __  ______   _______  ___   _  __   __ \n" +
        "|       ||  | |  ||      | |       ||   | | ||  | |  |\n" +
        "|  _____||  | |  ||  _    ||   _   ||   |_| ||  | |  |\n" +
        "| |_____ |  |_|  || | |   ||  | |  ||      _||  |_|  |\n" +
        "|_____  ||       || |_|   ||  |_|  ||     |_ |       |\n" +
        " _____| ||       ||       ||       ||    _  ||       |\n" +
        "|_______||_______||______| |_______||___| |_||_______|\n";

        public const string WelcomeMsg = "Welcome to Command Line Sudoku. Let's start!\n";

        public const string MenuScreen =
        "What would you like to do?\n" +
        "------------------------------------------------------\n" +
        " 1. Play          2. Credits        3. Exit           \n" +
        "------------------------------------------------------\n" ;

        public const string SelectionMsg = "Please type the option's number and press enter: ";

        public const string SelectionErrorMsg = "Unrecognized number.";

        public const string QuitMsg = "Thank you for playing!\n";

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
        
        public const string GoBackMsg = "Type Enter to go back:";

        public const string DifficultyScreen =
        "Select the game difficulty:\n" +
        "------------------------------------------------------\n" +
        " 1. Easy      2. Medium      3. Hard      4. Exit     \n" +
        "------------------------------------------------------\n" ;

        public const string GeneratingPuzzleMsg = "Generating the puzzle... Please wait.\n";

    }
}