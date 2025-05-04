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
                await DisplayAlert("Hata", "L�tfen t�m alanlar� doldurun.", "Tamam");
                return;
            }

            // Ger�ek kimlik do�rulama i�lemi burada yap�labilir
            // �imdilik do�rudan ba�ar�l� varsay�yoruz
            await DisplayAlert("Ba�ar�l�", "Giri� yap�ld�!", "Tamam");

            await Navigation.PushAsync(new MainPage());
        }

        private async void OnNavigateToRegister(object sender, EventArgs e)
        {
            // Kay�t sayfas�na y�nlendirme
            await Navigation.PushAsync(new RegisterPage());
        }
    }
}
