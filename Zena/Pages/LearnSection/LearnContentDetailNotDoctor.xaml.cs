using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Zena.Models.LearnByID;

namespace Zena.Learn
{
	public partial class LearnContentDetailNotDoctor : ContentPage
	{
		private int itemID { set; get; }

		public LearnContentDetailNotDoctor(int id)
		{
			itemID = id;
			InitializeComponent();
			NavigationPage.SetHasNavigationBar(this, false);
		}

		async void OnBackItemClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		protected async override void OnAppearing()
		{
			var result = await App._HttpHandler.GetLearnContentById(this.itemID);
			if (result.status.result.Equals("success") && result.status.action.Equals("found"))
			{
				MakeViewWithData(result);
			}
			else
			{
				await DisplayAlert("Warning", "Can't connect to network.", "Ok");
				await Navigation.PopAsync();
			}

		}

		private void MakeViewWithData(LearnContentByIDModel data)
		{
			MainImage.Source = ImageSource.FromUri(new Uri(data.data.list.openingPicUrl));
		}
	}
}

