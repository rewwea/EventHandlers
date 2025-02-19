using System;

namespace FuelTankLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelTank = new FuelTank();
            var notifier = new FuelLevelNotifier();

            fuelTank.FuelLevelChanged += notifier.OnFuelLevelChanged;

            fuelTank.FuelLevel = 50;
            fuelTank.FuelLevel = 75;
        }
    }
}