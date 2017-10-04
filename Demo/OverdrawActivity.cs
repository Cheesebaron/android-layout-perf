using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using FFImageLoading;
using FFImageLoading.Views;
using Object = Java.Lang.Object;

namespace Demo
{
    [Activity(Label = "Overdraw")]
    public class OverdrawActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ListAdapter = new MonkeyAdapter(this, Resource.Layout.overdraw_row, new []
            {
                "http://1.bp.blogspot.com/-TvEz8A8XbH8/UardB3Zk0jI/AAAAAAAAE38/SkaiRImk-YU/s1600/Monkey.jpeg",
                "http://3.bp.blogspot.com/-E1imnssipoQ/TdPFoWc6X1I/AAAAAAAAGUk/a1mO87RuJkQ/s1600/baby-monkey-wallpaper.jpg",
                "https://erinmeyers.files.wordpress.com/2011/06/babymonkey.jpg",
                "http://4.bp.blogspot.com/-CJRq4MLNuSI/TZBo7bYaD5I/AAAAAAAAABE/Nitaxf35rQA/s1600/crazy+monkey+post+3.jpg",
                "http://news.nationalgeographic.com/content/dam/news/2016/10/08/drill-monkey-waq/drill-monkey-01.ngsversion.1475926206479.adapt.1900.1.jpg",
                "http://www.lanzaroteinformation.com/files/Monkey_2.jpg",
                "https://www.primates.com/monkeys/images/dourcoul.jpg",
                "http://1.bp.blogspot.com/-lICDldGhyno/UEzllh4G-2I/AAAAAAAABxQ/t3DucL0rQuM/s1600/pretty-monkey1.jpg",
                "http://www.lolhome.com/img_big/monkey-business.jpg"
            }.OrderBy(s => Guid.NewGuid()));
        }

        public class MonkeyAdapter : BaseAdapter
        {
            private readonly int _rowLayout;
            private readonly LayoutInflater _layoutInflater;
            private readonly List<string> _monkeys;

            public MonkeyAdapter(Context context, int rowLayout, IEnumerable<string> monkeys)
            {
                _rowLayout = rowLayout;
                _layoutInflater = LayoutInflater.FromContext(context);
                _monkeys = monkeys.ToList();
            }

            public override Object GetItem(int position)
            {
                return null;
            }

            public override long GetItemId(int position)
            {
                return position;
            }

            public override View GetView(int position, View convertView, ViewGroup parent)
            {
                var view = convertView ?? _layoutInflater.Inflate(_rowLayout, parent, false);

                var imageView = view.FindViewById<ImageViewAsync>(Resource.Id.monkeyMug);

                ImageService.Instance.LoadUrl(_monkeys[position]).IntoAsync(imageView);

                return view;
            }

            public override int Count => _monkeys.Count;
        }
    }
}