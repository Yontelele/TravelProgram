namespace ResaApp.Interfaces;

public interface ITransportation
{
    public int Id { get; }
    public double Speed { get; init; }
    public string Name { get; init; }

    public void AssignId(int id);
}
