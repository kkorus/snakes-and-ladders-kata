namespace SnakesAndLadders.App
{
    public class Board : IBoard
    {
        private readonly int _squares;

        public Board(int squares)
        {
            _squares = squares;
        }

        public bool IsMoveValid(int spaces, int tokenSquare)
        {
            return spaces + tokenSquare <= _squares;
        }

        public bool IsTokenWinning(int tokenSquare)
        {
            return tokenSquare == _squares;
        }
    }
}
