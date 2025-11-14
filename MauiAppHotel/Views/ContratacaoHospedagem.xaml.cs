using MauiAppHotel.Models;
using MauiAppHotel.Views; // Certifique-se de importar a página Sobre

namespace MauiAppHotel.Views
{
    public partial class ContratacaoHospedagem : ContentPage
    {
        App PropriedadesApp;

        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

            pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(1);

            dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
            dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);
        }

        private async void OnSobreClicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Sobre());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Não foi possível abrir a página Sobre.\n{ex.Message}", "OK");
            }
        }
        private async void AbrirAtracoes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AtracoesTuristicas());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Hospedagem h = new Hospedagem
                {
                    QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                    QntAdultos = Convert.ToInt32(stp_adultos.Value),
                    QntCriancas = Convert.ToInt32(stp_criancas.Value),
                    DateCheckIn = dtpck_checkin.Date,
                    DateCheckOut = dtpck_checkout.Date,
                };

                await Navigation.PushAsync(new HospedagemContratada()
                {
                    BindingContext = h
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "Ok");
            }
        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DateTime dataSelecionada = e.NewDate;

            dtpck_checkout.MinimumDate = dataSelecionada.AddDays(1);
            dtpck_checkout.MaximumDate = dataSelecionada.AddMonths(6);
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
