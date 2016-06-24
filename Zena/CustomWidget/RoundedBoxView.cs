using System;
using Xamarin.Forms;

namespace Zena.Custom
{
	public class RoundedBoxView : BoxView
	{
		public static readonly BindableProperty CornerRadiusProperty =
			BindableProperty.Create("CornerRadius", typeof(double), typeof(RoundedBoxView), 0.0);
		
		public double CornerRadius
		{
			get { return (double)GetValue(CornerRadiusProperty); }
			set { SetValue(CornerRadiusProperty, value); }
		}
	}
}

