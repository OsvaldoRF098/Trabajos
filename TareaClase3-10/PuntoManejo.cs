public class PuntoManejo
{
    private Punto[] puntos;
    private int count;

    public PuntoManejo(int capacity)
    {
        puntos = new Punto[capacity];
        count = 0;
    }

    public void AñadirPunto(double x, double y)
    {
        if (count < puntos.Length)
        {
            puntos[count] = new Punto(x, y);
            count++;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más puntos. Capacidad máxima alcanzada.");
        }
    }

    public void Mostrar()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Punto {i + 1}: {puntos[i]}");
        }
    }
}

