using System;
using Xamarin.Forms;


namespace nasa_apka
{

    public partial class Page1Xaml : ContentPage
    {
        public Page1Xaml()
        {
            InitializeComponent();

        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2Xaml());
        }

        private void ExitApp(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}