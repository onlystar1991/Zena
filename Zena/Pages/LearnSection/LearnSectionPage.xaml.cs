using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Zena.Models;

namespace Zena.Learn
{
	public partial class LearnSectionPage : ContentPage
	{
		public LearnSectionPage()
		{
			InitializeComponent();
			Title = "Learn";
			NavigationPage.SetHasNavigationBar(this, false);
		}

		protected async override void OnAppearing()
		{
			var result = await App._HttpHandler.GetLearnContentList();

			if (result.status.result.Equals("success") && result.status.action.Equals("found"))
			{
				PopulateList(result);
			}
			else
			{
				await DisplayAlert("Warning", "Please check your network status.", "Ok");
			}
		}

		void PopulateList(LearnContentModel learnContentList)
		{
			var column = LearnContentRow;
			column.Children.Clear();

			var itemTapRecognizer = new TapGestureRecognizer();
			itemTapRecognizer.Tapped += OnItemTapped;

			for (var i = 0; i < learnContentList.data.list.learnContentArray.Count; i++)
			{
				var item = new LearnSectionListRow();

				item.BindingContext = learnContentList.data.list.learnContentArray[i];
				item.GestureRecognizers.Add(itemTapRecognizer);
				column.Children.Add(item);
			}

			actIndicator2.IsRunning = false;
		}

		private async void OnItemTapped(Object sender, EventArgs e)
		{
			
		}

	}
}

