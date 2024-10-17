
public class Repository<T>
{
    private T item;

    internal static int x = 0;
    public int Save(T item)
    {
        x++;
        Console.WriteLine("Item Guardado en la BD");
        return x;
    }
    public T GetItem ()
    {
        return item;
    }
}