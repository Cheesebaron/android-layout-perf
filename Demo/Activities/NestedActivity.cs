using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace Demo
{
    [Activity(Label = "Nested", Theme = "@style/AppTheme")]
    public class NestedActivity : AppCompatActivity
    {
        private Handler _frameMetricsHandler;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.nested_layout);

            _frameMetricsHandler = new Handler();

            Window.AddOnFrameMetricsAvailableListener(new MetricsListener(), _frameMetricsHandler);
        }
    }

    [Activity(Label = "Constraints", Theme = "@style/AppTheme")]
    public class ConstraintsActivity : AppCompatActivity
    {
        private Handler _frameMetricsHandler;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.constraints_layout);

            _frameMetricsHandler = new Handler();

            Window.AddOnFrameMetricsAvailableListener(new MetricsListener(), _frameMetricsHandler);
        }
    }
}