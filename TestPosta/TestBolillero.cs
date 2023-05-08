using Biblioteca;

namespace Test;

public class TestBolillero
{
    public Bolillero bolillero { get; set; }
    public TestBolillero() => bolillero = new Bolillero(10, new EPrimera());

    [Fact]
    public void SacarBolilla()
    {
        var bolilla = bolillero.SacarBolilla();

        Assert.Equal(0, bolilla);
        Assert.Equal(9, bolillero.Adentro.Count);
        Assert.Equal(1, bolillero.Afuera.Count);
    }

    [Fact]
    public void ReingresarBolilla()
    {
        var numero = bolillero.SacarBolilla();
        var espera = 9;



        Assert.Single(bolillero.Afuera);
        bolillero.MeterBolillas();
        Assert.Empty(bolillero.Afuera);


    }

    [Fact]
    public void JugarGana()
    {
        var victoria = bolillero.Jugar(jugada: new List<int> { 0, 1, 2, 3 });
        Assert.True(victoria);
    }

    [Fact]
    public void JugarPierde()
    {
        var pierde = bolillero.Jugar(jugada: new List<int> { 4, 2, 3 });
        Assert.False(pierde);
    }

    [Fact]
    public void JugarNveces()
    {
        var jugada = bolillero.JugarNveces(jugada: new List<int> { 0, 1 }, cantidad: 1);
        Assert.Equal(1, jugada);
    }

}