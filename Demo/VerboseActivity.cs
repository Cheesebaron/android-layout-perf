using Android.App;
using Android.OS;

namespace Demo
{
    [Activity(Label = "Verbose")]
    public class VerboseActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.verbose_layout);
        }
    }
}