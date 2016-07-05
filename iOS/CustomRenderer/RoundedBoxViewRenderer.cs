using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Zena.Custom;
using Zena.iOS;
using UIKit;

[assembly: ExportRenderer(typeof(RoundedCustomView), typeof(RoundedCustomViewRenderer))]

namespace Zena.iOS
{
	public class RoundedCustomViewRenderer : ViewRenderer
	{
		UIView _view;

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			_view = NativeView;
			_view.Layer.BorderWidth = 1;
			_view.Layer.BorderColor = UIColor.FromRGB(200, 200, 200).CGColor;
			_view.Layer.CornerRadius = 5;
		}

		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e);
		}
	}
}

