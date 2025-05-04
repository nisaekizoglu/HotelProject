using System;
using Microsoft.Maui.Controls;

namespace HotelProjectMauiApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text?.Trim();
            string password = PasswordEntry.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                await DisplayAlert("Hata", "Lütfen tüm alanlarý doldurun.", "Tamam");
                return;
            }

            // Gerçek kimlik doðrulama iþlemi burada yapýlabilir
            // Þimdilik doðrudan baþarýlý varsayýyoruz
            await DisplayAlert("Baþarýlý", "Giriþ yapýldý!", "Tamam");

            await Navigation.PushAsync(new MainPage());
        }

        private async void OnNavigateToRegister(object sender, EventArgs e)
        {
            // Kayýt sayfasýna yönlendirme
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
