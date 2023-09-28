using ResaApp.Interfaces;

namespace ResaApp.Classes;

public class Plane : ITransportation
{
    public int Id { get; private set; }
    public double Speed { get; init; }
    public string Name { get; init; }

    public void AssignId(int id)
    {
        Id = id;
    }

    public Plane(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }
}
