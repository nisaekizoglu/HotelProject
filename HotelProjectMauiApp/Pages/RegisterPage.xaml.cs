using System;
using Microsoft.Maui.Controls;

namespace HotelProjectMauiApp.Pages
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text?.Trim();
            string email = EmailEntry.Text?.Trim();
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Hata", "L�tfen t�m alanlar� doldurun.", "Tamam");
                return;
            }

            // Burada backend'e kay�t i�lemi yap�labilir

            await DisplayAlert("Ba�ar�l�", "Kay�t i�lemi tamamland�!", "Tamam");

            // Giri� sayfas�na y�nlendir
            await Navigation.PushAsync(new LoginPage());
        }

        private async void OnNavigateToLogin(object sender, EventArgs e)
        {
            // Kay�t sayfas�ndan giri� sayfas�na gitmek i�in
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
