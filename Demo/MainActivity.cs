using System;
using Android.App;
using Android.Widget;
using Android.OS;

namespace Demo
{
    [Activity(Label = "Demo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            var verboseButton = FindViewById<Button>(Resource.Id.button_verbose);
            verboseButton.Click += (sender, args) => StartActivity(typeof(VerboseActivity));

            var overdrawButton = FindViewById<Button>(Resource.Id.button_overdraw);
            overdrawButton.Click += (sender, args) => StartActivity(typeof(OverdrawActivity));
        }
    }
}