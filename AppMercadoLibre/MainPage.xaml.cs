using AppMercadoLibre.Models;

namespace AppMercadoLibre
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (username == "Alumno" && password == "1234")
            {
                await Navigation.PushAsync(new InfoPage());
            }
        }
    }

}
