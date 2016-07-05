using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Zena.Models.Learn;

namespace Zena.Learn
{
	public partial class LearnSectionPage : ContentPage
	{
		StackLayout column;
		public LearnSectionPage()
		{
			InitializeComponent();
			Title = "Learn";
			NavigationPage.SetHasNavigationBar(this, false);
			this.column = LearnContentRow;
		}

		protected async override void OnAppearing()
		{
			this.column.Children.Clear();
			actIndicator2.IsRunning = true;
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
			for (var i = 0; i < learnContentList.data.list.learnContentArray.Count; i++)
			{
				var data = learnContentList.data.list.learnContentArray[i];
				var item = new LearnSectionListRow(data.id, data.posterIsDoctor);
				item.BindingContext = learnContentList.data.list.learnContentArray[i];
				column.Children.Add(item);
			}
			actIndicator2.IsRunning = false;
		}
	}
}

