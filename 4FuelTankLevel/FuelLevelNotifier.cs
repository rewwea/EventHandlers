namespace FuelTankLevel
{
    public class FuelLevelNotifier
    {
        public void OnFuelLevelChanged(int newLevel)
        {
            Console.WriteLine($"Fuel level changed to: {newLevel}%");
        }
    }
}