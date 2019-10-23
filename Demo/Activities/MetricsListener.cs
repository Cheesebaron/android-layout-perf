using Android.Views;

namespace Demo
{
    public class MetricsListener : Java.Lang.Object, Window.IOnFrameMetricsAvailableListener
    {
        private long _total;
        private int _count;

        public void OnFrameMetricsAvailable(Window window, FrameMetrics frameMetrics, int dropCountSinceLastInvocation)
        {
            using (var frameMetricsCopy = new FrameMetrics(frameMetrics))
            {
                var measureDuration = frameMetricsCopy.GetMetric((int)FrameMetricsId.LayoutMeasureDuration);

                System.Diagnostics.Debug.WriteLine($"MetricsListener: LayoutMeasureDuration: {measureDuration * 0.000001} ms");

                _total += measureDuration;
                _count++;

                System.Diagnostics.Debug.WriteLine($"MetricsListener: Total LayoutMeasureDuration: {_total * 0.000001} ms");
                System.Diagnostics.Debug.WriteLine($"MetricsListener: AVG LayoutMeasureDuration: { (_total / _count) * 0.000001} ms");
                
            }
        }
    }
}