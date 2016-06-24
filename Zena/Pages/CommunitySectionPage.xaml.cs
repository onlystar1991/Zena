using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zena
{
	public partial class CommunitySectionPage : ContentPage
	{
		public CommunitySectionPage()
		{
			InitializeComponent();
			Title = "Community";

			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}

