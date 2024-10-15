public class Coche
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Año { get; set; }
    public string Tipo { get; set; }
    public int Kilometros { get; set; }

    public Coche(string marca, string modelo, int año, string tipo, int kilometros)
    {
        Marca = marca;
        Modelo = modelo;
        Año = año;
        Tipo = tipo;
        Kilometros = kilometros;
    }

    public override string ToString()
    {
        return $"{Marca} {Modelo} ({Año}) - {Tipo} - {Kilometros} km";
    }
}
