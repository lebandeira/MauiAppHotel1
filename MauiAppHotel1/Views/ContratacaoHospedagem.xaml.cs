using MauiAppHotel1.Models;

namespace MauiAppHotel1.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
        
        dtpck_checkin.MinimumDate = DateTime.Now; //estabelecer o dia de hoje
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1); //sobre o check out para n�o ser no passado
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(6);

	}

    private void Button_Clicked(object sender, EventArgs e) //Sobre
    {
        try
        {
            Navigation.PushAsync(new Sobre());
        }
        catch (Exception ex) 
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e) //avan�ar
    {
        try
        {
            Hospedagem h = new Hospedagem
            {
                QuartoSelecionado = (Quarto)pck_quarto.SelectedItem,
                QntAdulto = Convert.ToInt32(stp_adultos.Value),
                QntCriancas = Convert.ToInt32(stp_criancas.Value),
                DataCheckIn = dtpck_checkin.Date,
                DataCheckOut = dtpck_checkout.Date,
            };

            await Navigation.PushAsync(new HospedagemContratada()
            {
                BindingContext = h
            });
        }
        catch (Exception ex) 
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }

    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }
}