namespace SnakesAndLadders.App
{
    public interface IBoard
    {
        bool IsMoveValid(int spaces, int tokenSquare);

        bool IsTokenWinning(int tokenSquare);
    }
}
