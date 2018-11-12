namespace SnakesAndLadders.App
{
    public class Token : IToken
    {
        public int CurrentSquare { get; private set; } = 1;

        public void Move(int spaces)
        {
            CurrentSquare += spaces;
        }
    }
}
