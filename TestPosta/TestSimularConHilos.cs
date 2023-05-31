using Biblioteca;

namespace TestPosta;

public class TestSimularConHilos
{
    public Simulacion simulacion { get; set; }
    public Bolillero bolillero { get; set; }
    private List<int> _jugada;
    private int cantidad;
    private int hilos;
    public TestSimularConHilos()
    {
        bolillero = new Bolillero(10, new EPrimera());
        _jugada = new List<int>() { 0 };
        cantidad = 1;
        simulacion = new Simulacion();
        hilos = 2;
    }

    [Fact]
    public void SimularSinHilos()
    {
        var jugada = simulacion.SimularSinHilos(bolillero, _jugada, cantidad);
        Assert.Equal((long)1, jugada);
    }

    [Fact]
    public void SimularConHilos()
    {
        var hilos = simulacion.SimularConHilos(bolillero, _jugada, cantidad, hilos);
        Assert.Equal((long)2, hilos);
    }
}
