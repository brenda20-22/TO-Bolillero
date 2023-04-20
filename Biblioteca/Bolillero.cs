namespace Biblioteca;

public class Bolillero
{
    public List<int> Adentro { get; set; }
    public List<int> Afuera { get; set; }
    public List<int> Jugada { get; set; }
    public IAzar azar { get; set; }

    public Bolillero(int adentro, int afuera, IAzar azar)
    {
        this.Adentro = new List<int>();
        this.Afuera = new List<int>();
        this.Jugada = new List<int>();
        this.azar = azar;
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
        var ax = 0;
        for (int i = 0; i < jugada.Count; ++i)
        {
            var bolilla = SacarBolilla();

            if (bolilla != jugada[ax])
            {
                return false;
            }
        }
        return true;
    }

    public void JugarNveces(List<int> jugada, int cantidad)
    {
        var ganadas = 0;
        for (int i = 0; i <= cantidad; ++i)
        {
            var jugar = Jugar(jugada);
            if (jugar == true)
            {
                ganadas = +1;
            }
        }
    }
    public void MeterBolillas()
    {

    }
}

