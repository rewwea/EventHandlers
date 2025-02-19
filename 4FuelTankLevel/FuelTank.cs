using System;

namespace FuelTankLevel
{
    public class FuelTank
    {
        public event Action<int> FuelLevelChanged;

        private int _fuelLevel;

        public int FuelLevel
        {
            get => _fuelLevel;
            set
            {
                if (_fuelLevel != value)
                {
                    _fuelLevel = value;
                    OnFuelLevelChanged(value);
                }
            }
        }

        protected virtual void OnFuelLevelChanged(int newLevel)
        {
            FuelLevelChanged?.Invoke(newLevel);
        }
    }
}