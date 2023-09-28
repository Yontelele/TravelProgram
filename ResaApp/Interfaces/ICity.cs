namespace ResaApp.Interfaces;

public interface ICity
{
    public int Id { get; }
    public string Name { get; init; }
    public double Longitude { get; init; }
    public double Latitude { get; init; }
}
