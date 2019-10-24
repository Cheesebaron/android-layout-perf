using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace Demo.CustomLayouts
{
    [Register("dk.ostebaronen.VerboseLinearLayout")]
    public class VerboseLinearLayout : LinearLayout
    {
        #region Constructors
        protected VerboseLinearLayout(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public VerboseLinearLayout(Context context)
            : base(context)
        {
        }

        public VerboseLinearLayout(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
        }

        public VerboseLinearLayout(Context context, IAttributeSet attrs, int defStyleAttr)
            : base(context, attrs, defStyleAttr)
        {
        }

        public VerboseLinearLayout(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes)
            : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }
        #endregion

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            var widthSize = MeasureSpec.GetSize(widthMeasureSpec);
            var heightSize = MeasureSpec.GetSize(heightMeasureSpec);

            var widthMode = MeasureSpec.GetMode(widthMeasureSpec);
            var heightMode = MeasureSpec.GetMode(heightMeasureSpec);

            System.Diagnostics.Debug.WriteLine($"{Id} OnMeasure - W: ({widthMode} ; {widthSize})  H: ({heightMode} ; {heightSize})");

            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            System.Diagnostics.Debug.WriteLine($"{Id} OnLayout - c: {changed} left: {l} top: {t} right: {r} bottom: {b}");

            base.OnLayout(changed, l, t, r, b);
        }

        protected override void OnDraw(Canvas canvas)
        {
            System.Diagnostics.Debug.WriteLine($"{Id} OnDraw");

            base.OnDraw(canvas);
        }
    }
}