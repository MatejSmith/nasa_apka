using System;

using Xamarin.Forms;

namespace nasa_apka
{
	public class Page1 : ContentPage
	{
		public Page1()
		{
			var nextPageButton = new Button { Text = "Súhlasím", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButton.Clicked += OnNextPageButtonClicked;
			var exitPageButton = new Button { Text = "Nesúhlasím", VerticalOptions = LayoutOptions.CenterAndExpand };
			exitPageButton.Clicked += ExitApp;
			Title = "Úvod";
			Content = new StackLayout
			{
				Children = {
					nextPageButton,
					exitPageButton
				}
			};
		}

		async void OnNextPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Page2());
		}
		void ExitApp(object sender, EventArgs e)
		{
			System.Environment.Exit(0);
		}
	}
}