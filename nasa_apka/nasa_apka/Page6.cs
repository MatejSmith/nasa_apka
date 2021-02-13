using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace nasa_apka
{
    public class Page6 : ContentPage
    {
        public Page6()
		{
			var previousPageButton = new Button { Text = "Predchádzajúca strana", VerticalOptions = LayoutOptions.CenterAndExpand };
			previousPageButton.Clicked += OnPreviousPageButtonClicked;

			var rootPageButton = new Button { Text = "Hlavná strana", VerticalOptions = LayoutOptions.CenterAndExpand };
			rootPageButton.Clicked += OnRootPageButtonClicked;


			Title = "Lieky";
			Content = new StackLayout
			{
				Children = {
					previousPageButton,
					rootPageButton,

				}
			};
		}

		async void OnPreviousPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		async void OnRootPageButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopToRootAsync();
		}
	}
}