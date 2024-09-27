public class Persona
{
    private int edad;

    public void Saludar()
    {
        Console.WriteLine("¡Hola!");
    }

    public void EstablecerEdad(int n)
    {
        edad = n;
    }

    public int ObtenerEdad()
    {
        return edad;
    }
}
