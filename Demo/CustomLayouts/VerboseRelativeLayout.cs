using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace Demo.CustomLayouts
{
    [Register("dk.ostebaronen.VerboseRelativeLayout")]
    public class VerboseRelativeLayout : RelativeLayout
    {
        private readonly string _indent;

        #region Constructors
        protected VerboseRelativeLayout(IntPtr javaReference, JniHandleOwnership transfer) 
            : base(javaReference, transfer)
        {
        }

        public VerboseRelativeLayout(Context context) 
            : base(context)
        {
        }

        public VerboseRelativeLayout(Context context, IAttributeSet attrs) 
            : base(context, attrs)
        {
            _indent = GetIndent(context, attrs);
        }

        public VerboseRelativeLayout(Context context, IAttributeSet attrs, int defStyleAttr) 
            : base(context, attrs, defStyleAttr)
        {
            _indent = GetIndent(context, attrs);
        }

        public VerboseRelativeLayout(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) 
            : base(context, attrs, defStyleAttr, defStyleRes)
        {
            _indent = GetIndent(context, attrs);
        }

        private static string GetIndent(Context context, IAttributeSet attrs)
        {
            using (var array = context.ObtainStyledAttributes(attrs, Resource.Styleable.VerboseRelativeLayout))
            {
                var indent = array.GetInt(Resource.Styleable.VerboseRelativeLayout_verbose_indent, 0);
                array.Recycle();

                return new string('\t', indent);
            }
        }
        #endregion

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            var widthSize = MeasureSpec.GetSize(widthMeasureSpec);
            var heightSize = MeasureSpec.GetSize(heightMeasureSpec);

            var widthMode = MeasureSpec.GetMode(widthMeasureSpec);
            var heightMode = MeasureSpec.GetMode(heightMeasureSpec);

            System.Diagnostics.Debug.WriteLine($"{_indent}OnMeasure - W: ({widthMode} ; {widthSize})  H: ({heightMode} ; {heightSize})");

            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            System.Diagnostics.Debug.WriteLine($"{_indent}OnLayout - c: {changed} left: {l} top: {t} right: {r} bottom: {b}");

            base.OnLayout(changed, l, t, r, b);
        }

        protected override void OnDraw(Canvas canvas)
        {
            System.Diagnostics.Debug.WriteLine($"{_indent}OnDraw");

            base.OnDraw(canvas);
        }
    }
}