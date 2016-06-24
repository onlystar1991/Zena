using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Zena.Custom;
using Zena.iOS;

[assembly: ExportRenderer(typeof(RoundedBoxView), typeof(RoundedBoxViewRenderer))]

namespace Zena.iOS
{
	public class RoundedBoxViewRenderer : BoxRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<BoxView> e)
		{
			base.OnElementChanged(e);

			if (Element != null)
			{
				Layer.MasksToBounds = true;
				UpdateCornerRadius(Element as RoundedBoxView);
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName == RoundedBoxView.CornerRadiusProperty.PropertyName)
			{
				UpdateCornerRadius(Element as RoundedBoxView);
			}
		}

		void UpdateCornerRadius(RoundedBoxView box)
		{
			Layer.CornerRadius = (float)box.CornerRadius;
		}
	}
}

