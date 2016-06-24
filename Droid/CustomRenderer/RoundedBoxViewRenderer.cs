using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Zena.Custom;
using Zena.Droid;

[assembly: ExportRenderer(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]

namespace Zena.Droid
{
	public class RoundedBoxViewRenderer : BoxRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged(e);

			SetWillNotDraw(false);

			Invalidate();
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == RoundedBoxView.CornerRadiusProperty.PropertyName)
			{
				Invalidate();
			}
		}

		public override void Draw(Canvas canvas)
		{
			var box = Element as RoundedBoxView;
			var rect = new Rect();
			var paint = new Paint()
			{
				Color = box.BackgroundColor.ToAndroid(),
				AntiAlias = true,
			};

			GetDrawingRect(rect);

			var radius = (float)(rect.Width() / box.Width * box.CornerRadius);

			canvas.DrawRoundRect(new RectF(rect), radius, radius, paint);
		}
	}
}

