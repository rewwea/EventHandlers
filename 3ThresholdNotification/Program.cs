using System;

namespace ThresholdNotification
{
    class Program
    {
        static void Main(string[] args)
        {
            var threshold = new Threshold(100);
            var notifier = new ThresholdNotifier();

            threshold.ThresholdReached += notifier.OnThresholdReached;

            threshold.UpdateValue(90);
            threshold.UpdateValue(110);
        }
    }
}