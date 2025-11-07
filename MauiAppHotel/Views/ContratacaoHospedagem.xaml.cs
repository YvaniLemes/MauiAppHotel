namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

	private async void OnSobreClicked(object sender, EventArgs e)

	{
		await Navigation.PushAsync(new Sobre());

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new HospedagemContratada());

		} catch (Exception ex)
			{
			DisplayAlert("Ops", ex.Message, "Ok");
		}

		}
    }

