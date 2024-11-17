using Microsoft.Maui.Controls;

namespace AppHotel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Evento para o botão "Sobre"
        private async void OnSobreButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SobrePage());
        }
    }
}
