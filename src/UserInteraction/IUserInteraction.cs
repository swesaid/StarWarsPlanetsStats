namespace StarWarsPlanetsStats.UserInteraction;

public interface IUserInteraction
{
    public void PrintMessage(string message);
    public void PrintPlanetsInfoTable(List<PlanetInfo> planets);
    public void PrintAvailableProperties();
}
