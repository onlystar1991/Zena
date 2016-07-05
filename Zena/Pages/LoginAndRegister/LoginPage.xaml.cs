using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Zena
{
	public partial class LoginPage : ContentPage
	{
		ILoginManager _ilm;

		public LoginPage(ILoginManager ilm)
		{
			InitializeComponent();
			_ilm = ilm;
		}

		private void OnLoginButtonClicked(object sender, EventArgs args)
		{
			if (String.IsNullOrEmpty(EmailEntry.Text) || String.IsNullOrEmpty(PasswordEntry.Text))
			{
				DisplayAlert("Validation Error", "Email and Password are required", "Re-try");
			}
			else
			{
				// REMEMBER LOGIN STATUS!
				Application.Current.Properties["IsLoggedIn"] = true;
				_ilm.ShowMainPage();
			}
		}

		private void OnRegisterButtonClicked(object sender, EventArgs args)
		{
			MessagingCenter.Send<ContentPage>(this, "Register");
		}
	}
}

