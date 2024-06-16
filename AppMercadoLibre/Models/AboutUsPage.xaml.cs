namespace AppMercadoLibre.Models;

public partial class AboutUsPage : ContentPage
{
	public AboutUsPage()
	{
		InitializeComponent();
	}
    public async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InfoPage());
    }
}