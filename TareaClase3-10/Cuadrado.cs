public class Cuadrado
{
    public int Lado { get; set; }


    public Cuadrado(int lado)
    {
        Lado = lado;
    }

    public int CalcularArea()
    {
        return Lado * Lado;
    }

    public int CalcularPerimetro()
    {
        return 2 * (Lado + Lado);
    }

    public override string ToString()
    {
        return $"Lados: {Lado}, Perímetro: {CalcularPerimetro()}, Área: {CalcularArea()}";
    }
}

