using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Zena.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbarCustomRenderer))]

namespace Zena.iOS
{
	public class TabbarCustomRenderer : TabbedRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			// Set Text Font for unselected tab states
			UITabBar.Appearance.BarTintColor = UIKit.UIColor.FromRGB(26, 186, 175);
			UITabBar.Appearance.SelectedImageTintColor = UIColor.White;
		}
	}
}

