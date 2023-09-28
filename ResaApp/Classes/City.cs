using ResaApp.Interfaces;

namespace ResaApp.Classes;

public class City : ICity
{
    public int Id { get; }
    public string Name { get; init; }
    public double Longitude { get; init; }
    public double Latitude { get; init; }

    public City(int id, string name, double longitude, double latitude)
    {
        Id = id;
        Name = name;
        Longitude = longitude;
        Latitude = latitude;
    }
}
