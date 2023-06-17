public class Team
{
    private List<Player> _players = new List<Player>();
    private string _name;
    private int win = 0;
    private int loss = 0;   

    public Team(string name)
    {
        _name = name;
    }

    public void AddPlayer(Player p)
    {
        _players.Add(p);
    }

    public void DisplayRoster()
    {
        Console.WriteLine($"{_name} {_wins}/{jerseys}");
        
        foreach (Player player in _players)
        {
            Console.WriteLine(player.Display());            
        }
    }

      public void AddWin()
    {
        win += 1;
    }

    public void AddLoss()
    {
        loss += 1;
    }

}