using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zena
{
	public partial class RegisterPage : ContentPage
	{
		ILoginManager _ilm;
		public RegisterPage(ILoginManager ilm)
		{
			InitializeComponent();
			_ilm = ilm;
		}

		private void OnRegisterButtonClicked(object sender, EventArgs args)
		{
			DisplayAlert("Account created", "Add processing login here", "OK");
			_ilm.ShowMainPage();
		}

		private void OnCancelButtonClicked(object sender, EventArgs args)
		{
			MessagingCenter.Send<ContentPage>(this, "Register");
		}
	}
}

