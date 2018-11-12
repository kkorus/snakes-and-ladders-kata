using AutoFixture;
using AutoFixture.AutoMoq;
using Moq;
using NUnit.Framework;
using SnakesAndLadders.App;

namespace SnakesAndLadders.Tests
{
    public class PlayerTests
    {
        private IFixture _fixture;
        private Mock<IToken> _tokenMock;
        private Mock<IBoard> _boardMock;
        private Mock<IOutputStream> _outputStreamMock;

        private IPlayer _sut;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            _tokenMock = _fixture.Freeze<Mock<IToken>>();
            _boardMock = _fixture.Freeze<Mock<IBoard>>();
            _outputStreamMock = _fixture.Freeze<Mock<IOutputStream>>();
        }

        [SetUp]
        public void SetUp()
        {
            _tokenMock.Setup(x => x.CurrentSquare).Returns(1);
            _sut = _fixture.Create<Player>();
        }

        [Test]
        public void When_PlayerRolledValidMove_Then_WriteMessageWithCurrentTokenSquare()
        {
            _boardMock.Setup(x => x.IsMoveValid(It.IsAny<int>(), It.IsAny<int>())).Returns(true);

            _sut.RollADice();

            _outputStreamMock.Verify(x => x.Write("Player's token current square: 1"));
        }

        [Test]
        public void When_PlayerRolledWinningMove_Then_InformPlayerAboutWinning()
        {
            _boardMock.Setup(x => x.IsMoveValid(It.IsAny<int>(), It.IsAny<int>())).Returns(true);
            _boardMock.Setup(x => x.IsTokenWinning(It.IsAny<int>())).Returns(true);

            _sut.RollADice();

            _outputStreamMock.Verify(x => x.Write("Player has won the game"));
        }
    }
}
