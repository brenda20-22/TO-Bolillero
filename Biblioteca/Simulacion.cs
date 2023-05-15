namespace Biblioteca;

public class Simulacion
{
    public Bolillero bolillero { get; set; }
    public List<int> Jugada { get; set; }
    public int cantidad { get; set; }
    public Simulacion(Bolillero bolillero)
    {
        this.bolillero = bolillero;
        this.Jugada = new List<int>();
        this.cantidad = cantidad;
    }
    public void simularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
    {

    }

    public void SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad)
    {

    }

}
