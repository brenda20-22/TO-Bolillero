using Biblioteca;

namespace TestPosta;

public class TestSimularConHilos
{
    public Simulacion simulacion { get; set; }
    public Bolillero bolillero { get; set; }
    private List<int> _jugada;
    private int _cantidad;
    private int _hilos;
    public TestSimularConHilos()
    {
        bolillero = new Bolillero(10, new EPrimera());
        _jugada = new List<int>() { 0 };
        _cantidad = 1;
        simulacion = new Simulacion();
        _hilos = 2;
    }

    [Fact]
    public void SimularSinHilos()
    {
        var jugada = simulacion.SimularSinHilos(bolillero, _jugada, _cantidad);
        Assert.Equal((long)1, jugada);
    }

    [Fact]
    public void SimularConHilos()
    {
        var resultado = simulacion.SimularConHilos(bolillero, _jugada, _cantidad, _hilos);
        Assert.Equal(_hilos, resultado);
    }


    [Fact]
    public async Task SimularConHilosAsync()
    {
        var sumahilos = await simulacion.SimularConHilosAsync(bolillero, _jugada, _cantidad, _hilos);
        Assert.Equal(_hilos, sumahilos);
    }

    [Fact]
    public async Task SimularParallelAsync()
    {
        var simulaciones = await simulacion.SimularParallelAsync(bolillero, _jugada, _cantidad, _hilos);
        Assert.Equal(_cantidad, simulaciones);  
    }
}
