public class Punto
{
    public double X { get; set; }
    public double Y { get; set; }

    public Punto(double x, double y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"Punto (X: {X}, Y: {Y})";
    }
}
