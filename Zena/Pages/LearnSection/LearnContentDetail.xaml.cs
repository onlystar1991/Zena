using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Zena.Models.LearnByID;
using Zena.Custom;

namespace Zena.Learn
{
	public partial class LearnContentDetail : ContentPage
	{
		private int itemID { set; get; }

		public LearnContentDetail(int id)
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
			PostTitle.Text = data.data.list.postTitle;
			PosterName.Text = data.data.list.posterName;

			PostDescription.Text = data.data.list.postBody.content;
			PostCommnet.Text = data.data.list.postBody.content;
			BottomAvatar.Source = data.data.list.openingPicUrl;
			BottomTitle.Text = data.data.list.postTitle;
			PostCommnet.Text = data.data.list.postBody.content;

			//ConsultNum.Text = data.data.list.likeData;
			ConsultNum.Text = "0";
			ConsultLabel.Text = "\uf0f1";
			LikeNum.Text = "0";
			LikeLabel.Text = "\uf164";
		}
	}
}











































































































































































































		

	


