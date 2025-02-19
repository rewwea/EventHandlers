using System;

namespace ThresholdNotification
{
    public class Threshold
    {
        public event Action<int> ThresholdReached;

        private int _value;
        private int _threshold;

        public Threshold(int threshold)
        {
            _threshold = threshold;
        }

        public void UpdateValue(int newValue)
        {
            _value = newValue;
            if (_value > _threshold)
            {
                OnThresholdReached(_value);
            }
        }

        protected virtual void OnThresholdReached(int value)
        {
            ThresholdReached?.Invoke(value);
        }
    }
}