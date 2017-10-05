using Android.App;
using Android.OS;
using Android.Support.V7.App;

namespace Demo
{
    [Activity(Label = "Nested", Theme = "@style/AppTheme")]
    public class NestedActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.nested_layout);
        }
    }

    [Activity(Label = "Constraints", Theme = "@style/AppTheme")]
    public class ConstraintsActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.constraints_layout);
        }
    }
}