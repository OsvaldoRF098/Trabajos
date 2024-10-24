public class BaseBallPlayer : IPlayer
{
    public String Name {get; set;}

    public int ScoredPoints {get; set;}
    
    public void Play()
    {
        Console.WriteLine("juega baseball");
    }
    
    public int Score()
    {
        ScoredPoints++;
        return ScoredPoints;
    }
}