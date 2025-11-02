namespace MauiAppHotel
{
    public partial class Sobre : ContentPage
    {
        public Sobre()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sobre());
            await Navigation.PopAsync();
        }
    }
}