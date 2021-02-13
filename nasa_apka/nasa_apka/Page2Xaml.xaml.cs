using System;
using Xamarin.Forms;


namespace nasa_apka
{
  
    public partial class Page2Xaml : ContentPage
    {
        public Page2Xaml()
        {
            InitializeComponent();
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3Xaml());
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