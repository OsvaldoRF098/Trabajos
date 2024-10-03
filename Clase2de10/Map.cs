using System.Dynamic;

public class Map
{
    public string Name {get;set;}

    public long Long {get;set;}


    public long latitude {get;set;}


    public void ShowMap()
    {

    }

    public void MoveLocation(long x, long y)
    {
        Long= Long + x;
        latitude =latitude + y;
    }
    
}