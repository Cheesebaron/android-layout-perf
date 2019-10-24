using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;

namespace Demo
{
    [Activity(Label = "Verbose Constraint", Theme = "@style/AppTheme")]
    public class Verbose3Activity : AppCompatActivity
    {
        private Handler _frameMetricsHandler;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.constraint_verbose_layout);

            _frameMetricsHandler = new Handler();

            Window.AddOnFrameMetricsAvailableListener(new MetricsListener(), _frameMetricsHandler);
        }
    }
}