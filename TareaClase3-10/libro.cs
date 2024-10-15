public class libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }

    public override string ToString()
    {
        return $"Título = {Titulo}, Autor = {Autor}";
    }
}

