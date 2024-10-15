public class GestorCuadrado
{
    public Cuadrado CrearCuadrado(int lado)
    {
        return new Cuadrado(lado);
    }

    public void MostrarDetallesCuadrado(Cuadrado cuadrado)
    {
        Console.WriteLine($"Detalles del cuadrado:\n{cuadrado}");
    }
}

