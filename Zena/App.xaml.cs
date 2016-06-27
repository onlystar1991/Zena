using System;
using Xamarin.Forms;

using Zena.Network;

namespace Zena
{
	public partial class App : Application, ILoginManager
	{
		public static HttpHandler _HttpHandler { get; private set; }

		public App()
		{
			
			var isLoggedIn = Properties.ContainsKey("IsLoggedIn") && (bool)Properties["IsLoggedIn"];
			InitializeComponent();
			//_HttpManager = new HttpManager(new HttpHandler());
			_HttpHandler = new HttpHandler();
			MainPage = new ZenaPage();

			//if (isLoggedIn)
			//	MainPage = new ZenaPage();
			//else
			//	MainPage = new LoginModalPage(this);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}


		public void ShowMainPage()
		{
			MainPage = new ZenaPage();
		}

		public void Logout()
		{
			Properties["IsLoggedIn"] = false; // only gets set to 'true' on the LoginPage
			MainPage = new LoginModalPage(this);
		}
	}
}

