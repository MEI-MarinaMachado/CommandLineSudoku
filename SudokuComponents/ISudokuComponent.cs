namespace CommandLineSudoku {
    public interface ISudokuComponent {
        public int Length { get; }
        public bool ContainsValue(int value);
    }
}