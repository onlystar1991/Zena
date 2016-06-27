using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Widget;
using Android.Support.V7.App;
using Zena;
using Zena.Droid;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbarCustomeRenderer))]

namespace Zena.Droid
{
	public class TabbarCustomeRenderer : TabbedRenderer
	{
		private FormsAppCompatActivity activity;
		private bool isFirstDesign = true;

		protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
		{
			base.OnElementChanged(e);
			activity = this.Context as FormsAppCompatActivity;
		}

		protected override void OnWindowVisibilityChanged(Android.Views.ViewStates visibility)
		{
			base.OnWindowVisibilityChanged(visibility);

			if (isFirstDesign)
			{
				
				Android.App.ActionBar actionBar = activity.ActionBar;

				ColorDrawable colorDrawable = new ColorDrawable(Android.Graphics.Color.White);
				activity.ActionBar.SetStackedBackgroundDrawable(colorDrawable);

				// TODO: set tab text color

				isFirstDesign = false;
			}
		}
	}
}

