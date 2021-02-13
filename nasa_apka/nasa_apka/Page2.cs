using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace nasa_apka
{
    public class Page2 : ContentPage
	{
		public Page2()
		{
			var nextPageButton = new Button { Text = "Bolesť hlavy", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButton.Clicked += OnNextPageButtonClicked;

			var previousPageButton = new Button { Text = "Previous Page", VerticalOptions = LayoutOptions.CenterAndExpand };
			previousPageButton.Clicked += OnPreviousPageButtonClicked;

			var nextPageButtonA = new Button { Text = "Bolesť brucha", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButtonA.Clicked += OnNextPageButtonClicked;
			
			var nextPageButtonB = new Button { Text = "Vypadávanie vlasov", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButtonB.Clicked += OnNextPageButtonClicked;
			
			var nextPageButtonC = new Button { Text = "Bolesť hrdla", VerticalOptions = LayoutOptions.CenterAndExpand };
			nextPageButtonC.Clicked += OnNextPageButtonClicked;


			Title = "Príznaky";
			Content = new StackLayout
			{
				Children = {
					nextPageButton,
					previousPageButton,
					nextPageButtonA,
					nextPageButtonB,
					nextPageButtonC
				}
			};
		}

		async void OnNextPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Page3());
		}

		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}
		async void OnNextPageButtonClickedA(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Page4Xaml());
		}

		async void OnNextPageButtonClickedB(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Page5Xaml());
		}

		async void OnNextPageButtonClickedC(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Page6Xaml());
		}
	}
}
