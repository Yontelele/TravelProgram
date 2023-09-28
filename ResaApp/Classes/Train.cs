using ResaApp.Interfaces;
using ResaApp.Classes;

namespace ResaApp.Classes;

public class Train : ITransportation
{
    public int Id { get; private set; }
    public double Speed { get; init; }
    public string Name { get; init; }

    public void AssignId(int id)
    {
        Id = id;
    }

    public Train(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }
}
