using System;
using Xamarin.Forms;

namespace Zena
{
	public class LoginModalPage : CarouselPage
	{
		ContentPage login, create;
		public LoginModalPage(ILoginManager ilm)
		{
			login = new LoginPage(ilm);
			create = new RegisterPage(ilm);
			this.Children.Add(login);
			this.Children.Add(create);

			MessagingCenter.Subscribe<ContentPage>(this, "Login", (sender) =>
			{
				this.SelectedItem = login;
			});
			MessagingCenter.Subscribe<ContentPage>(this, "Register", (sender) =>
			{
				this.SelectedItem = create;
			});
		}
	}
}

