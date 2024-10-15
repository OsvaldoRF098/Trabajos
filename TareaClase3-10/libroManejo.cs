public class libroManejo
{
    private libro[] libros;
    private int count;

    public libroManejo(int capacity)
    {
        libros = new libro[capacity];
        count = 0;
    }

    public void AñadirLibro(string titulo, string autor)
    {
        if (count < libros.Length)
        {
            libros[count] = new libro(titulo, autor);
            count++;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más libros. Capacidad máxima alcanzada.");
        }
    }

    public void MostrarL()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}: {libros[i]}");
        }
    }
}
