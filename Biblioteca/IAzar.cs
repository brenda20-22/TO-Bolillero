namespace Biblioteca;

public interface IAzar
{
    public int numAleatorios { get; set; }
    public IAzar(int numAleatorios)
    {
    NumAleatorios: numAleatorios;
    }

    public void ElegirBolilla(List<int>)
    {

    }
}
