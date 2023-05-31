namespace Biblioteca;


public class Bolillero
{
    public List<int> Adentro { get; set; }
    public List<int> Afuera { get; set; }
    public IAzar azar { get; set; }

    public Bolillero(int cantidad, IAzar azar)
    {
        this.Adentro = new List<int>();
        this.Afuera = new List<int>();
        this.azar = azar;
        CrearBolilla(cantidad);
    }

    private Bolillero(Bolillero original)
    {
        Adentro = new List<int>(original.Adentro);
        Afuera = new List<int>(original.Afuera);
        azar = original.azar;
    }

    public int SacarBolilla()
    {
        var indice = azar.IndiceAleatorio(this.Adentro);
        var bolilla = Adentro[indice];
        Adentro.Remove(bolilla);
        Afuera.Add(bolilla);
        return bolilla;
        //1 ) guardar la bolilla de adentro, usando el indice
        //2 ) sacarla de adentro
        //3) Ponerla afuera
        //4) devolver con return, la bolilla que sacaste
    }
    public bool Jugar(List<int> jugada)
    {
        for (int i = 0; i < jugada.Count; ++i)
        {
            var bolilla = SacarBolilla();

            if (bolilla != jugada[i])
            {
                return false;
            }
        }
        return true;
    }

    public int JugarNveces(List<int> jugada, int cantidad)
    {
        var ganadas = 0;
        for (int i = 0; i <= cantidad; ++i)
        {
            MeterBolillas();
            if (Jugar(jugada))
            {
                ganadas++;
            }
        }
        return ganadas;
    }
    public void MeterBolillas()
    {
        Adentro.AddRange(Afuera);
        Afuera.Clear();
    }

    public void CrearBolilla(int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            Adentro.Add(i);
        }
    }

    internal Bolillero Clonar() => new Bolillero(this);
}

