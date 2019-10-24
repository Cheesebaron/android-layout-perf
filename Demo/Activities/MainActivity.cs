using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Demo
{
    [Activity(Label = "Demo", MainLauncher = true, Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var verboseButton = FindViewById<Button>(Resource.Id.button_verbose);
            verboseButton.Click += (sender, args) => StartActivity(typeof(VerboseActivity));

            var linearVerboseButton = FindViewById<Button>(Resource.Id.button_verbose_linear);
            linearVerboseButton.Click += (sender, args) => StartActivity(typeof(Verbose2Activity));

            var constraintVerboseButton = FindViewById<Button>(Resource.Id.button_verbose_constraint);
            constraintVerboseButton.Click += (sender, args) => StartActivity(typeof(Verbose3Activity));

            var overdrawButton = FindViewById<Button>(Resource.Id.button_overdraw);
            overdrawButton.Click += (sender, args) => StartActivity(typeof(OverdrawActivity));

            var nestedButton = FindViewById<Button>(Resource.Id.button_nested);
            nestedButton.Click += (sender, args) => StartActivity(typeof(NestedActivity));

            var constraintsButton = FindViewById<Button>(Resource.Id.button_constraints);
            constraintsButton.Click += (sender, args) => StartActivity(typeof(ConstraintsActivity));

            var customDrawButton = FindViewById<Button>(Resource.Id.button_draw);
            customDrawButton.Click += (sender, args) => StartActivity(typeof(DrawActivity));


            //StrictMode.SetThreadPolicy(new StrictMode.ThreadPolicy.Builder().DetectAll().PenaltyLog().Build());
            //StrictMode.SetVmPolicy(new StrictMode.VmPolicy.Builder().DetectLeakedSqlLiteObjects().DetectLeakedClosableObjects().PenaltyLog().PenaltyDeath().Build());
        }
    }
}