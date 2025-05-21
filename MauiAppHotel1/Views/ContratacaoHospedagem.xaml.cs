namespace MauiAppHotel1.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
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

    private void Button_Clicked_1(object sender, EventArgs e) //avançar
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex) 
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }

    }
}