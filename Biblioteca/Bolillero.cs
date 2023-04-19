namespace Biblioteca;

public class Bolillero
{
    public List<int> Adentro { get; set; }
    public List<int> Afuera { get; set; }
    public List<int> 
    public IAzar azar { get; set; }

    public Bolillero(int Cantidad, IAzar azar)
    {
        this.Afuera = Afuera;
        this.Adentro = Adentro;
    }

    public int SacarBolilla()
    {
        var indiceAleatorio = azar.IndiceAleatorio(this.cantidad);
    }
    public void Jugar()
    {

    }
    public void JugarNveces()
    {

    }
    public void MeterBolillas()
    {

    }
}

