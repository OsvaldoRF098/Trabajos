public class Team
{
    public List<IPlayer> Players;

    public Team()
    {
        Players = new List<IPlayer>();
    }

    public void AddPlayer(IPlayer player)
    {
        Players.Add(player);
    }

    public void Play()
    {
        foreach(var item in Players)
        {
            item.Play();
            item.Score();
        }
    }
}