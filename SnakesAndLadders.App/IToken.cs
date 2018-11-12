namespace SnakesAndLadders.App
{
    public interface IToken
    {
        int CurrentSquare { get; }

        void Move(int spaces);
    }
}
