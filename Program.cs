using System;

namespace CommandLineSudoku {

    enum SudokuMenuOption {
        Play,
        Credits,
        Exit,
        Unknown
    }

    class Program {
        static void Main(string[] args) {
            Console.WriteLine(SudokuPrint.TitleScreen);
            Console.WriteLine(SudokuPrint.WelcomeMsg);
            selectMenuOption();
        }

        private static void selectMenuOption() {
            SudokuMenuOption menu = SudokuMenuOption.Unknown;

            do {
                Console.WriteLine(SudokuPrint.MenuScreen);
                Console.WriteLine(SudokuPrint.SelectionMsg);
                string selection = Console.ReadLine();

                menu = getSudokuMenuOption(selection);

                if(menu == SudokuMenuOption.Unknown) { 
                    Console.WriteLine(SudokuPrint.SelectionErrorMsg);
                }

                Console.WriteLine();
            }
            while(menu == SudokuMenuOption.Unknown);

            switch(menu) {
                case SudokuMenuOption.Play : play(); break;
                case SudokuMenuOption.Credits : credits(); break;
                case SudokuMenuOption.Exit : exit(); break;
            }
        }

        private static SudokuMenuOption getSudokuMenuOption(string selection) {
            SudokuMenuOption option;
            switch(selection.ToUpper()) {
                case "P" : option = SudokuMenuOption.Play; break;
                case "C" : option = SudokuMenuOption.Credits; break;
                case "X" : option = SudokuMenuOption.Exit; break;
                default  : option = SudokuMenuOption.Unknown; break;
            }
            return option;
        }
        
        private static void credits() {
            Console.WriteLine(SudokuPrint.CreditsScreen);
            goBack();
        }
        
        private static void exit() {
            Console.WriteLine(SudokuPrint.ExitMsg);
        }
        
        private static void goBack() {
            Console.WriteLine(SudokuPrint.GoBackMsg);
            Console.ReadLine();
            Console.WriteLine();
            selectMenuOption();
        }

        private static void play() {
            string selection;
            SudokuGame.Difficulty difficulty = SudokuGame.Difficulty.Unknown;
            bool validSelection = false;

            do {
                Console.WriteLine(SudokuPrint.DifficultyScreen);
                Console.WriteLine(SudokuPrint.SelectionMsg);
                selection = Console.ReadLine();
                Console.WriteLine();

                switch(selection.ToUpper()) {
                    case "E" : difficulty = SudokuGame.Difficulty.Easy; validSelection = true; break;
                    case "M" : difficulty = SudokuGame.Difficulty.Medium; validSelection = true; break;
                    case "H" : difficulty = SudokuGame.Difficulty.Hard; validSelection = true; break;
                    case "X" : difficulty = SudokuGame.Difficulty.Unknown; validSelection = true; break;
                    default  : Console.WriteLine(SudokuPrint.SelectionErrorMsg); break;
                }
            }
            while(validSelection == false);

            if(difficulty == SudokuGame.Difficulty.Unknown) selectMenuOption();
            else play(difficulty);
        }

        private static void play(SudokuGame.Difficulty difficulty) {
            SudokuGame game = new SudokuGame(difficulty);
            game.Play();
            selectMenuOption();
        }
    }
}
