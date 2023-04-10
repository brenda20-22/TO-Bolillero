namespace Biblioteca;

public class Bolillero : IAzar
{
    public int CantidadBolillas { get; set; }
    public bool JugadaAcertada { get; set; }
    public int numAleatorios { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Bolillero(int CantidadBolillas, bool JugadaAcertada)
    {
        CantidadBolillas = CantidadBolillas;
        JugadaAcertada = JugadaAcertada;

    }

    public void SacarBolilla()
    {

    }
    public void Jugar(List<int>)
    {

    }
    public void JugarNveces(List<int>, int)
    {

    }
    public void BolillasSacadas()
    {

    }
}

