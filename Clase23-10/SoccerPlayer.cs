public class SoccerPlayer : IPlayer
{
    public String Name {get; set;}
    
    public int ScoredPoints {get; set;}

    public void Play()
    {
        Console.WriteLine($" {Name} i play soccer");
    }
        public int Score()
    {
        ScoredPoints+=1;
        return ScoredPoints;
    }
}
