public class Estudiante : Persona
{
    public void IrAClases()
    {
        Console.WriteLine("Voy a clases.");
    }

    public void MostrarEdad()
    {
        Console.WriteLine("Mi edad es: " + ObtenerEdad() + " años.");
    }
}
