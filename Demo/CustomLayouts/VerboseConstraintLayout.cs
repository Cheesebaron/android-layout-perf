using System;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Support.Constraints;
using Android.Util;

namespace Demo.CustomLayouts
{
    [Register("dk.ostebaronen.VerboseConstraintLayout")]
    public class VerboseConstraintLayout : ConstraintLayout
    {
        #region Constructors
        protected VerboseConstraintLayout(IntPtr javaReference, JniHandleOwnership transfer)
            : base(javaReference, transfer)
        {
        }

        public VerboseConstraintLayout(Context context)
            : base(context)
        {
        }

        public VerboseConstraintLayout(Context context, IAttributeSet attrs)
            : base(context, attrs)
        {
        }

        public VerboseConstraintLayout(Context context, IAttributeSet attrs, int defStyleAttr)
            : base(context, attrs, defStyleAttr)
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