using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zena.Learn
{
	public partial class LearnSectionListRow : ContentView
	{
		int itemID { get; set;}
		bool isDoctor { get; set;}

		public LearnSectionListRow(int ID, bool _isDoctor)
		{
			InitializeComponent();
			itemID = ID;
			isDoctor = _isDoctor;
		}

		async void OnItemTapped(object sender, EventArgs e)
		{
			if (this.isDoctor)
			{
				await Navigation.PushAsync(new LearnContentDetail(itemID));
			}
			else 
			{
				await Navigation.PushAsync(new LearnContentDetail(itemID));
			}

		}
	}
}

