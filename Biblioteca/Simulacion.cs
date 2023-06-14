namespace Biblioteca;

public class Simulacion
{
    public Task<long>[] Tarea(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        Task<long>[] tareas = new Task<long>[hilos];
        for (int i = 0; i < hilos; i++)
        {
            var clon = bolillero.Clonar();
            tareas[i] = Task.Run(() => (long)clon.JugarNveces(jugada, cantidad));
        }
        return tareas;
    }

    public long SimularSinHilos(Bolillero bolillero, List<int> jugada, int cantidad)
        => bolillero.JugarNveces(jugada, cantidad);

    public long SimularConHilos(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        var tareas = Tarea(bolillero, jugada, cantidad, hilos);
        Task<long>.WaitAll(tareas);
        var suma = tareas.Sum(t => t.Result);
        return suma;
    }

    public async Task<long> SimularConHilosAsync(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        var tareas = Tarea(bolillero, jugada, cantidad, hilos);
        await Task<long>.WhenAll(tareas);
        var suma = tareas.Sum(t => t.Result);
        return suma;
    }

    public async Task<long> SimularParallelAsync(Bolillero bolillero, List<int> jugada, int cantidad, int hilos)
    {
        long [] resultados = new long [cantidad];

        await Task.Run( () =>
            Parallel.For(
                0,
                cantidad,
                i =>
                {
                    var clon = bolillero.Clonar();
                    resultados[i] = clon.JugarNveces(jugada, cantidad / hilos);
                }
            )
        );
        return resultados.Sum();
    }
}
