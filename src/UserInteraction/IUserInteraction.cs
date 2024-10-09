namespace StarWarsPlanetsStats.UserInteraction;

public interface IUserInteraction
{
    public void PrintMessage(string message);
    public void PrintPlanetsInfo(List<PlanetInfo> planets);
}
