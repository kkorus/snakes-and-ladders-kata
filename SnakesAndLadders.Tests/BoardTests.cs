using NUnit.Framework;
using SnakesAndLadders.App;

namespace SnakesAndLadders.Tests
{
    public class BoardTests
    {
        private IBoard _board;

        [SetUp]
        public void SetUp()
        {
            _board = new Board(100);
        }

        [Test]
        public void When_TokenNextMoveIsLessThanBoardSquares_Then_MoveIsValid()
        {
            Assert.That(_board.IsMoveValid(9, 90), Is.True);
        }

        [Test]
        public void When_TokenNextMoveIsEqualToBoardSquares_Then_MoveIsValid()
        {
            Assert.That(_board.IsMoveValid(10, 90), Is.True);
        }

        [Test]
        public void When_TokenNextMoveIsGreaterThenBoardSquares_Then_MoveIsInvalid()
        {
            Assert.That(_board.IsMoveValid(11, 90), Is.False);
        }

        [Test]
        public void When_TokenSquareIsEqualToBoardSquares_Then_TokenIsWinning()
        {
            Assert.That(_board.IsTokenWinning(100), Is.True);
        }

        [Test]
        public void When_TokenSquareIsNotEqualToBoardSquares_Then_TokenIsNotWinning()
        {
            Assert.That(_board.IsTokenWinning(99), Is.False);
        }
    }
}
