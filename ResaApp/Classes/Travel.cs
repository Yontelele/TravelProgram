using ResaApp.Interfaces;
using System.Collections.Generic;
using ResaApp.Classes;
using Microsoft.AspNetCore.Components.Routing;

namespace ResaApp.Classes;

public class Travel
{
    List<ITransportation> transportations = new List<ITransportation>();
    List<ICity> cities = new List<ICity>();
    List<Route> routes = new List<Route>();
    public List<Route> Routes => routes.GetRange(0, routes.Count);

    public void AddTransportation(ITransportation transportation)
    {
        var id = transportations.Count == 0 ? 1 : transportations.Max(t => t.Id) + 1;
        transportation.AssignId(id);
        transportations.Add(transportation);
    }

    public ICity AddCity(string name, double latitude, double longitude)
    {
        var id = cities.Count == 0 ? 1 : cities.Max(r => r.Id) + 1;
        var city = new City(id, name, latitude, longitude);
        cities.Add(city);
        return city;
    }
    public void AddRoute(ICity origin, ICity destination, ITransportation transportation)
    {
        var id = routes.Count == 0 ? 1 : routes.Max(r => r.Id) + 1;
        routes.Add(new Route(id, origin, destination, transportation));
    }
}
