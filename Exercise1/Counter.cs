using System.Data;

public class Contador
{
    private int _count;
    public int GetNextValue()
    {
        _count += 1;
        return _count;
    }

    public int Sumador(int x, int y)
    {
        return x + y;
    }
}