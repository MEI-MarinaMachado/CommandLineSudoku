using System;

namespace CommandLineSudoku {

    enum SudokuMenuOption {
        Play,
        Credits,
        Quit,
        Unknown
    }

    class Program {
        static void Main(string[] args) {
            InitGame();
        }

        private static void InitGame() {
            Console.WriteLine(SudokuPrint.GameTitle);
            Console.WriteLine(SudokuPrint.WelcomeMsg);
            SelectMenuOption();
        }

        private static void SelectMenuOption() {
            SudokuMenuOption menu = SudokuMenuOption.Unknown;

            do {
                Console.WriteLine(SudokuPrint.MenuScreen);
                Console.WriteLine(SudokuPrint.SelectionMsg);
                string selection = Console.ReadLine();

                menu = GetSudokuMenuOption(selection);

                if(menu == SudokuMenuOption.Unknown) { 
                    Console.WriteLine(SudokuPrint.SelectionErrorMsg);
                }

                Console.WriteLine();
            }
            while(menu == SudokuMenuOption.Unknown);

            switch(menu) {
                case SudokuMenuOption.Play : Play(); break;
                case SudokuMenuOption.Credits : Credits(); break;
                case SudokuMenuOption.Quit : Quit(); break;
            }
        }

        private static SudokuMenuOption GetSudokuMenuOption(string selection) {
            int optionNumber;
            try {
                optionNumber = Int32.Parse(selection);
            }
            catch(Exception e){
                return SudokuMenuOption.Unknown;
            }
             
            SudokuMenuOption option;
            switch(optionNumber) {
                case 1 : option = SudokuMenuOption.Play; break;
                case 2 : option = SudokuMenuOption.Credits; break;
                case 3 : option = SudokuMenuOption.Quit; break;
                default : option = SudokuMenuOption.Unknown; break;
            }
            return option;
        }
        
        private static void Credits() {
            Console.WriteLine(SudokuPrint.CreditsScreen);
            GoBack();
        }
        
        private static void Quit() {
            Console.WriteLine(SudokuPrint.QuitMsg);
        }
        
        private static void GoBack() {
            Console.WriteLine(SudokuPrint.GoBackMsg);
            Console.ReadLine();
            Console.WriteLine();
            SelectMenuOption();
        }

        private static void Play() {
            string selection;
            int optionNumber = 0;
            do {
                Console.WriteLine(SudokuPrint.DifficultyScreen);
                Console.WriteLine(SudokuPrint.SelectionMsg);
                selection = Console.ReadLine();
                Console.WriteLine();

                try {
                    optionNumber = Int32.Parse(selection);
                }
                catch(Exception e){
                    Console.WriteLine(SudokuPrint.SelectionErrorMsg);
                }
            }
            while(optionNumber == 0);

            switch(optionNumber) {
                case 1 : Play(SudokuPuzzleFactory.SudokuDifficulty.Easy); break;
                case 2 : Play(SudokuPuzzleFactory.SudokuDifficulty.Medium); break;
                case 3 : Play(SudokuPuzzleFactory.SudokuDifficulty.Hard); break;
                case 4 : SelectMenuOption(); break;
            }
        }

        private static void Play(SudokuPuzzleFactory.SudokuDifficulty difficulty) {
            Console.WriteLine(SudokuPrint.GeneratingPuzzleMsg);

            SudokuPuzzleFactory factory = new SudokuPuzzleFactory();
            SudokuPuzzle puzzle = factory.CreateSudokuPuzzle(difficulty);

            Console.WriteLine(puzzle);
            Console.WriteLine();
        }
    }
}
