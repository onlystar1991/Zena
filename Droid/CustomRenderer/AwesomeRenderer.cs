﻿using System;
using Xamarin.Forms.Platform.Android;
using Android.Widget;
using Android.Graphics;
using Xamarin.Forms;
using Zena.Droid;

[assembly: ExportRenderer(typeof(Label), typeof(AwesomeLabelRenderer))]

namespace Zena.Droid
{
	public class AwesomeLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);

			AwesomeUtil.CheckAndSetTypeFace(Control);
		}
	}

	internal static class AwesomeUtil
	{
		public static void CheckAndSetTypeFace(TextView view)
		{
			if (view.Text.Length == 0) return;
			var text = view.Text;
			if (text.Length > 1 || text[0] < 0xf000)
			{
				return;
			}

			var font = Typeface.CreateFromAsset(Xamarin.Forms.Forms.Context.ApplicationContext.Assets, "fontawesome.ttf");
			view.Typeface = font;
		}
	}
}
