namespace Biblioteca;

public class Simulacion
{
    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
        => bolillero.JugarNveces(jugada, cantidad);

    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        for (int i = 0; i < hilos; i++)
        {
            var clon = bolillero.Clonar();
            tareas[i] = Task.Run(() => (long)clon.JugarNveces(jugada, cantidad));
        }
        Task<long>.WaitAll(tareas);
        var suma = tareas.Sum(t => t.Result);
        return suma;
    }


}
