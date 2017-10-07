using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace Demo
{
    [Activity(Label = "Draw", Theme = "@style/AppTheme")]
    public class DrawActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.draw_layout);
        }
    }
}