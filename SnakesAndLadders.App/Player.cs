namespace SnakesAndLadders.App
{
    public class Player : IPlayer
    {
        private readonly IToken _token;
        private readonly IDice _dice;
        private readonly IBoard _board;
        private readonly IOutputStream _outputStream;

        public Player(IToken token, IDice dice, IBoard board, IOutputStream outputStream)
        {
            _token = token;
            _dice = dice;
            _board = board;
            _outputStream = outputStream;
        }

        public void RollADice()
        {
            var spaces = _dice.Roll();

            if (!_board.IsMoveValid(spaces, _token.CurrentSquare)) return;

            _outputStream.Write($"Player's token current square: {_token.CurrentSquare}");

            _token.Move(spaces);
            if (_board.IsTokenWinning(_token.CurrentSquare))
            {
                _outputStream.Write("Player has won the game");
            }
        }
    }
}
