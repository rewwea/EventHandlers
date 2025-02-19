using System;

namespace OrderStatus
{
    public class Order
    {
        public event Action<string> StatusChanged;

        private string _status;

        public string Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnStatusChanged(value);
                }
            }
        }

        protected virtual void OnStatusChanged(string newStatus)
        {
            StatusChanged?.Invoke(newStatus);
        }
    }
}