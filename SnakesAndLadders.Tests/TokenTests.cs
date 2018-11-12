using NUnit.Framework;
using SnakesAndLadders.App;

namespace SnakesAndLadders.Tests
{
    public class TokenTests
    {
        private IToken _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new Token();
        }

        [Test]
        public void When_TokenIsCreated_Then_HasInitialSquare()
        {
            Assert.That(_sut.CurrentSquare, Is.EqualTo(1));
        }

        [Test]
        public void When_TokenIsMoved_Then_SquareIsChanged()
        {
            _sut.Move(6);

            Assert.That(_sut.CurrentSquare, Is.EqualTo(7));
        }
    }
}
