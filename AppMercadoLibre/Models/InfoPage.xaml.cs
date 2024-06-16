namespace AppMercadoLibre.Models;

public partial class InfoPage : ContentPage
{
	public InfoPage()
	{
		InitializeComponent();
	}
	public async void OnAboutUsClicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AboutUsPage());
    }
    public async void OnLogOutClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}