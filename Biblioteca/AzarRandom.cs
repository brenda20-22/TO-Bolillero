namespace Biblioteca;

public class AzarRandom : IAzar
{
    private Random _random { get; set; }
    public AzarRandom()
    => _random = new Random(DateTime.Now.Millisecond);



    public int IndiceAleatorio(List<int> Adentro)

    => _random.Next(0, Adentro.Count);

}
