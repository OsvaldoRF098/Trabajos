public class Profesor : Persona
{
    private string asignatura;

    public void EstablecerAsignatura(string asignatura)
    {
        this.asignatura = asignatura;
    }

    public void Explicar()
    {
        Console.WriteLine("Comienza la explicación.");
    }
}
