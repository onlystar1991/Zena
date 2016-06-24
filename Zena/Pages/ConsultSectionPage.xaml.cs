using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zena
{
	public partial class ConsultSectionPage : ContentPage
	{
		public ConsultSectionPage()
		{
			InitializeComponent();

			Title = "Consult";

			NavigationPage.SetHasNavigationBar(this, false);
		}
	}
}

