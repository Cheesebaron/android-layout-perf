using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace Demo
{
    [Activity(Label = "Verbose", Theme = "@style/AppTheme")]
    public class VerboseActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.verbose_layout);
        }
    }
}