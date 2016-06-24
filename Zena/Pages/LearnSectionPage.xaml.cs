using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zena
{
	public partial class LearnSectionPage : ContentPage
	{
		public LearnSectionPage()
		{
			InitializeComponent();

			Title = "Learn";

			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}

