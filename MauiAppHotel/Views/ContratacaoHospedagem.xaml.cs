namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void OnSobreClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Sobre");
    }
}