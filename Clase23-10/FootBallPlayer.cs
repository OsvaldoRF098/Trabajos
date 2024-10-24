public class FootBallPlayer : IPlayer
{
    public string Name { get; set; }

    public int ScoredPoints {get; set;}

    public void Play()
    {
        Console.WriteLine($" {Name} Plays American FootBall");
    }

    public int Score()
    {
        throw new NotImplementedException();
    }
}