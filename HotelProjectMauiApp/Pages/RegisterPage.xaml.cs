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
                await DisplayAlert("Hata", "Lütfen tüm alanlarý doldurun.", "Tamam");
                return;
            }

            // Burada backend'e kayýt iþlemi yapýlabilir

            await DisplayAlert("Baþarýlý", "Kayýt iþlemi tamamlandý!", "Tamam");

            // Giriþ sayfasýna yönlendir
            await Navigation.PushAsync(new LoginPage());
        }

        private async void OnNavigateToLogin(object sender, EventArgs e)
        {
            // Kayýt sayfasýndan giriþ sayfasýna gitmek için
            await Navigation.PushAsync(new LoginPage());
        }
    }
}
