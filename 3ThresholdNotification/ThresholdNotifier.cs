namespace ThresholdNotification
{
    public class ThresholdNotifier
    {
        public void OnThresholdReached(int value)
        {
            Console.WriteLine($"Threshold reached! Current value: {value}");
        }
    }
}