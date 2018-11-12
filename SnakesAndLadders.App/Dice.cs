using System;

namespace SnakesAndLadders.App
{
    public class Dice : IDice
    {
        public int Roll()
        {
            var random = new Random();
            return random.Next(1, 7);
        }
    }
}
