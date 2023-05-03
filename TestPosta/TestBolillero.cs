using Biblioteca;

namespace Test;

public class TestBolillero
{
    public Bolillero bolillero { get; set; }
    public TestBolillero() => bolillero = new Bolillero(10 , new EPrimera());

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = bolillero.SacarBolilla();

        Assert.Equal(0,bolilla);
        Assert.Equal(9, bolillero.Adentro.Count);
        Assert.Equal(1, bolillero.Afuera.Count);
    }

    [Fact]
    public void TestName()
    {

    }

}