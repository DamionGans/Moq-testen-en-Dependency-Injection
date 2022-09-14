using Moq;
using Programma;

namespace Testen;

public class UnitTest1
{
    [Fact]
    public void WatWeWillenTesten_DezeMethodeWillenWeTesten_ReturnsValueFromAfhankelijkheid()
    {
        Mock<IAfhankelijkheid> afhankelijkheid = new Mock<IAfhankelijkheid>();
        afhankelijkheid.Setup(x => x.AfhankelijkheidMethode()).Returns(6);
        IWatWeWillenTesten sut = new WatWeWillenTesten(afhankelijkheid.Object);
        afhankelijkheid.Verify(x => x.AfhankelijkheidMethode());
        int expected = 6;
        int actual = sut.DezeMethodeWillenWeTesten();
        Assert.Equal(expected, actual);
    }
}